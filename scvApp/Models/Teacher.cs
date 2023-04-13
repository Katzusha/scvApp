namespace scvApp.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public string PhonrNumber { get; set; }
        public bool isGuide { get; set; }
    }
}
