using System;

namespace LogInSystemApp.Data.ViewModels
{
    public class PatientVM
    {
         public int Id { get; set; }
        public string Name { get; set; }
        public string Last_name { get; set; }
        public string Gender { get; set; }
        public string Symptoms { get; set; }
        public DateTime TimeAdded { get; set; }
    }
}
