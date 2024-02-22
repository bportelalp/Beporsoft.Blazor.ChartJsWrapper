using Beporsoft.Blazor.Charts.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Configuration
{
    public class FontWeight : StringEnumClass
    {
        protected FontWeight(string value) : base(value)
        {
        }

        public static FontWeight Normal { get; } = new FontWeight("normal");
        public static FontWeight Bold { get; } = new FontWeight("bold");
        public static FontWeight Lighter { get; } = new FontWeight("lighter");
        public static FontWeight Bolder { get; } = new FontWeight("bolder");
    }
}
