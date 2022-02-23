using LogInSystemApp.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace LogInSystemApp.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (!context.doctor.Any())
                {
                    context.doctor.AddRange(new Doctor()
                    {
                        Name = "Gersi",
                        Surname = "Mema",
                        PhoneNumber = 068580000,
                        Email = "gmema19@beder.edu.al",
                        RegistrationTime= DateTime.Now
                    });

                   
                }

                if (!context.patients.Any())
                {
                    context.patients.Add(new Patients()
                    {
                        Name = "Gersi",
                        Last_name = "Mema",
                        Gender = "M",
                        Symptoms = "Insomnia",
                        TimeAdded = DateTime.Now
                    });
                }
                context.SaveChanges();

            }
        }
    }
}
