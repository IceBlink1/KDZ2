using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispensaryLibrary
{

    [Serializable]
    public class IllegalIDException : DispensaryLibException
    {
        public IllegalIDException() { }
        public IllegalIDException(string message) : base(message) { }
        public IllegalIDException(string message, Exception inner) : base(message, inner) { }
        protected IllegalIDException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
