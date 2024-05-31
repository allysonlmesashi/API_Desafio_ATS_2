using AutoMapper;
using VacancyEntity = DesafioATS.Domain.Entities.Vacancy;
using DesafioATS.Application.DTOs;
using DesafioATS.Domain.RepositoriesContracts;
using MediatR;

namespace DesafioATS.Application.Commands.Vacancy
{
    public class UpdateVacancyCommandHandler : IRequestHandler<UpdateVacancyCommand, VacancyDTO>
    {
        private readonly IVacancyRepository _vacancyRepository;
        private readonly IMapper _mapper;

        public UpdateVacancyCommandHandler(IVacancyRepository vacancyRepository, IMapper mapper)
        {
            _vacancyRepository = vacancyRepository;
            _mapper = mapper;
        }

        public async Task<VacancyDTO> Handle(UpdateVacancyCommand request, CancellationToken cancellationToken)
        {
            var vacancy = _mapper.Map<VacancyEntity>(request.VacancyDTO);
            await _vacancyRepository.UpdateAsync(request.Id, vacancy);
            return _mapper.Map<VacancyDTO>(vacancy);
        }
    }
}
