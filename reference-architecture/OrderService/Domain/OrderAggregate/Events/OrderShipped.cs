﻿
namespace OrderService.Domain.OrderAggregate.Events;

public record OrderShipped(Guid EntityId) : DomainEvent(EntityId);