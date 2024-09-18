namespace HospitalApi.Entities
{
    public class Doctor
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        public int RoomId { get; set; }
        public Room Room { get; set; }

        public int SpecializationId { get; set; }
        public Specialization Specialization { get; set; }

        public int? DistrictId { get; set; }
        public District District { get; set; }
    }
}
