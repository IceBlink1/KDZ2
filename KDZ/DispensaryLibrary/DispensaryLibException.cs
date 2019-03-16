using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispensaryLibrary
{

    [Serializable]
    public class DispensaryLibException : ApplicationException
    {
        public DispensaryLibException() { }
        public DispensaryLibException(string message) : base(message) { }
        public DispensaryLibException(string message, Exception inner) : base(message, inner) { }
        protected DispensaryLibException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
