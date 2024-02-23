using System;
using System.Collections.Generic;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Scales
{
    public class AxisGrid
    {
        public int? LineWidth { get; set; }

        public Color? Color { get; set; }

        internal object ToChartObject()
        {
            dynamic obj = new ExpandoObject();

            if(LineWidth is not null)
                obj.lineWidth = LineWidth;
            if(Color is not null) 
                obj.color = ColorTranslator.ToHtml(Color.Value);

            return obj;
        }
    }
}
