using MediatR;

namespace BuildingBlocks.CQRS
{
    // This is used for read operations
    public  interface IQuery<out TResponse> : IRequest<TResponse>
        where TResponse : notnull
    {
    }
}
