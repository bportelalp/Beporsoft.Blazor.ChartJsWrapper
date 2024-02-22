using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Configuration
{
    public class PointOptions
    {
        public int? Radius { get; set; }
        public PointStyle? PointStyle { get; set; }
        public int? HoverRadius { get; set; }


        internal void AppendLineDatasetProperties(dynamic obj)
        {
            if (PointStyle is not null)
                obj.pointStyle = PointStyle.Value;
            if (Radius is not null)
                obj.pointRadius = Radius.Value;
            if (HoverRadius is not null)
                obj.pointHoverRadius = HoverRadius.Value;

        }
    }
}
