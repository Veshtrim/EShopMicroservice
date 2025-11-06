using MediatR;

namespace BuildingBlocks.CQRS
{
    public interface ICommand : ICommand<Unit>
    {
    }

    // This is used for returing a response
    public interface ICommand<out TResponse> : IRequest<TResponse>
    {
    }
}
