using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Beporsoft.Blazor.Charts.Common
{
    public class ChartType : StringEnumClass
    {
        protected ChartType(string value) : base(value)
        {
        }
        
        public static ChartType Bar { get; } = new ChartType("bar");
    }
}
