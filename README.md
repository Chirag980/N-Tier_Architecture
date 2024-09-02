# N-Tier_Architecture

# N-Tier Architecture Project

## Overview

This project is built using the N-Tier Architecture pattern, which separates an application into distinct layers. Each layer has a specific responsibility, promoting separation of concerns and enhancing the maintainability and scalability of the application.

## Layers

### 1. **Presentation Layer**
   - **Description:** This layer is responsible for handling the user interface and user interactions. It communicates with the Business Logic Layer to present data to the users.
   - **Technologies:** ASP.NET MVC, Razor Pages, HTML/CSS, JavaScript, jQuery

### 2. **Business Logic Layer (BLL)**
   - **Description:** This layer contains the core business logic of the application. It processes data received from the Presentation Layer and interacts with the Data Access Layer for data manipulation.
   - **Technologies:** C#, .NET Core, Services, Business Objects

### 3. **Data Access Layer (DAL)**
   - **Description:** This layer handles all data-related operations, such as retrieving and storing data in the database. It abstracts the underlying data source from the Business Logic Layer.
   - **Technologies:** Entity Framework Core, ADO.NET, LINQ

### 4. **Database Layer**
   - **Description:** This layer is where the actual data resides. It stores and retrieves data based on the requests from the Data Access Layer.
   - **Technologies:** SQL Server, MySQL, Oracle

## Project Structure

### Key Components

- **Controllers:** Handle incoming HTTP requests and pass them to the appropriate service in the Business Logic Layer.
- **Services:** Contain business rules and logic, interacting with repositories in the Data Access Layer.
- **Repositories:** Provide a data abstraction layer, managing CRUD operations with the database.
- **Entities:** Represent the data structure, corresponding to the database tables.
- **DataContext:** Manages the connection to the database and tracks changes to the entities.

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

