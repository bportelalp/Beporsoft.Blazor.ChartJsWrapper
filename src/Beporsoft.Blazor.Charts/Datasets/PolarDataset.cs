using Beporsoft.Blazor.Charts.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Datasets
{
    public class PolarDataset<T> : Dataset<T>
    {
        public PolarDataset(PolarChartType type) : base(type)
        {
        }
        public PolarDataset(PolarChartType type, IEnumerable<T> data) : this(type)
        {
            this.AddRange(data);
        }

        public PolarDataset(PolarChartType type, string title, IEnumerable<T> data) : this(type, data)
        {
            Label = title;
        }

        public Color BackgroundColor { get; set; }
        public Color BorderColor { get;}
        public int BorderWidth { get; set; }
    }
}
