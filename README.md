
# Expense Tracker

## Project Overview

The **Expense Tracker** is a web application built using ASP.NET MVC that allows users to manage their finances efficiently. The app enables users to create income and expense categories, add transactions, and view their total income, total expenses, and overall balance on the homepage.

## Features

- **User Authentication**: Users can securely sign up, log in, and manage their own financial data.
- **Category Management**: Users can create categories of either "Income" or "Expense" type.
- **Transaction Management**: Users can select a category and log a transaction for it (either an income or an expense).
- **Dashboard**: The homepage displays:
  - Total Income
  - Total Expenses
  - Total Balance (Income - Expenses)

## Technologies Used
- **ASP.NET Core MVC**: For the core application framework.
- **Entity Framework Core**: For database interactions.
- **SQL Server**: The database used for storing user data, categories, and transactions.
- **Authentication**: For signin signup and logout

## Setup Instructions

### Prerequisites
- **.NET Core SDK**
- **SQL Server**
- **Visual Studio**

## Getting Started

Follow these instructions to get a copy of the project up and running on your local machine.

### Clone the Repository

```bash
git clone https://github.com/NiihaarrX/Expense-Tracker.git
cd Expense Tracker
```

### Setup the Database

- Open SQL Server Management Studio (SSMS).
- Create a new database called TransactionDb.
- Update the connection string in appsettings.json to match your SQL Server instance:

```bash
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Database=TransactionDb;Trusted_Connection=True;MultipleActiveResultSets=true"
}
```

- Open the terminal in Visual Studio and run the following command to apply the migrations:

```bash
dotnet ef database update
```

### Running the Application

- Run following command in terminal:

```bash
dotnet run
```
- It will run on [http://localhost:5026](http://localhost:5026)

## Usage

### For Users:
- **Sign Up**: Register a new account.
- **Login**: Log in to access the dashboard.
- **Create Categories**: Add categories for income or expense.
- **Add Transactions**: Log transactions by selecting a category and entering the transaction details.
- **Dashboard**: View the total income, total expenses, and your current balance.

## Project Structure

### Controllers:
- **CategoryController**: Manages CRUD operations for income/expense categories.
- **TransactionController**: Handles the logic for adding and managing transactions.
- **UserController**: Manages user authentication (login, signup, etc.).
- **DashboardController**: Displays the total income, expense, and balance on the homepage.

### Views:
- **Category**: Pages for creating and managing categories.
- **Transaction**: Pages for adding and listing transactions.
- **Dashboard**: The homepage showing the overall financial summary.

## Future Enhancements
- Add **graphical representation** of income and expenses (pie charts, bar charts).
- Add **date filters** for transactions (daily, weekly, monthly).
