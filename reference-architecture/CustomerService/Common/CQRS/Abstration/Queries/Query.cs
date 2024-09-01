using MediatR;

namespace CustomerService.Common.CQRS.Abstration.Queries
{
    public abstract record Query<TQueryResult> : IQuery<TQueryResult>, IRequest<TQueryResult>, IBaseRequest;
}
