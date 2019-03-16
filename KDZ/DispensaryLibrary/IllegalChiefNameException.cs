using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispensaryLibrary
{

    [Serializable]
    public class IllegalChiefNameException : DispensaryLibException
    {
        public IllegalChiefNameException() { }
        public IllegalChiefNameException(string message) : base(message) { }
        public IllegalChiefNameException(string message, Exception inner) : base(message, inner) { }
        protected IllegalChiefNameException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
