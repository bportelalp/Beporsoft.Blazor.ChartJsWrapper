using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Beporsoft.Blazor.Charts.Configuration;

namespace Beporsoft.Blazor.Charts.Common
{
    public class ConfigBase : IChartJsObject
    {

        public ChartType Type { get; set; } = ChartType.Bar;

        public ChartData Data { get; set; } = new();

        public bool Responsive { get; set; } = true;

        internal bool MaintainAspectRatio { get; } = true;
        public Options Options { get; set; } = new();

        public virtual object ToChartObject()
        {
            dynamic obj = new ExpandoObject();
            obj.type = Type.Value;
            obj.data= Data.ToChartObject();
            obj.options = new ExpandoObject();
            obj.options.plugins = Options.ToChartObject();
            obj.options.responsive = Responsive;
            obj.options.maintainAspectRatio = MaintainAspectRatio;
            return obj;
        }
    }
}
