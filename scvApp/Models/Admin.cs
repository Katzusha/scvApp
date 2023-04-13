namespace scvApp.Models
{
    public class Admin
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public string PhoneNumber { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool isMasterAdmin { get; set; }
        public int SchoolId { get; set; }
    }
}
