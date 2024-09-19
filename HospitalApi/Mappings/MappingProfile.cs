using AutoMapper;
using HospitalApi.DTOs;
using HospitalApi.Entities;

namespace HospitalApi.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            // Mapping for Patient
            CreateMap<Patient, PatientDto>()
                .ForMember(dest => dest.DistrictNumber, opt => opt.MapFrom(src => src.District.Number));

            CreateMap<Patient, PatientEditDto>().ReverseMap();

            // Mapping for Doctor
            CreateMap<Doctor, DoctorDto>()
                .ForMember(dest => dest.RoomNumber, opt => opt.MapFrom(src => src.Room.Number))
                .ForMember(dest => dest.DistrictNumber, opt => opt.MapFrom(src => src.District.Number))
                .ForMember(dest => dest.SpecializationName, opt => opt.MapFrom(src => src.Specialization.Name));

            CreateMap<Doctor, DoctorEditDto>().ReverseMap();
        }
    }
}
