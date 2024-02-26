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

        public ScatterDataset(IEnumerable<T> data) : this()
        {
            this.AddRange(data);
        }

        public ScatterDataset(string title, IEnumerable<T> data) : this(data)
        {
            Label = title;
        }
    }
}
