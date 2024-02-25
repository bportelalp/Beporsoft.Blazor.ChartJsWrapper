using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Datasets
{
    public class ScatterDataset<T> : LineDataset<T>
    {
        public ScatterDataset() : base(CartesianChartType.Scatter)
        {
            
        }
    }
}
