﻿using HospitalApi.Entities;

namespace HospitalApi.DTOs
{
    public class DoctorDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        public int RoomNumber { get; set; }

        public string SpecializationName { get; set; }

        public int? DistrictNumber { get; set; }
    }
}
