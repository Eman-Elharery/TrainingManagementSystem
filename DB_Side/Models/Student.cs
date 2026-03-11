namespace db
{
    public class Student
    {
        public int Id { get; set; }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Phone { get; set; }

        public ICollection<CourseStudent> CourseStudents { get; set; }
        public ICollection<CourseSessionAttendance> Attendances { get; set; }
    }
}