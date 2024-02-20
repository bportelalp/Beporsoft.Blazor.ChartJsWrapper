using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Common
{
    public class Legend
    {
        public LegendPosition Position { get; set; } = LegendPosition.Top;
        public Align Align { get; set; } = Align.Center;
    }
}
