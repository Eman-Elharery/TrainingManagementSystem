namespace db
{
    public class Department
    {
        public int Id { get; set; }

        public int? ManagerId { get; set; }

        public string Name { get; set; }
        public string? Location { get; set; }

        public Instructor Manager { get; set; }

        public ICollection<Course> Courses { get; set; }
        public ICollection<Instructor> Instructors { get; set; }
    }
}