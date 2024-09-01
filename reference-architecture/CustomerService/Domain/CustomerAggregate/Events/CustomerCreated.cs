
namespace CustomerService.Domain.CustomerAggregate.Events;


public record CustomerCreated(Customer? Entity) : DomainEvent<Customer>(Entity);
