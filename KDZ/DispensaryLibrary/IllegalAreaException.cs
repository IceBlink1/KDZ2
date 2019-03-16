using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispensaryLibrary
{

    [Serializable]
    public class IllegalAreaException : IllegalLocationInfoException
    {
        public IllegalAreaException() { }
        public IllegalAreaException(string message) : base(message) { }
        public IllegalAreaException(string message, Exception inner) : base(message, inner) { }
        protected IllegalAreaException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
