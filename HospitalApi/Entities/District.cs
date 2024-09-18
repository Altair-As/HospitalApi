namespace HospitalApi.Entities
{
    public class District
    {
        public int Id { get; set; }
        public int Number { get; set; }

        public ICollection<Patient> Patients { get; set; } = new List<Patient>();
        public ICollection<Doctor> Doctors { get; set; } = new List<Doctor>();
    }
}
