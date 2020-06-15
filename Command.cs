using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator
{
    class Command
    {
        [JsonProperty("val")]
        public List<string> val { get; set; }
    }
}
