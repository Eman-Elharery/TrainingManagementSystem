namespace db
{
    public class Instructor
    {
        public int Id { get; set; }

        public int DepartmentId { get; set; }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Phone { get; set; }

        public Department Department { get; set; }

        public Department ManagedDepartment { get; set; }

        public ICollection<Course> Courses { get; set; }
        public ICollection<CourseSession> CourseSessions { get; set; }
    }
}