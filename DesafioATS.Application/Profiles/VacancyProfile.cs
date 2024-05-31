using AutoMapper;
using DesafioATS.Application.DTOs;
using DesafioATS.Domain.Entities;

namespace DesafioATS.Application.Profiles
{
    public class VacancyProfile : Profile
    {
        public VacancyProfile()
        {
            CreateMap<Vacancy, VacancyDTO>();
            CreateMap<VacancyDTO, Vacancy>();
        }
    }
}
