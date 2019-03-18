using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispensaryLibrary
{
    public class CloseInfo
    {
        public CloseInfo()
        {
            CloseFlag = true;
        }
        public CloseInfo(string closeReason, DateTime closeDate, DateTime reopenDate)
        {
            CloseFlag = false;
            CloseReason = closeReason;
            if (closeDate > reopenDate)
                throw new IllegalDateException("Дата открытия не может быть раньше даты закрытия");
            CloseDate = closeDate;
            reopenDate = ReopenDate;
        }
        public bool CloseFlag { get; private set; }
        public string CloseReason { get; private set; }
        public DateTime CloseDate { get; private set; }
        public DateTime ReopenDate { get; private set; }
    }
}
