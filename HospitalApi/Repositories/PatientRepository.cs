using HospitalApi.Data;
using HospitalApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace HospitalApi.Repositories
{
    public class PatientRepository(AppDbContext context) : IPatientRepository
    {
        public async Task<IEnumerable<Patient>> GetAllAsync()
        {
            return await context.Patients
                .Include(p => p.District)
                .ToListAsync();
        }

        public async Task<Patient> GetByIdAsync(int id)
        {
            return await context.Patients.FindAsync(id)
                ?? throw new NullReferenceException("Patient not found");
        }

        public async Task AddAsync(Patient patient)
        {
            await context.Patients.AddAsync(patient);
            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Patient patient)
        {
            context.Update(patient);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var patient = await GetByIdAsync(id);
            context.Patients.Remove(patient);
            await context.SaveChangesAsync();
        }
    }
}
