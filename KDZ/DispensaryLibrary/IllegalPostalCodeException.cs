using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispensaryLibrary
{

    [Serializable]
    public class IllegalPostalCodeException : DispensaryLibException
    {
        public IllegalPostalCodeException() { }
        public IllegalPostalCodeException(string message) : base(message) { }
        public IllegalPostalCodeException(string message, Exception inner) : base(message, inner) { }
        protected IllegalPostalCodeException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
