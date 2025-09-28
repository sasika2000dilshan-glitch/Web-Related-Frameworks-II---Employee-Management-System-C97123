1. Employee Management System
A simple CRUD application for managing employees, built with ASP.NET Core Web API backend and Angular frontend.

2. Features
Add new employees
View all employees
Edit employee details
Delete employees
Responsive Material Design

3. Technology Stack
Backend: ASP.NET Core Web API, Entity Framework, SQL Server
Frontend: Angular, Angular Material, TypeScript

4. Quick Setup
Backend (API)
	Open EmployeeManagementAPI in Visual Studio
	Update database connection in appsettings.json
	Run these commands in Package Manager Console.
	Run the API (F5) - will open at https://localhost:7183


Frontend (Angular)
	Open terminal in EmployeeManagementUI folder
	Install dependencies - npm install
	Start the application - ng serve
	Open http://localhost:4200 in browser

5. API Endpoints
GET /api/employees - Get all employees
GET /api/employees/{id} - Get employee by ID
POST /api/employees - Create new employee
PUT /api/employees/{id} - Update employee
DELETE /api/employees/{id} - Delete employee

6. Employee Model

public class Employee {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Position { get; set; }
    public string Department { get; set; }
    public decimal Salary { get; set; }
}



7. Usage

	Click "Add Employee" to create new employees
	Click "Edit" to modify employee details
	Click "Delete" to remove employees
	All data is saved in SQL Server database
