# OOP ContactLMS

## Project Overview

**OOP_ContactLMS** is a Windows Forms application built using C#. It allows users to manage a contact list with functionalities such as adding, updating, deleting, and viewing contacts. This project demonstrates the application of Object-Oriented Programming (OOP) principles such as Encapsulation, Abstraction, Inheritance, and Polymorphism.

## Features

- **Add Contact**: Allows users to add new contacts by entering details like First Name, Last Name, Email, Phone Number, Company Name, and Address.
- **View Contacts**: Displays all contacts in a grid with options to search contacts by name, email, or phone number.
- **Update Contact**: Allows users to select a contact from the list and update its details.
- **Delete Contact**: Enables the deletion of a selected contact after user confirmation.
- **Search Contacts**: Users can search contacts by entering a name, email, or phone number in the search bar.
- **User Validation**: Ensures that mandatory fields (First Name, Last Name, Email, and Phone Number) are filled before allowing users to add or update a contact.

## Technologies Used

- **C#** (Windows Forms)
- **SQL Server** for database management

## Prerequisites

To run this project, you will need:
- **Visual Studio** (2019 or later)
- **SQL Server** (or any equivalent database that supports ADO.NET)
- **.NET Framework 4.8** or later

## Project Structure

The project consists of the following main components:

### 1. **LoginPage**
   - The initial login screen for the application. It checks for a phone number and prevents duplicate entries. If the phone number is already registered, the user cannot proceed.

### 2. **MainPage**
   - The central hub of the application that contains buttons to switch between different views like "Add Contacts" and "View Contacts". It dynamically loads different user controls into the main panel for navigation.

### 3. **ViewContactsControl**
   - Displays a list of contacts in a `DataGridView`. Users can search contacts and reload the contact list. The contact list is loaded from the SQL Server database.
   
### 4. **AddContactsControl**
   - Allows users to add a new contact by filling in fields such as First Name, Last Name, Email, Phone Number, Company Name, and Address. It also allows users to update or delete selected contacts.

### 5. **ContactDB Class**
   - Handles all database operations such as adding, updating, deleting, and retrieving contacts. This class interacts with the database using SQL queries and encapsulates the database logic from the UI components.

## How to Run the Project

### 1. Set Up the Database
Before running the project, ensure that you have an SQL Server database set up. You need to create a table for storing contact details.

Here’s an example SQL script for creating the `Contacts` table:

```sql
CREATE TABLE Contacts (
    ContactID INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    Email NVARCHAR(100),
    PhoneNumber NVARCHAR(15),
    CompanyName NVARCHAR(100),
    Address NVARCHAR(255)
);
```
Make sure to configure the database connection string in the ContactDB class based on your SQL Server settings.

### 2. Clone the Repository

```bash
git clone https://github.com/your-repository/OOP_ContactLMS.git
```

### 3. Open the Project in Visual Studio
-   Open **Visual Studio**.
-   Select **File -> Open -> Project/Solution**.
-   Navigate to the cloned repository folder and open the `.sln` file.

### 4. Configure the Database Connection
Update the connection string in the `ContactDB` class to point to your SQL Server instance.

```csharp
private string connectionString = "Server=YOUR_SERVER;Database=YOUR_DATABASE;Integrated Security=True;";
```

### 5. Run the Application
Press `F5` or click Start in Visual Studio to run the application.
The login page will appear first, where you can enter a phone number and proceed to the main page.

## Usage

### Adding a Contact

Go to Add Contacts from the Main Page.
Fill in the contact details (First Name, Last Name, Email, Phone Number, etc.).
Click Save to add the contact to the database.
The contact list will reload to reflect the new entry.

### Viewing Contacts

Go to View Contacts from the Main Page.
All contacts are displayed in a table.
Use the search bar to filter contacts by name, email, or phone number.

### Updating a Contact

Select a contact from the table in Add Contacts.
The selected contact’s details will populate the form fields.
Modify the contact information and click Update.
The contact list will reload to reflect the updated information.

### Deleting a Contact

Select a contact from the table in Add Contacts.
Click Delete.
Confirm the deletion when prompted.
The contact will be removed from the database.

## OOP Principles in the Project


-   **Encapsulation**: The `ContactDB` class encapsulates the logic for managing database operations, shielding the UI from direct database interactions.
-   **Abstraction**: The `AddContactsControl` and `ViewContactsControl` abstract the complexity of contact management, presenting a clean interface to the user.
-   **Inheritance**: The forms and controls inherit from `Form` and `UserControl`, leveraging the base functionality provided by .NET.
-   **Polymorphism**: The `LoadUserControl` method in `MainPage` loads different controls dynamically, treating them as generic `UserControl` objects while their specific behavior is determined by their individual implementations.
-   **Single Responsibility Principle (SRP)**: Each class in the project has a single responsibility, making the code easier to maintain and modify.

License
-------

This project is licensed under the MIT License - see the LICENSE file for details.
