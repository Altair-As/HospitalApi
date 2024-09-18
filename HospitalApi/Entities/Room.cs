namespace HospitalApi.Entities
{
    public class Room
    {
        public int Id { get; set; }
        public int Number { get; set; }

        public ICollection<Doctor> Doctors { get; set; } = new List<Doctor>();
    }
}
