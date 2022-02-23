using LogInSystemApp.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LogInSystemApp.Data.Models.Services
{
    public class DoctorService
    {
        private AppDbContext _context;
        public DoctorService(AppDbContext context)
        {
            _context = context;
        }
        public void AddDoctor(DoctorVM doctor)
        {
            var _doctor = new Doctor()
            {
                Name = doctor.Name,
                Surname = doctor.Surname,
                PhoneNumber = doctor.PhoneNumber,
                Email = doctor.Email,
                RegistrationTime = DateTime.Now
            };
            _context.doctor.Add(_doctor);
            _context.SaveChanges();
        }

        public List<Doctor> GetAllDoctors()
        {
             return  _context.doctor.ToList();
            
        }

        public Doctor GetDoctorById(int doctorId)
        {
            return  _context.doctor.FirstOrDefault(n=>n.Id == doctorId);

        }

        public Doctor UpdateDoctorById(int doctorId,DoctorVM doctor)
        {
            var _doctor = _context.doctor.FirstOrDefault( n => n.Id == doctorId);
            if(_doctor == null)
            {
                _doctor.Name = doctor.Name;
                _doctor.Surname = doctor.Surname;
                _doctor.PhoneNumber = doctor.PhoneNumber;
                _doctor.Email = doctor.Email;

                _context.SaveChanges();
            }

            return _doctor;
        }


        public void DeleteDoctorById(int doctorId)
        {
            var _doctor = _context.doctor.FirstOrDefault(n => n.Id == doctorId);
            if(_doctor != null)
            {
                _context.doctor.Remove(_doctor);
                _context.SaveChanges();
            }
        }
    }
}
