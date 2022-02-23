using System;

namespace LogInSystemApp.Data.ViewModels
{
    public class DoctorVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationTime { get; set; }
    }
}
