using AutoMapper;
using DesafioATS.Application.DTOs;
using DesafioATS.Domain.Entities;

namespace DesafioATS.Application.Profiles
{
    public class CandidateProfile : Profile
    {
        public CandidateProfile()
        {
            CreateMap<Candidate, CandidateDTO>();
            CreateMap<CandidateDTO, Candidate>();
        }
    }
}
