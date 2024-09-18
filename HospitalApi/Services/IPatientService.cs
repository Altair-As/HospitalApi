using HospitalApi.DTOs;

namespace HospitalApi.Services
{
    public interface IPatientService
    {
        Task<IEnumerable<PatientDto>> GetPatientsAsync();
        Task<PatientEditDto> GetPatientByIdAsync(int id);
        Task AddPatientAsync(PatientEditDto patientDto);
        Task UpdatePatientAsync(PatientEditDto patientDto);
        Task DeletePatientAsync(int id);
    }
}
