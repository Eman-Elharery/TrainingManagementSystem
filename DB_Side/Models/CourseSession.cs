namespace db
{
    public class CourseSession
    {
        public int Id { get; set; }

        public int CourseId { get; set; }
        public int InstructorId { get; set; }

        public DateTime Date { get; set; }
        public string? Title { get; set; }

        public Course Course { get; set; }
        public Instructor Instructor { get; set; }

        public ICollection<CourseSessionAttendance> Attendances { get; set; }
    }
}