using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Common
{
    public class ChartData
    {

        public IAxisLabels Labels { get; set; }

        public IList<IChartDataset> Datasets { get; set; }
    }
}
