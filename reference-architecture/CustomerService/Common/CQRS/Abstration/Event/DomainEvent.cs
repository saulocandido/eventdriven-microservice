﻿using Common.Interfaces;
using CustomerService.Common.DDD.Abstration.Events;
using MediatR;

namespace CustomerService.Common.CQRS.Abstration.Event;

public abstract record DomainEvent<TEntity> : IDomainEvent<TEntity>, INotification where TEntity : IEntity
{
    public Guid Id { get; set; }

    public Guid EntityId { get; }

    public string? EntityETag { get; }

    public TEntity? Entity { get; }

    protected DomainEvent(TEntity? Entity, Guid EntityId = default, string? EntityETag = null)
    {
        this.EntityId = Entity?.Id ?? EntityId;
        this.EntityETag = Entity?.ETag ?? EntityETag;
        this.Entity = Entity;
    }

    public void Deconstruct(out TEntity? Entity, out Guid EntityId, out string? EntityETag)
    {
        Entity = this.Entity;
        EntityId = this.EntityId;
        EntityETag = this.EntityETag;
    }
}


