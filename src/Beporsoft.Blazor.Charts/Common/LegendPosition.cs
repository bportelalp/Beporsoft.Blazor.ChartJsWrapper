using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Common
{
    [JsonConverter(typeof(StringEnumConverter))]
    public class LegendPosition : StringEnumClass
    {
        private LegendPosition(string value) : base(value)
        {
            Value = value;
        }

        public static LegendPosition Top { get; } = new LegendPosition("top");
        public static LegendPosition Bottom { get; } = new LegendPosition("bottom");
        public static LegendPosition Left { get; } = new LegendPosition("left");
        public static LegendPosition Right { get; } = new LegendPosition("right");

        
    }
}
