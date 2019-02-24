using Exercicio.Um.Domain.Commands;

namespace Exercicio.Um.Domain.CommandHandlers
{
    public interface ICommandHandler<T> where T : ICommand
    {
        void Handle(T command);
    }
}
