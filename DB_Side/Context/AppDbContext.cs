using Microsoft.EntityFrameworkCore;

namespace db
{

    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
            "Server=DESKTOP-M7BTVHC\\SQLEXPRESS;Database=Final_Project_EF;Trusted_Connection=True;TrustServerCertificate=True");
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<CourseSession> CourseSessions { get; set; }
        public DbSet<CourseStudent> CourseStudents { get; set; }
        public DbSet<CourseSessionAttendance> CourseSessionAttendances { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<CourseStudent>()
                .HasKey(cs => new { cs.CourseId, cs.StudentId });

            modelBuilder.Entity<CourseStudent>()
                .HasOne(cs => cs.Course)
                .WithMany(c => c.CourseStudents)
                .HasForeignKey(cs => cs.CourseId);

            modelBuilder.Entity<CourseStudent>()
                .HasOne(cs => cs.Student)
                .WithMany(s => s.CourseStudents)
                .HasForeignKey(cs => cs.StudentId);



            modelBuilder.Entity<Instructor>()
                .HasOne(i => i.Department)
                .WithMany(d => d.Instructors)
                .HasForeignKey(i => i.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);



            modelBuilder.Entity<Department>()
                .HasOne(d => d.Manager)
                .WithOne(i => i.ManagedDepartment)
                .HasForeignKey<Department>(d => d.ManagerId)
                .OnDelete(DeleteBehavior.Restrict);



            modelBuilder.Entity<Course>()
                .HasOne(c => c.Department)
                .WithMany(d => d.Courses)
                .HasForeignKey(c => c.DepartmentId);



            modelBuilder.Entity<Course>()
                .HasOne(c => c.Instructor)
                .WithMany(i => i.Courses)
                .HasForeignKey(c => c.InstructorId);



            modelBuilder.Entity<CourseSession>()
                .HasOne(cs => cs.Course)
                .WithMany(c => c.Sessions)
                .HasForeignKey(cs => cs.CourseId);



            modelBuilder.Entity<CourseSession>()
                .HasOne(cs => cs.Instructor)
                .WithMany(i => i.CourseSessions)
                .HasForeignKey(cs => cs.InstructorId)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<CourseSessionAttendance>()
                .HasOne(a => a.CourseSession)
                .WithMany(cs => cs.Attendances)
                .HasForeignKey(a => a.CourseSessionId);

            modelBuilder.Entity<CourseSessionAttendance>()
                .HasOne(a => a.Student)
                .WithMany(s => s.Attendances)
                .HasForeignKey(a => a.StudentId);



            
            modelBuilder.Entity<Instructor>().HasData(

                new Instructor { Id = 1, DepartmentId = 1, FirstName = "Ahmed", LastName = "Ali", Phone = "010111111" },
                new Instructor { Id = 2, DepartmentId = 2, FirstName = "Sara", LastName = "Mohamed", Phone = "010222222" },
                new Instructor { Id = 3, DepartmentId = 3, FirstName = "Omar", LastName = "Hassan", Phone = "010333333" },
                new Instructor { Id = 4, DepartmentId = 1, FirstName = "Mona", LastName = "Adel", Phone = "010444444" }

            );


            
            modelBuilder.Entity<Department>().HasData(

                new Department { Id = 1, Name = "Computer Science", Location = "Building A"},
                new Department { Id = 2, Name = "Information Systems", Location = "Building B" },
                new Department { Id = 3, Name = "Software Engineering", Location = "Building C" }

            );


            
            modelBuilder.Entity<Course>().HasData(

                new Course { Id = 1, Name = "Programming 1", Duration = 30, DepartmentId = 1, InstructorId = 1 },
                new Course { Id = 2, Name = "Data Structures", Duration = 40, DepartmentId = 1, InstructorId = 4 },
                new Course { Id = 3, Name = "Database", Duration = 35, DepartmentId = 2, InstructorId = 2 },
                new Course { Id = 4, Name = "Software Testing", Duration = 25, DepartmentId = 3, InstructorId = 3 }

            );


            
            modelBuilder.Entity<Student>().HasData(

                new Student { Id = 1, FirstName = "Ali", LastName = "Mahmoud", Phone = "011111111" },
                new Student { Id = 2, FirstName = "Nour", LastName = "Samy", Phone = "011222222" },
                new Student { Id = 3, FirstName = "Youssef", LastName = "Khaled", Phone = "011333333" },
                new Student { Id = 4, FirstName = "Huda", LastName = "Adel", Phone = "011444444" },
                new Student { Id = 5, FirstName = "Karim", LastName = "Fathy", Phone = "011555555" }

            );


            
            modelBuilder.Entity<CourseStudent>().HasData(

                new CourseStudent { CourseId = 1, StudentId = 1 },
                new CourseStudent { CourseId = 1, StudentId = 2 },
                new CourseStudent { CourseId = 2, StudentId = 3 },
                new CourseStudent { CourseId = 3, StudentId = 4 },
                new CourseStudent { CourseId = 4, StudentId = 5 }

            );


            
            modelBuilder.Entity<CourseSession>().HasData(

                new CourseSession { Id = 1, CourseId = 1, InstructorId = 1, Date = new DateTime(2025, 1, 1), Title = "Intro to Programming" },
                new CourseSession { Id = 2, CourseId = 2, InstructorId = 4, Date = new DateTime(2025, 1, 5), Title = "Linked Lists" },
                new CourseSession { Id = 3, CourseId = 3, InstructorId = 2, Date = new DateTime(2025, 1, 10), Title = "SQL Basics" }

            );


           
            modelBuilder.Entity<CourseSessionAttendance>().HasData(

                new CourseSessionAttendance { Id = 1, CourseSessionId = 1, StudentId = 1, Grade = 90, Notes = "Excellent" },
                new CourseSessionAttendance { Id = 2, CourseSessionId = 1, StudentId = 2, Grade = 80, Notes = "Good" },
                new CourseSessionAttendance { Id = 3, CourseSessionId = 2, StudentId = 3, Grade = 85, Notes = "Very Good" },
                new CourseSessionAttendance { Id = 4, CourseSessionId = 3, StudentId = 4, Grade = 70, Notes = "Needs improvement" }

            );

            
           
        }
    }
}