using HospitalApi.DTOs;
using HospitalApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace HospitalApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DoctorController(IDoctorService doctorService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetDoctors()
        {
            var doctors = await doctorService.GetDoctorsAsync();
            return Ok(doctors);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDoctorById(int id)
        {
            var doctor = await doctorService.GetDoctorByIdAsync(id);

            if (doctor == null)
                return NotFound();

            return Ok(doctor);
        }

        [HttpPost]
        public async Task<IActionResult> AddDoctor([FromBody] DoctorEditDto doctorDto)
        {
            await doctorService.AddDoctorAsync(doctorDto);
            return CreatedAtAction(nameof(AddDoctor), doctorDto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditDoctor(int id, [FromBody] DoctorEditDto doctorDto)
        {
            await doctorService.UpdateDoctorAsync(id, doctorDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDoctor(int id)
        {
            await doctorService.DeleteDoctorAsync(id);
            return NoContent();
        }
    }
}
