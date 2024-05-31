using AutoMapper;
using DesafioATS.Application.DTOs;
using DesafioATS.Domain.Entities;

namespace DesafioATS.Application.Profiles
{
    public class VacancyApplicationProfile : Profile
    {
        public VacancyApplicationProfile() 
        { 
            CreateMap<VacancyApplication, VacancyApplicationDTO>();
            CreateMap<VacancyApplicationDTO, VacancyApplication>();
        }
    }
}
