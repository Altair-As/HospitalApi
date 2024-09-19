using HospitalApi.DTOs;

namespace HospitalApi.Services
{
    public interface IDoctorService
    {
        Task<IEnumerable<DoctorDto>> GetDoctorsAsync();
        Task<DoctorEditDto> GetDoctorByIdAsync(int id);
        Task AddDoctorAsync(DoctorEditDto doctorDto);
        Task UpdateDoctorAsync(int id, DoctorEditDto doctorDto);
        Task DeleteDoctorAsync(int id);
    }
}
