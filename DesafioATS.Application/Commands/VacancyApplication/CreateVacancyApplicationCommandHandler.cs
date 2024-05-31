using AutoMapper;
using VacancyApplicationEntity = DesafioATS.Domain.Entities.VacancyApplication;
using DesafioATS.Application.DTOs;
using DesafioATS.Domain.RepositoriesContracts;
using MediatR;

namespace DesafioATS.Application.Commands.VacancyApplication
{
    public class CreateVacancyApplicationCommandHandler : IRequestHandler<CreateVacancyApplicationCommand, VacancyApplicationDTO>
    {
        private readonly IVacancyApplicationRepository _vacancyApplicationRepository;
        private readonly IMapper _mapper;

        public CreateVacancyApplicationCommandHandler(IVacancyApplicationRepository vacancyApplicationRepository, IMapper mapper)
        {
            _vacancyApplicationRepository = vacancyApplicationRepository;
            _mapper = mapper;
        }

        public async Task<VacancyApplicationDTO> Handle(CreateVacancyApplicationCommand request, CancellationToken cancellationToken)
        {
            var vacancyApplication = _mapper.Map<VacancyApplicationEntity>(request.VacancyApplication);
            await _vacancyApplicationRepository.CreateAsync(vacancyApplication);
            return _mapper.Map<VacancyApplicationDTO>(vacancyApplication);
        }
    }
}
