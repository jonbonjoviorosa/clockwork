# README #

Welcome to the AWH interview exercise.

This repo contains one solution with two projects.  It is targeted for C# and javascript developers.

####Project Clockwork.API####
Clockwork.API is a simple API that returns a time date object and records the IP address, and timedate of any callers to the API in a SQLite database.

####Project Clockwork.Web####
Clockwork.Web is a simple website that uses javascript to call the API at the push of a button and displays the resulting JSON object.

####Required Technologies####
* A windows or Mac computer.
* Visual Studio Community Edition (latest version).  Note there are missing components on the Mac that you will have to self install (NuGet CLI) to run the API project while running the website.

### What is this repository for? ###
The goal of this exercise is to get this solution up and running as part of the interview process to AWH.  This is to test your ability to work with git, compile existing applications and to fix issues that you encounter when getting a project up and running.

Once you have a running project that works as intended, you will be asked to make several feature enhancements.

* Clockwork version 1.0

### How do I get set up? ###

* Install Visual Studio Community 2017 or Visual Studio Code if you do not have it set up.  Note that Visual Studio 2015 will not work with this project.
* Clone this repo.
* Change local configurations that may need changed for your environment.
* Check CORS access.
* Since this is a code first project you may need to run migrations to generate the database.


### Contribution guidelines ###

* Only AWH staff should be push changes to this repo

### Who do I talk to? ###

* For this repo, questions on direction, scope, or intent can be directed to robin.walters@awh.net

### Additional Resources ###
[Getting Started with EF Core on .NET Core Console App with a New database](https://docs.microsoft.com/en-us/ef/core/get-started/netcore/new-db-sqlite)

[EF Core .NET Command-line Tools](https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/dotnet)

[Migrations - EF Core with ASP.NET Core MVC](https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/migrations#introduction-to-migrations)
