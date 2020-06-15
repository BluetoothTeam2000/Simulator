using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator
{
    class Response
    {
        public string command { get; set; }
        public List<HistoryData> values { get; set; }
    }
}
