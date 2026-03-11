# Training Management System

A Windows Forms desktop application built with **C# .NET** and **Entity Framework Core (Code First)** for managing training departments, instructors, students, courses, and session attendance.

---

## Table of Contents

- [About the Project](#about-the-project)
- [Solution Structure](#solution-structure)
- [Database Project](#database-project-db)
- [Windows Forms Project](#windows-forms-project-final_project)
- [Database Schema](#database-schema)
- [Features](#features)
- [Technologies Used](#technologies-used)
- [Getting Started](#getting-started)
- [Forms Overview](#forms-overview)

---

## About the Project

This system allows administrators to manage all aspects of a training center — departments, instructors, students, courses, course sessions, attendance records, and student enrollments — through a clean and consistent Windows Forms UI backed by a SQL Server database managed via Entity Framework Core Code First.

---

## Solution Structure

The solution contains **two projects**:

```
TrainingManagementSystem.sln
|
|-- db/                            
|   |-- Models/
|   |   |-- Department.cs
|   |   |-- Instructor.cs
|   |   |-- Student.cs
|   |   |-- Course.cs
|   |   |-- CourseSession.cs
|   |   |-- CourseSessionAttendance.cs
|   |   `-- CourseStudent.cs
|   |-- AppDbContext.cs
|   `-- Migrations/
|
`-- Final_Project/               
    |-- Forms/
    |   |-- HomeForm.cs / .Designer.cs
    |   |-- DepartmentForm.cs / .Designer.cs
    |   |-- InstructorForm.cs / .Designer.cs
    |   |-- StudentForm.cs / .Designer.cs
    |   |-- CourseForm.cs / .Designer.cs
    |   |-- CourseSessionForm.cs / .Designer.cs
    |   |-- CourseSessionAttendanceForm.cs / .Designer.cs
    |   `-- CourseStudentForm.cs / .Designer.cs
    `-- Program.cs
```

> `Final_Project` has a **project reference** to `db`, so it can use all models and `AppDbContext` directly.

---

## Database Project (db)

This is a **Class Library** that contains everything related to the database layer.

### Models

| Model | Description |
| --- | --- |
| `Department` | Department with a name, location, and optional manager (an Instructor) |
| `Instructor` | Instructor with first/last name, phone, and a department |
| `Student` | Student with first/last name and phone |
| `Course` | Course with name, duration, linked to a department and instructor |
| `CourseSession` | A session of a course on a specific date with an instructor |
| `CourseSessionAttendance` | Attendance record linking a student to a session, with grade and notes |
| `CourseStudent` | Junction table for many-to-many enrollment between courses and students |

### AppDbContext

`AppDbContext` inherits from `DbContext` and exposes:

```csharp
public DbSet<Department> Departments { get; set; }
public DbSet<Instructor> Instructors { get; set; }
public DbSet<Student> Students { get; set; }
public DbSet<Course> Courses { get; set; }
public DbSet<CourseSession> CourseSessions { get; set; }
public DbSet<CourseSessionAttendance> CourseSessionAttendances { get; set; }
public DbSet<CourseStudent> CourseStudents { get; set; }
```

All IDs are configured as **Identity (auto-increment)** — the database generates them automatically.

---

## Windows Forms Project (Final_Project)

This is the **UI layer**. It references the `db` project and uses `AppDbContext` directly to perform all database operations.

Each form follows a consistent pattern:

- A **dropdown at the top** to select an existing record, which fills the left panel for editing or deletion
- **Left panel** (blue): Edit or Delete the selected record
- **Right panel** (peach): Add a new record
- **DataGridView** at the bottom showing all records, refreshed after every operation
---

## Features

- Full **CRUD operations** on all 7 entities
- **Auto-increment Identity** IDs — no manual ID entry required
- **Dropdown search** to load existing records for editing or deleting
- **Validation** on every form:
  - Required field checks
  - Numeric type validation (e.g. Duration, Grade must be 0-100)
  - Duplicate prevention (e.g. same student enrolled in same course twice)
  - Business rule checks (e.g. one manager per department)
  - Referential integrity checks — blocks deletion if related records exist
- **Confirmation dialogs** before any delete operation
- **DataGridView** refreshed live after every add, update, or delete
- **HomeForm** as a central navigation hub to all screens

---

## Technologies Used

| Technology | Usage |
| --- | --- |
| C# (.NET 8) | Application language |
| Windows Forms | Desktop UI framework |
| Entity Framework Core | ORM with Code First approach |
| SQL Server / LocalDB | Database engine |
| LINQ | Querying the database |
| Visual Studio 2026 | IDE |
