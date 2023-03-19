# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning v2.0.0](https://semver.org/spec/v2.0.0.html).

## [Unreleased]

### Changed

## [0.2.1]

### Changed

- Message submission flow updated ([#440](https://github.com/MangoInstantMessenger/MangoMessengerAPI/issues/440)
  by [@Ketteiteki](https://github.com/Ketteiteki))
- Semantic version is properly displayed on UI at
  settings ([#438](https://github.com/MangoInstantMessenger/MangoMessengerAPI/issues/438))
- Separate model for send message real-time
  notification ([#449](https://github.com/MangoInstantMessenger/MangoMessengerAPI/issues/449))
- Smooth scrolling added to message box ([#437](https://github.com/MangoInstantMessenger/MangoMessengerAPI/issues/437))
- Settings UI bug fixed ([#445](https://github.com/MangoInstantMessenger/MangoMessengerAPI/issues/445))
- Message deletion flow updated ([#442](https://github.com/MangoInstantMessenger/MangoMessengerAPI/issues/442)
  by [@Ketteiteki](https://github.com/Ketteiteki))

## [v0.2.0]

### Changed

- Realtime flow improved, few issues are fixed
- Angular version bump to 15.2.2
- Reply to message feature (by [@Ketteiteki](https://github.com/Ketteiteki))
- Message attachment UI improvement (by [@Ketteiteki](https://github.com/Ketteiteki))
- Angular app API url is transformed during CI/CD build
- Angular app API url parameter is moved to config.json file
- Azure storage account for terraform state is created via Azure Pipelines
- Updated bicep infrastructure as code
- Assets copied to azure blob storage as part of CI/CD
- Azure KeyVault used to access secrets inside CI/CD pipelines
- Azure Application insights added
- Message file attachment implemented
  (by [@islamumarov](https://github.com/MangoInstantMessenger/MangoMessengerAPI/pull/354))
- CI/CD pipelines separated into two separate files
- Implement terraform infrastructure as code
- Azure pipelines CI/CD trigger approval added for: Sonarcloud, Mend bolt scan jobs