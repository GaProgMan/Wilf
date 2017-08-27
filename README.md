# Wilf

## Licence
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

## Description

A .NET Core MVC application for choosing a random TV show within a given TV series.

It has been released, as is, using an MIT licence. For more information on the MIT licence, please see either the `LICENSE` file in the root of the repository or see the tl;dr Legal page for [MIT](https://tldrlegal.com/license/mit-license)

## Code of Conduct
Wilf has a Code of Conduct which all contributors, maintainers and forkers must adhere to. When contributing, maintaining, forking or in any other way changing the code presented in this repository, all users must agree to this Code of Conduct.

See `Code of Conduct.md` for details.

## Project Name

The project name comes from one of the Discworld Gods. Two quote the [L-Space wiki](https://wiki.lspace.org/mediawiki/Wilf):

> The God of astrology. In the consensus present, on a disc/turtle cosmology that moves so rapidly that the relative positions of the stars alter from week to week, it has been pointed out that astrology stands little chance of entrenching itself and has not been able to break out of being a highly specialised niche subject.

## Creating the Database

This will need to be perfored before running the application for the first time

1. Change to the Persistence directory (i.e. `Wilf/Wilf.Persistence`)

    `cd Wilf.Persistence`

1. Issue the Entity Framework command to update the database

    `dotnet ef database update`

    This will ensure that all migrations are used to create or alter the local database instance

## Building and Running

1. Change to the api directory (i.e. `Wilf/Wilf.UI`)

    `cd Wilf.UI`

1. Issue the `dotnet` restore command (this resolves all NuGet packages)

    `dotnet restore`

1. Issue the `dotnet` build command

    `dotnet build`

1. Issue the `dotnet` run command

    `dotnet run`

    This will start the Kestrel webserver, load the `Wilf` application and tell you, via the terminal, what the url to access `Wilf` will be. Usually this will be `http://localhost:5000`, but it may be different based on your system configuration.