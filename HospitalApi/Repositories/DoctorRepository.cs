using HospitalApi.Data;
using HospitalApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace HospitalApi.Repositories
{
    public class DoctorRepository(AppDbContext context) : IDoctorRepository
    {
        public async Task<IEnumerable<Doctor>> GetAllAsync()
        {
            return await context.Doctors
                .Include(d => d.Room)
                .Include(d => d.District)
                .Include(d => d.Specialization)
                .ToListAsync();
        }

        public async Task<Doctor> GetByIdAsync(int id)
        {
            return await context.Doctors.FindAsync(id) 
                ?? throw new NullReferenceException("Doctor not found");
        }

        public async Task AddAsync(Doctor doctor)
        {
            await context.AddAsync(doctor);
            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Doctor doctor)
        {
            context.Update(doctor);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var patient = await GetByIdAsync(id);
            context.Remove(patient);
            await context.SaveChangesAsync();
        }
    }
}
