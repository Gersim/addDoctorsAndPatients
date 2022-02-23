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
    public class PatientController : ControllerBase
    {
        public PatientServices _patientService;

        public PatientController(PatientServices pateientService)
        {
            _patientService = pateientService;

        }


        [HttpGet("get-all-patients")]
        public IActionResult GetAllPatients()
        {
            var allPatients = _patientService.GetAllPatients();
            return Ok(allPatients);
        }

        [HttpGet("get-patient-by-id/{id}")]
        public IActionResult GetPatientById(int id)
        {
            var thPatient = _patientService.GetPatientById(id);
            return Ok(thPatient);
        }

        [HttpPost("add-patient")]
        public IActionResult AddPatient([FromBody]PatientVM  patient)
        {
            _patientService.AddPatient(patient);
            return Ok();

        }


        [HttpPut("update-patient-by-id/{id}")]
        public IActionResult UpdatePatietnById(int id, [FromBody] PatientVM patient)
        {
            var updatePatient = _patientService.UpdatePatientById(id, patient);
            return Ok(updatePatient);
        }


        [HttpDelete("delete-patient-by-id/{id}")]
        public IActionResult DeletePatientById(int id)
        {
            _patientService.DeletePatientById(id);
            return Ok();

        }
    }
}