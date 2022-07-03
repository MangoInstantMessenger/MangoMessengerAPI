./.sonar/scanner/dotnet-sonarscanner begin /k:"MangoInstantMessenger_MangoMessengerAPI" /o:"mangoinstantmessenger" /d:sonar.login="${{ secrets.SONAR_TOKEN }}" /d:sonar.host.url="https://sonarcloud.io" /d:sonar.exclusions="MangoAPI.Infrastructure/Migrations"
dotnet build -c Release
./.sonar/scanner/dotnet-sonarscanner end /d:sonar.login="${{ secrets.SONAR_TOKEN }}"