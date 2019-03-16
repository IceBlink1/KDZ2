using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispensaryLibrary
{

    [Serializable]
    public class IllegalLocationInfoException : DispensaryLibException
    {
        public IllegalLocationInfoException() { }
        public IllegalLocationInfoException(string message) : base(message) { }
        public IllegalLocationInfoException(string message, Exception inner) : base(message, inner) { }
        protected IllegalLocationInfoException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
