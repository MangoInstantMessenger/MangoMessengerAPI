# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning v2.0.0](https://semver.org/spec/v2.0.0.html).

## [Unreleased]

### Changed

- Updated bicep infrastructure as code
- Azure storage account for terraform state is created via Azure Pipelines
- Assets copied to azure blob storage as part of CI/CD
- Azure KeyVault used to access secrets inside CI/CD pipelines
- Azure Application insights added
- Message file attachment implemented (
  by [@islamumarov](https://github.com/MangoInstantMessenger/MangoMessengerAPI/pull/354))
- CI/CD pipelines separated into two separate files
- Implement terraform infrastructure as code
- Azure pipelines CI/CD trigger approval added for: Sonarcloud, Mend bolt scan jobs