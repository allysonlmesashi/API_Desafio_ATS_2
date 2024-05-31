using DesafioATS.Domain.RepositoriesContracts;
using MediatR;

namespace DesafioATS.Application.Commands.Vacancy
{
    public class DeleteVacancyCommandHandler : IRequestHandler<DeleteVacancyCommand, bool>
    {
        private readonly IVacancyRepository _repository;

        public DeleteVacancyCommandHandler(IVacancyRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> Handle(DeleteVacancyCommand request, CancellationToken cancellationToken)
        {
            await _repository.DeleteAsync(request.Id);
            return true;
        }
    }
}
