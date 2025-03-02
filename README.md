# Employee Management System

## Overview
This is an ASP.NET Core MVC-based Employee Management System that allows users to perform CRUD operations (Create, Read, Update, Delete) on employee records.

## Features
- Add new employees
- Edit employee details
- Delete employees with confirmation
- View a list of employees
- Validation for form inputs

---

## 🛠️ Setup Instructions

### 1️⃣ Prerequisites
Ensure you have the following installed:
- [.NET SDK](https://dotnet.microsoft.com/en-us/download/dotnet)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) or [LocalDB](https://docs.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb)
- [Visual Studio](https://visualstudio.microsoft.com/) with ASP.NET and Entity Framework Core
- [Git](https://git-scm.com/) and [SourceTree](https://www.sourcetreeapp.com/) (optional)

---

### 2️⃣ Clone the Repository
Open a terminal or SourceTree and run:
```sh
git clone https://github.com/yourusername/your-repo.git
cd your-repo
```

---

### 3️⃣ Configure the Database
#### Modify `appsettings.json`
Update the connection string inside `appsettings.json`:
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Database=EmployeeDB;Trusted_Connection=True;"
}
```
Replace `YOUR_SERVER` with your actual SQL Server instance.

#### Run Migrations & Update Database
Run the following commands in the terminal:
```sh
dotnet ef migrations add InitialCreate
dotnet ef database update
```

---

### 4️⃣ Run the Application
Use the terminal or Visual Studio to start the application:
```sh
dotnet run
```
Or, in **Visual Studio**:
- Open the solution file (`.sln`)
- Press **F5** to run the application

---

### 5️⃣ Test CRUD Operations
1. Open a browser and go to `http://localhost:5000/Employees`
2. Add a new employee
3. Edit employee details
4. Delete an employee (with confirmation)
5. Verify validation works

---

## 📌 Deployment
To deploy this project:
1. Publish the project in Visual Studio (`Publish` option)
2. Deploy to **IIS**, **Azure**, or a **Linux Server**

---

## 🤝 Contributing
1. Fork the repository
2. Create a feature branch: `git checkout -b feature-name`
3. Commit changes: `git commit -m "Your message"`
4. Push to GitHub: `git push origin feature-name`
5. Submit a Pull Request (PR)

---


