Follow these instructions to set up and run the project on your local machine.
1:Clone this repository to your local machine:
2:Open the solution file CurdOperationWithDapper.sln in Visual Studio.
3:Build the solution to restore the necessary packages.

Database Setup:
Before running the project, you need to set up the database. Follow these steps:
1:Open SQL Server Management Studio (SSMS) or any preferred SQL client.
2:Run the SQL script DatabaseScript.sql located in the Database folder of the project to create the database schema and sample data.

Configuration:
Update the connection string in the appsettings.json file with your SQL Server connection details:
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=YourServer;Database=YourDatabase;User Id=YourUsername;Password=YourPassword;"
  }
}

Running the Application:
Once the prerequisites are met and the database is set up, you can run the application:
1: Press F5 or click on the Start button in Visual Studio to run the application.
2: The application should launch in your default web browser.

Usage:
Navigate to the different CRUD operations using the provided links on the web application.
Perform CRUD operations (Create, Read, Update, Delete) on the products.
