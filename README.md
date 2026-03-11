# Final_Project
Training Management System
A Windows Forms desktop application built with C# .NET and Entity Framework Core (Code First) for managing training departments, instructors, students, courses, and session attendance.
about the Project
This system allows administrators to manage all aspects of a training center — departments, instructors, students, courses, course sessions, attendance records, and student enrollments — through a clean and consistent Windows Forms UI backed by a SQL Server database managed via Entity Framework Core Code First.

Final_Project has a project reference to db, so it can use all models and the AppDbContext directly.

Windows Forms Project (Final_Project)
This is the UI layer. It references the db project and uses AppDbContext directly to perform all database operations.
Each form follows a consistent pattern:

A dropdown at the top (comboSearch) to select an existing record → fills the left panel for editing or deletion
Left panel (blue): Edit / Delete the selected record
Right panel (peach): Add a new record
DataGridView at the bottom showing all records, refreshed after every operation

Features
Full CRUD operations on all 7 entities
Auto-increment Identity IDs — no manual ID entry required
Dropdown search to load existing records for editing or deleting
Required field checks
Numeric type validation (e.g. Duration, Grade 0–100)
Duplicate prevention (e.g. same student enrolled in same course twice)
Business rule checks (e.g. one manager per department)
Referential integrity — blocks deletion if related records exist
Confirmation dialogs before any delete
DataGridView refreshed live after every add / update / delete
HomeForm as a central navigation hub
