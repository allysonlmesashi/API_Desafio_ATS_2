using MediatR;

namespace DesafioATS.Application.Commands.Vacancy
{
    public class DeleteVacancyCommand : IRequest<bool>
    {
        public Guid Id { get; }

        public DeleteVacancyCommand(Guid id)
        {
            Id = id;
        }
    }
}
