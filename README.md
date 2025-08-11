# StudentManagementSystem_assignmet

# 🎓 Student Management System – ASP.NET Core MVC

A simple Student Management System built with ASP.NET Core MVC and Entity Framework Core. This project demonstrates basic CRUD operations, LINQ queries, and integration with a SQL Server relational database.

---

## 🛠️ Technologies Used

- ASP.NET Core MVC (.NET 8)
- Entity Framework Core
- SQL Server
- C# LINQ
- Bootstrap (for basic UI styling)

---

## 📦 Features

- ✅ Add new students
- 🔍 Search students by name (LINQ)
- 📊 Display students older than 18 (LINQ filter)
- 🔢 Show total student count (LINQ `Count()`)

---

## 🗃️ Database Schema

The system uses a single `Student` table with the following fields:

| Field Name  | Type     | Description                     |
|-------------|----------|---------------------------------|
| Id          | int      | Primary Key, Auto-increment     |
| FirstName   | string   | Student's first name            |
| LastName    | string   | Student's last name             |
| Email       | string   | Student's email address         |
| Age         | int      | Student's age                   |

---

## 🚀 Getting Started

### 1. Clone the Repository

```bash
[git clone https://github.com/your-username/StudentManagementSystem.git](https://github.com/basithalam/StudentManagementSystem_assignmet.git)
cd StudentManagementSystem_assignmet
