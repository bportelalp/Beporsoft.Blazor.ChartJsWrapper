using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Datasets
{
    internal class ChartDataset<T> : IChartDataset
    {
        public string Label { get; set; } = string.Empty;

        public ICollection<T> Data { get; set; } = new List<T>();

        
    }
}
