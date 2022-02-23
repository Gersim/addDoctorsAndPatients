using LogInSystemApp.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LogInSystemApp.Data.Models.Services
{
    public class PatientServices
    {
        private AppDbContext _context;
        public PatientServices(AppDbContext context)
        {
            _context = context;
        }
        public void AddPatient(PatientVM patient)
        {
            var _patient = new Patients()
            {
                Name = patient.Name,
                Last_name = patient.Last_name,
                Gender = patient.Gender,
                Symptoms = patient.Symptoms,
                TimeAdded =  DateTime.Now
            };
            _context.patients.Add(_patient);
            _context.SaveChanges();
        }

        public List<Patients> GetAllPatients()
        {
            return _context.patients.ToList();

        }

        public Patients GetPatientById(int patientId)
        {
            return _context.patients.FirstOrDefault(n => n.Id == patientId);

        }

        public Patients UpdatePatientById(int patientId,PatientVM patient)
        {
            var _patient = _context.patients.FirstOrDefault(n => n.Id == patientId);
            if (_patient == null)
            {
                _patient.Name = patient.Name;
                _patient.Last_name = patient.Last_name;
                _patient.Gender = patient.Gender;
                _patient.Symptoms = _patient.Symptoms;

                _context.SaveChanges();
            }

            return _patient;
        }


        public void DeletePatientById(int patientId)
        {
            var _patient = _context.patients.FirstOrDefault(n => n.Id == patientId);
            if (_patient != null)
            {
                _context.patients.Remove(_patient);
                _context.SaveChanges();
            }
        }
    }
}