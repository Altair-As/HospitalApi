using AutoMapper;
using HospitalApi.DTOs;
using HospitalApi.Entities;
using HospitalApi.Repositories;
using System.Numerics;

namespace HospitalApi.Services
{
    public class DoctorService(IDoctorRepository doctorRepository, IMapper mapper) : IDoctorService
    {
        public async Task<IEnumerable<DoctorDto>> GetDoctorsAsync()
        {
            var doctors = await doctorRepository.GetAllAsync();
            return mapper.Map<IEnumerable<DoctorDto>>(doctors);
        }

        public async Task<DoctorEditDto> GetDoctorByIdAsync(int id)
        {
            var doctor = await doctorRepository.GetByIdAsync(id);
            return mapper.Map<DoctorEditDto>(doctor);
        }

        public async Task AddDoctorAsync(DoctorEditDto doctorDto)
        {
            var doctor = mapper.Map<Doctor>(doctorDto);
            await doctorRepository.AddAsync(doctor);
        }

        public async Task UpdateDoctorAsync(int id, DoctorEditDto doctorDto)
        {
            var doctor = await doctorRepository.GetByIdAsync(id);
            mapper.Map(doctorDto, doctor);
            await doctorRepository.UpdateAsync(doctor);
        }

        public async Task DeleteDoctorAsync(int id)
        {
            await doctorRepository.DeleteAsync(id);
        }
    }
}
