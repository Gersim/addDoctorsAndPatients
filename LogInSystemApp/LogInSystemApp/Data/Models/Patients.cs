using System;

namespace LogInSystemApp.Data.Models
{
    public class Patients
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Last_name { get; set; }
        public string Gender { get; set; }
        public string Symptoms { get; set; }
        public DateTime TimeAdded { get; set; }
    }
}
