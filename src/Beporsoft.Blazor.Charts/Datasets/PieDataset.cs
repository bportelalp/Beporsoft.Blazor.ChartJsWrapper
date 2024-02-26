using Beporsoft.Blazor.Charts.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Datasets
{
    public class PieDataset<T> : Dataset<T>
    {
        public PieDataset() : base(PolarChartType.Pie)
        {
        }
        public PieDataset(IEnumerable<T> data) : this()
        {
            this.AddRange(data);
        }

        public PieDataset(string title, IEnumerable<T> data) : this(data)
        {
            Label = title;
        }
    }
}
