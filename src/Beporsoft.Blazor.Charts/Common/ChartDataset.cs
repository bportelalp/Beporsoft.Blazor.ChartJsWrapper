using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Common
{
    public class ChartDataset<T> : IChartDataset<T>
    {
        public ChartType? Type { get; set; }

        public string Title { get; set; } = string.Empty;

        public ICollection<T> Data { get; set; } = new List<T>();


        List<object?> IChartDataset.GetData()
        {
            return Data.Select(i => (object?)i).ToList();
        }
    }
}
