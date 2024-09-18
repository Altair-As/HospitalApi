using AutoMapper;
using HospitalApi.DTOs;
using HospitalApi.Entities;
using HospitalApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HospitalApi.Services
{
    public class PatientService(IMapper mapper, IPatientRepository patientRepository) : IPatientService
    {
        public async Task<IEnumerable<PatientDto>> GetPatientsAsync()
        {
            var patients = await patientRepository.GetAllAsync();
            return mapper.Map<IEnumerable<PatientDto>>(patients);
        }

        public async Task<PatientEditDto> GetPatientByIdAsync(int id)
        {
            var patient = await patientRepository.GetByIdAsync(id);
            return mapper.Map<PatientEditDto>(patient);
        }

        public async Task AddPatientAsync(PatientEditDto patientDto)
        {
            var patient = mapper.Map<Patient>(patientDto);
            await patientRepository.AddAsync(patient);
        }

        public async Task UpdatePatientAsync(PatientEditDto patientDto)
        {
            var patient = mapper.Map<Patient>(patientDto);
            await patientRepository.UpdateAsync(patient);
        }

        public async Task DeletePatientAsync(int id)
        {
            await patientRepository.DeleteAsync(id);
        }
    }
}
