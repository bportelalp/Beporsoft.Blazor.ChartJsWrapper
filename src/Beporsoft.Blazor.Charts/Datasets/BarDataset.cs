using Beporsoft.Blazor.Charts.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Datasets
{
    public class BarDataset<T> : ChartDataset<T>
    {

        public BarDataset(IEnumerable<T> data) : this()
        {
            base.Data = data.ToList();
        }
        public BarDataset()
        {
            Type = ChartType.Bar;
        }
    }
}
