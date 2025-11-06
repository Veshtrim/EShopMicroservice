using MediatR;

namespace BuildingBlocks.CQRS
{
    // This is used for commands that do not return a response
    public interface ICommandHandler<in TCommand>
        : ICommandHandler<TCommand, Unit>
        where TCommand : ICommand
    { 
    }
    // This is used for commands that return a response
    public interface ICommandHandler<in TCommand, TResponse> : IRequestHandler<TCommand, TResponse>
        where TCommand : ICommand<TResponse>
        where TResponse : notnull
    {
    }
}
