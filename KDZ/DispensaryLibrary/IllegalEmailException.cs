using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispensaryLibrary
{

    [Serializable]
    public class IllegalEmailException : DispensaryLibException
    {
        public IllegalEmailException() { }
        public IllegalEmailException(string message) : base(message) { }
        public IllegalEmailException(string message, Exception inner) : base(message, inner) { }
        protected IllegalEmailException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
