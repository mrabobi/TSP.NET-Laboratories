using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEvent
{
    public class MeetingEvent : EventArgs
    {
        public MeetingEvent(string text)
        {
            Message = text;
        }
        public string Message { get; set; }
    }
}
