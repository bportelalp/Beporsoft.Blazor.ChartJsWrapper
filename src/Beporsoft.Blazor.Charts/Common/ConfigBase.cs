using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Common
{
    public class ConfigBase
    {

        public ChartType Type { get; set; }

        public ChartData Data { get; set; } = new();

    }
}
