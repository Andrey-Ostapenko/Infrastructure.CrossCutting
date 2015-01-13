using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.CrossCutting.Exceptions
{
    [Serializable]
    public class BusinessException : ApplicationException
    {
        public object Context { get; private set; }

        public BusinessException(string message, object context)
            : base(message)
        {
            Context = context;
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
        }
    }
}
