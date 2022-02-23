using LogInSystemApp.Data.Models.Services;
using LogInSystemApp.Data.ViewModels;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LogInSystemApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowAll")]
    public class DoctorController : ControllerBase
    {
        public DoctorService _doctorService;

        public DoctorController(DoctorService doctorsService)
        {
            _doctorService=doctorsService;

        }

        

        [HttpGet("get-all-doctors")]
        public IActionResult GetAllDoctors()
        {
            var allDoctors = _doctorService.GetAllDoctors();
            return Ok(allDoctors);
        }

        [HttpGet("get-doctors-by-id/{id}")]
        public IActionResult GetDoctorsById(int id)
        {
            var doctor = _doctorService.GetDoctorById(id);
            return Ok(doctor);
        }

        [HttpPost("add-doctor")]
        public IActionResult AddDoctor([FromBody] DoctorVM doctor)
        {
            _doctorService.AddDoctor(doctor);
            return Ok();

        }

        [HttpPut("update-doctor-by-id/{id}")]
        public IActionResult UpdateDoctorById(int id, [FromBody] DoctorVM doctor)
        {
            var updateDoctor = _doctorService.UpdateDoctorById(id, doctor);
            return Ok(updateDoctor);
        }


        [HttpDelete("delete-doctor-by-id/{id}")]
        public IActionResult DeleteDoctorById(int id)
        {
             _doctorService.DeleteDoctorById(id);
            return Ok();
            
        }




    }
}
