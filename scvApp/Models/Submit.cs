namespace scvApp.Models
{
    public class Submit
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int NumberOfStudents { get; set; }
        public string Class { get; set; }
        public string SchoolTitle { get; set; }
        public string Address { get; set; }
        public int Date { get; set; }
        public TimeOnly Start { get; set; }
        public TimeOnly Break { get; set; }
        public TimeOnly End { get; set; }
        public string Type { get; set; }
        public string Note { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool isConfirmed { get; set; }
    }
}
