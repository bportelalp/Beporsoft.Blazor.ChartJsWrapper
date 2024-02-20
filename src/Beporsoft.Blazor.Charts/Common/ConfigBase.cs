using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Common
{
    public class ConfigBase
    {

        public ChartType Type { get; set; } = ChartType.Bar;

        public ChartData Data { get; set; } = new();

        public ChartOptions Options { get; set; } = new();

    }
}
