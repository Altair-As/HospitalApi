using HospitalApi.DTOs;
using HospitalApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace HospitalApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PatientController(IPatientService patientService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetPatients()
        {
            var patients = await patientService.GetPatientsAsync();
            return Ok(patients);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPatientById(int id)
        {
            var patient = await patientService.GetPatientByIdAsync(id);

            if (patient == null) 
                return NotFound();

            return Ok(patient);
        }

        [HttpPost]
        public async Task<IActionResult> AddPatient([FromBody] PatientEditDto patientDto)
        {
            await patientService.AddPatientAsync(patientDto);
            return CreatedAtAction(nameof(AddPatient), patientDto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditPatient(int id, [FromBody] PatientEditDto patientDto)
        {
            await patientService.UpdatePatientAsync(id, patientDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePatient(int id)
        {
            await patientService.DeletePatientAsync(id);
            return NoContent();
        }
    }
}
