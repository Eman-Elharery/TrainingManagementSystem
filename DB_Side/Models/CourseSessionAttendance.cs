namespace db
{
    public class CourseSessionAttendance
    {
        public int Id { get; set; }

        public int CourseSessionId { get; set; }
        public int StudentId { get; set; }

        public int? Grade { get; set; }
        public string? Notes { get; set; }

        public CourseSession CourseSession { get; set; }
        public Student Student { get; set; }
    }
}