using AutoMapper;
using HospitalApi.DTOs;
using HospitalApi.Entities;

namespace HospitalApi.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Patient, PatientDto>()
                .ForMember(dest => dest.DistrictName, opt => opt.MapFrom(src => src.District.Number));

            CreateMap<Patient, PatientEditDto>().ReverseMap();
        }
    }
}
