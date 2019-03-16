using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispensaryLibrary
{

    [Serializable]
    public class IllegalPhoneNumberException : DispensaryLibException
    {
        public IllegalPhoneNumberException() { }
        public IllegalPhoneNumberException(string message) : base(message) { }
        public IllegalPhoneNumberException(string message, Exception inner) : base(message, inner) { }
        protected IllegalPhoneNumberException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
