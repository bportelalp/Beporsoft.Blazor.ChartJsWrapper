using Beporsoft.Blazor.Charts.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Scales
{
    public class ScaleType : StringEnumClass
    {
        public ScaleType(string name) : base(name)
        {
            
        }

        public static ScaleType Linear { get; set; } = new ScaleType("linear");
        public static ScaleType Logarithmic { get; set; } = new ScaleType("logarithmic");
        public static ScaleType Category { get; set; } = new ScaleType("category");
    }
}
