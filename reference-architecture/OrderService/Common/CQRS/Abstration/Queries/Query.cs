using MediatR;

namespace OrderService.Common.CQRS.Abstration.Queries
{
    public abstract record Query<TQueryResult> : IQuery<TQueryResult>, IRequest<TQueryResult>, IBaseRequest;
}
