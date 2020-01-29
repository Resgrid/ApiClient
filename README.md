Resgrid Api Client
===========================

A cross platform api client library built using Microsoft .Net Core Standard that utilizes the Resgrid API to interact with your department

*********

[![Build status](https://ci.appveyor.com/api/projects/status/github/resgrid/apiclient?svg=true)](https://ci.appveyor.com/api/projects/status/github/resgrid/apiclient)
[![ResgridApiClient](https://img.shields.io/nuget/v/Resgrid.ApiClient.svg)](https://www.nuget.org/packages/Resgrid.ApiClient/)

About Resgrid
-------------
Resgrid is a software as a service (SaaS) logistics, management and communications platform for first responders, volunteer fire departments, career fire, EMS, Search and Rescue (SAR), public safety, HAZMAT, CERT, disaster response, etc.

[Sign up for your free Resgrid Account Today!](https://resgrid.com)

## Requirements ##
* .NET Standard V2.0+

## Installation ##

Using the [.NET Core command-line interface (CLI) tools][dotnet-core-cli-tools]:

```sh
dotnet add package Resgrid.ApiClient
```

Using the [NuGet Command Line Interface (CLI)][nuget-cli]:

```sh
nuget install Resgrid.ApiClient
```

Using the [Package Manager Console][package-manager-console]:

```powershell
Install-Package Resgrid.ApiClient
```

From within Visual Studio:

1. Open the Solution Explorer.
2. Right-click on a project within your solution.
3. Click on *Manage NuGet Packages...*
4. Click on the *Browse* tab and search for "Resgrid.ApiClient".
5. Click on the Resgrid.ApiClient package, select the appropriate version in the
   right-tab and click *Install*.
   
## Documentation

You can view the Resgrid Api Documentation at [https://api.resgrid.com](https://api.resgrid.com/Help)


## Usage

### Initial Setup

To begin using the ApiClient you first need to call the Init() function with the base url of the api and your username and password for the account making the requests.

```c#
ResgridV3ApiClient.Init("https://api.resgrid.com", "YOUR USERNAME", "YOUR PASSWORD");
```

Once you've Initialized the ApiClient you can call the Apis you want and they will handle the underlying Auth()'ing for each request.

## Notes ##


## Author's ##
* Shawn Jackson (Twitter: @DesignLimbo Blog: http://designlimbo.com)
* Jason Jarrett (Twitter: @staxmanade Blog: http://staxmanade.com)

## License ##
[Apache 2.0](https://www.apache.org/licenses/LICENSE-2.0)