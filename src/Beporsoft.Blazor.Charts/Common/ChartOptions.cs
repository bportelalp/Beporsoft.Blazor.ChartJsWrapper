using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Common
{
    public class ChartOptions
    {
        public bool Responsive { get; set; } = true;

        [JsonIgnore]
        public Legend? Legend { get; set; }

        [JsonIgnore]
        public Title? Title { get; set; }

        public object Plugins { get => new { Legend, Title }; }
    }
}
