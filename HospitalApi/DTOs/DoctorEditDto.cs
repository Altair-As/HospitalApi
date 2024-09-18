﻿using HospitalApi.Entities;

namespace HospitalApi.DTOs
{
    public class DoctorEditDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        public int RoomId { get; set; }

        public int SpecializationId { get; set; }

        public int? DistrictId { get; set; }
    }
}
