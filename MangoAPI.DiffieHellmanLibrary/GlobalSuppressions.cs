// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Won't fix", Scope = "member", Target = "~M:MangoAPI.DiffieHellmanLibrary.CngHandlers.CngCreateCommonSecretHandler.CngCreateCommonSecret(MangoAPI.BusinessLogic.Models.Actor,System.Guid)~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Won't fix", Scope = "member", Target = "~M:MangoAPI.DiffieHellmanLibrary.CngHandlers.CngGeneratePublicKeyHandler.GenerateBase64PublicKey(System.Guid)~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Won't fix", Scope = "member", Target = "~M:MangoAPI.DiffieHellmanLibrary.Helpers.CngEcdhHelper.GenerateEcdhBase64StringPrivateKey~MangoAPI.DiffieHellmanLibrary.Helpers.EccDhKeyPair")]
[assembly: SuppressMessage("StyleCop.CSharp.NamingRules", "SA1313:Parameter names should begin with lower-case letter", Justification = "Won't fix", Scope = "type", Target = "~T:MangoAPI.DiffieHellmanLibrary.Helpers.EccDhKeyPair")]
[assembly: SuppressMessage("StyleCop.CSharp.NamingRules", "SA1313:Parameter names should begin with lower-case letter", Justification = "Won't fix", Scope = "type", Target = "~T:MangoAPI.DiffieHellmanLibrary.OpenSslHandlers.HashResult")]
