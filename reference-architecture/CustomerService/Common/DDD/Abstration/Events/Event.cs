using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerService.Common.DDD.Abstration.Events
{
    //
    // Summary:
    //     A statement of fact about what change has been made to the domain state.
    public record Event : IEvent
    {
        public Guid Id { get; set; }
    }
}
