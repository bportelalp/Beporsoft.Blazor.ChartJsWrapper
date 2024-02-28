using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Datasets
{
    /// <summary>
    /// Represent a <see cref="PolarDataset{T}"/> which is initialized as <see cref="PolarChartType.Pie"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PieDataset<T> : PolarDataset<T>
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
