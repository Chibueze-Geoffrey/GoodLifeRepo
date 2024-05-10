using AutoMapper;

namespace GoodLifeHospital.Profiles
{
    public class PatientProfile : Profile
    {
        public PatientProfile()
        {
            CreateMap<Entities.Patient, Dtos.PatientDto>();
            CreateMap<Dtos.PatientCreated, Entities.Patient>();
            CreateMap<Entities.Doctor, Dtos.PatientDto>();
            CreateMap<Dtos.PatientCreated, Entities.Patient>();
            //CreateMap<Dtos.PizzaUpdatedDto, Entities.Pizza>();
            //CreateMap<Entities.Pizza, Dtos.PizzaUpdatedDto>();
        }
    }
}
