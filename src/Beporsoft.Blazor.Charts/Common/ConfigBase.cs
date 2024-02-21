using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Common
{
    public class ConfigBase : IChartJsObject
    {

        public ChartType Type { get; set; } = ChartType.Bar;

        public ChartData Data { get; set; } = new();

        public ChartOptions Options { get; set; } = new();

        public virtual object ToChartJsObject()
        {
            dynamic obj = new ExpandoObject();
            obj.type = Type.Value;
            obj.data= Data.ToChartJsObject();
            obj.plugins = new ExpandoObject();
            obj.plugins.options = Options;
            return obj;
        }
    }
}
