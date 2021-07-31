using Clean.Architecture.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Domain.Core.Commands
{
    public abstract class Command: Messages
    {
        public DateTime Timestamp{ get; protected set; }
        protected Command()
        {
            Timestamp = DateTime.Now;
        }
    }
}
