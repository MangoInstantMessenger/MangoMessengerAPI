using System;
using System.Security.Cryptography;

namespace MangoAPI.Application.Services
{
    public class RandomGenerator : IDisposable
    {
        private readonly RNGCryptoServiceProvider _rngCryptoServiceProvider;

        public RandomGenerator()
        {
            _rngCryptoServiceProvider = new RNGCryptoServiceProvider();
        }
        
        public int Next(int minValue, int maxExclusiveValue)
        {
            if (minValue != maxExclusiveValue)
            {
                if (minValue > maxExclusiveValue)
                {
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(minValue)} must be lower than {nameof(maxExclusiveValue)}");
                }

                var difference = (long) maxExclusiveValue - minValue;
                var upperBound = uint.MaxValue / difference * difference;

                uint unsignedInt;

                do
                {
                    unsignedInt = GetRandomUInt();
                } while (unsignedInt >= upperBound);

                return (int) (minValue + unsignedInt % difference);
            }

            return minValue;
        }

        private uint GetRandomUInt()
        {
            var randomBytes = GenerateRandomBytes(sizeof(uint));
            return BitConverter.ToUInt32(randomBytes, 0);
        }

        private byte[] GenerateRandomBytes(int bytesNumber)
        {
            var buffer = new byte[bytesNumber];
            _rngCryptoServiceProvider.GetBytes(buffer);
            return buffer;
        }

        private bool _disposed;
        
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                _rngCryptoServiceProvider?.Dispose();
            }

            _disposed = true;
        }
    }
}