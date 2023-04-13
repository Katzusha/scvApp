namespace scvApp.Models
{
    public class Date
    {
        public int Id { get; set; }
        public DateOnly Term { get; set; }
        public TimeOnly Start { get; set; }
        public int MaxNumberOfStudents { get; set; }
    }
}
