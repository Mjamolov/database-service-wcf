# WCF SQL Service

## Description

Test task implementing a WCF (SOAP) service and a WinForms client for working with MS SQL Server.

## Features

* Connect to SQL Server
* Get SQL Server version ('SELECT @@VERSION')
* Disconnect from database

## Technologies

* C#
* .NET Framework
* WCF (basicHttpBinding)
* ADO.NET
* WinForms

## How to run

1. Open ConnectDB.sln in Visual Studio
2. Set multiple startup projects:

   * DatabaseService
   * DatabaseClient
3. Run the solution (F5)
4. Use UI buttons to call service methods

## Notes

* Connection string is configured in Web.config
* Simplified implementation for test purposes

## Possible improvements

* Async/await
* Logging
* Dependency Injection
* FaultContracts for error handling
