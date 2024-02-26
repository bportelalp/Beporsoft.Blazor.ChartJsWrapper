using Beporsoft.Blazor.Charts.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Datasets
{
    public class PolarChartType : ChartType
    {
        private PolarChartType(string value) : base(value)
        {
        }

        public static PolarChartType Pie { get; } = new PolarChartType("pie");
        public static PolarChartType Doughnut { get; } = new PolarChartType("doughnut");
        public static PolarChartType Radar { get; } = new PolarChartType("radar");
    }
}
