using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Common.DDD.Abstration.Entities
{
    public abstract class Entity : IEntity
    {
        public Guid Id { get; set; }

        public string? ETag { get; set; }
    }
}
