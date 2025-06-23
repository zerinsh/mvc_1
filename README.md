# 🎓 Student Management System

A web-based Student Management System built with **ASP.NET Core MVC**, **Entity Framework Core**, and **ASP.NET Identity**. This application allows administrators to manage student information, authentication, and authorization in a secure and scalable way.

---

## 🛠️ Tech Stack

* **Backend:** ASP.NET Core 7.0 (MVC)
* **ORM:** Entity Framework Core
* **Authentication:** ASP.NET Core Identity
* **Database:** SQL Server
* **Frontend:** Razor Views (HTML, CSS, Bootstrap)
* **IDE:** Visual Studio / Visual Studio Code

---

## 📌 Features

* 🔐 User Registration & Login with Identity
* 🧑‍🏫 Add, Edit, Delete, and View Student Records
* 🔎 Search and Filter Students
* 📋 Role-Based Access Control (Admin/User)
* ⚙️ Clean architecture with separation of concerns

---

## 📂 Project Structure

```
/mvc_1
🗁️ Controllers/
│   ├️ HomeController.cs
│   └️ StudentController.cs
🗁️ Models/
│   ├️ AppUser.cs
│   └️ Student.cs
🗁️ Views/
│   ├️ Home/
│   └️ Student/
🗁️ Data/
│   └️ ApplicationDbContext.cs
🗁️ wwwroot/
🔍 appsettings.json
🔍 Program.cs
```

---

## 🚀 Getting Started

### 1. Clone the repository

```bash
git clone https://github.com/yourusername/student-management-system.git
cd student-management-system
```

### 2. Setup SQL Server Connection

Update your `appsettings.json` with your SQL Server connection string:

```json
"ConnectionStrings": {
  "StudentPortal": "Server=.;Database=StudentPortalDB;Trusted_Connection=True;"
}
```

### 3. Apply Migrations

```bash
dotnet ef database update
```

### 4. Run the Application

```bash
dotnet run --launch-profile "https"
```

Open in browser:
📍 `https://localhost:7024`

---

## 📸 Screenshots

> *(Optional – Add screenshots of your dashboard or pages here)*

---

## 🤝 Contributions

Contributions, issues, and feature requests are welcome!

Feel free to fork this repository and submit a pull request.

---

## 📄 License

This project is licensed under the MIT License.

---

## 🤛🏼 Author

 [@zerinsh](https://github.com/zerinsh)
