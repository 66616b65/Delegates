using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPEvents
{
    public class EventClass
    {
        public delegate void SampleEventHandler(string message);
        public event SampleEventHandler SampleEvent;

    }       
}
