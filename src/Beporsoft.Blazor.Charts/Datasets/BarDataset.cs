using Beporsoft.Blazor.Charts.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Datasets
{
    public class BarDataset<T> : ChartDataset<T>
    {

        public BarDataset()
        {
            Type = ChartType.Bar;
        }

        public BarDataset(IEnumerable<T> data) : this()
        {
            foreach (var item in data)
            {
                Add(item);
            }
        }

        public BarDataset(string title, IEnumerable<T> data) : this(data)
        {
            Label = title;
        }
    }
}
