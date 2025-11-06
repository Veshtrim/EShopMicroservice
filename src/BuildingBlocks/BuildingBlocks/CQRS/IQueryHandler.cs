using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlocks.CQRS
{
    // This is used for queries that do not return a response
    public interface IQueryHandler<in TQuery> : IQueryHandler<TQuery, Unit>
        where TQuery : IQuery<Unit>
    {
    }
    // This is used for queries that return a response
    public interface IQueryHandler<in TQuery, TResponse> : IRequestHandler<TQuery, TResponse>
        where TQuery : IQuery<TResponse>
        where TResponse : notnull
    {
    }
}
