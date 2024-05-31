using AutoMapper;
using DesafioATS.Application.DTOs;
using DesafioATS.Domain.Entities;

namespace DesafioATS.Application.Profiles
{
    public class CandidateResumeProfile : Profile
    {
        public CandidateResumeProfile()
        {
            CreateMap<CandidateResume, CandidateResumeDTO>();
            CreateMap<CandidateResumeDTO, CandidateResume>();
        }
    }
}
