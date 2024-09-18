using HospitalApi.DTOs;

namespace HospitalApi.Services
{
    public interface IPatientService
    {
        Task<IEnumerable<PatientDto>> GetPatientsAsync();
        Task<PatientEditDto> GetPatientByIdAsync(int id);
        Task AddPatientAsync(PatientEditDto patient);
        Task UpdatePatientAsync(PatientEditDto patient);
        Task DeletePatientAsync(int id);
    }
}
