namespace db
{
    public class Course
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public int InstructorId { get; set; }

        public int? Duration { get; set; }
        public string? Name { get; set; }

        public Department Department { get; set; }
        public Instructor Instructor { get; set; }

        public ICollection<CourseSession> Sessions { get; set; }
        public ICollection<CourseStudent> CourseStudents { get; set; }
    }
}