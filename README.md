# mvcproject
# ASP.NET Core MVC Web Application

## Overview
The ASP.NET Core MVC architecture is demonstrated in this project. It concentrates on developing web applications, placing special emphasis on controllers, views, models, database setup, adding initial data, and handling fictitious entries.

## Table of Contents

1. [Requirements](#requirements)
2. [Project Creation](#project-creation)
3. [Sample Controller and Views](#sample-controller-and-views)
4. [Todolist View](#todolist-view)
5. [Model Creation](#model-creation)
6. [Scaffolding and Database](#scaffolding-and-database)
7. [Seed Data](#seed-data)
8. [Not Found View](#not-found-view)


## Requirements

- [.NET Framework 6](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
- [Visual Studio Code](https://code.visualstudio.com/download)
- [MS SQL Server](https://www.microsoft.com/en-ca/sql-server/sql-server-downloads)
- [MS SQL Management Studio](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16)
- [Entity Framework Core 6.0](https://learn.microsoft.com/en-us/ef/core/what-is-new/ef-core-6.0/whatsnew)

### Project Creation

Using the "dotnet" command-line tools in Visual Studio Code, I made a new ASP.NET Core MVC project. This offered the fundamental framework for our online application.


dotnet new mvc -n MyMvcApp


For running the application

Change the directory to the main application


cd MVCPROJECT



dotnet build

After a successful build, then


dotnet run


For accessing the application

- Open a web browser and go to `http://localhost:5000`.

## Sample Controller and Views

A example controller containing the methods "Index" and "Todolist" has been added. A welcome message about the project is shown via the "Index" method. Id, title, and description are the three arguments passed to the "Todolist" method. These methods were implemented using Razor syntax and corresponding views.

## Todolist View

Implemented input boxes to gather user input for the id, title, and description in the Todolist view. A button that enables users to add items to a list using the entered data was also included. The user is then shown the newly added item.

## Model Creation

Six properties were used to generate a "Artist" model, one of which was a "Id" attribute. This model serves as an illustration of how data is represented in the application.

## Scaffolding and Database

The necessary controller and views were automatically generated using the "Artist" model's scaffolding. For this model, we set up a SQLite database to hold the data. The project was designed to function with the database without any issues.

## Seed Data

'SeedData.cs', a seed data file, was made and placed in the Models folder. The database is initialized with at least four records in this file, giving the program its first set of data.

## Not Found View

The Views/Artist folder now contains a "NotFound" view. Methods in the Artist controller have been changed to deal with scenarios in which a user submits an ID that doesn't exist. The user is then forwarded to the "NotFound" page, where a notice stating that the record with the supplied ID is not found is shown. To take the user back to the Artist model's index page, a link is offered.