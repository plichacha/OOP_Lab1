# OOP Lab 1 — Virtual Item Shop

## Overview

This project is a university laboratory assignment focused on the fundamentals of **Object-Oriented Programming (OOP)** in C#.

The application represents a simple **virtual item shop** implemented as a console application. It demonstrates the use of classes, objects, enumerations, validation, methods, and basic object management through an interactive menu.

## Features

The application provides functionality for working with items in a virtual shop, including:

* Creating and managing objects
* Working with classes and their properties
* Using enumerations (`enum`)
* Input validation
* Displaying information in the console
* Managing a collection of shop items
* Interactive console-based menu
* Basic error handling for invalid input

## Technologies

* **C#**
* **.NET**
* **Object-Oriented Programming**
* **Console Application**
* **Visual Studio / .NET CLI**

## OOP Concepts

The project demonstrates several fundamental OOP concepts:

### Classes and Objects

Classes are used to define the structure and behavior of entities in the application. Objects are created from these classes and used to represent individual items.

### Encapsulation

Properties and methods are used to control access to object data and keep related data and behavior together.

### Enumerations

`enum` types are used to represent predefined sets of values, making the code easier to understand and maintain.

### Validation

User input is validated before it is used by the application. This helps prevent invalid data from being added to the system.

### Object Management

The application demonstrates basic operations for creating, storing, displaying, and managing objects.

## Project Structure

```text
OOP_Lab1/
├── OOP_Lab1_Nesteruk/
│   ├── Source files
│   └── Project files
├── OOP_Lab1_Nesteruk.sln
└── .gitignore
```

## How to Run

### Using Visual Studio

1. Clone the repository:

```bash
git clone https://github.com/plichacha/OOP_Lab1.git
```

2. Open `OOP_Lab1_Nesteruk.sln` in Visual Studio.
3. Restore the required .NET dependencies if necessary.
4. Build the solution.
5. Run the project.

### Using .NET CLI

Navigate to the project directory and run:

```bash
dotnet restore
dotnet build
dotnet run
```

## Application Workflow

After starting the application, the user interacts with the program through a console menu.

The general workflow is:

```text
Start application
       ↓
Display menu
       ↓
Select an operation
       ↓
Enter required data
       ↓
Validate input
       ↓
Perform the selected operation
       ↓
Display the result
       ↓
Return to the menu
```

## Purpose of the Project

The main purpose of this laboratory work is to gain practical experience with fundamental Object-Oriented Programming concepts in C# and to understand how classes and objects can be combined to create a simple interactive application.

## Repository

Source code is available on GitHub:

https://github.com/plichacha/OOP_Lab1

## Author

**plichacha**

University OOP Laboratory Work — Lab 1
