using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Infrastructure.CrossCutting.Exceptions
{
    [Serializable]
    public class ResourceNotFoundException : ApplicationException
    {
        public string Reason { get; private set; }

        public ResourceNotFoundException(string message, string reason): base(message)
        {
            Reason = reason;
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
        }
    }
}
