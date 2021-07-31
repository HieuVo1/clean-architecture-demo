using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Domain.Core.Events
{
    public abstract class Messages: IRequest<bool>
    {
        public string MessageType { get; protected set; }
        public Messages()
        {
            MessageType = GetType().Name;
        }
    }
}
