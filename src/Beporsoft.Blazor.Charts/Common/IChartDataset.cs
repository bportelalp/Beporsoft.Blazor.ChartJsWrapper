using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Common
{
    public interface IChartDataset
    {
        /// <summary>
        /// The title for the dataset which appears in the legend and tooltips.
        /// </summary>
        public string Title { get; set; }

        internal List<object?> GetData();

    }

    public interface IChartDataset<T> : IChartDataset
    {
        ICollection<T> Data { get; }
    }
}
