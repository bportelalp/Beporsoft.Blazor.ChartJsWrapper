using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Datasets
{
    public interface IChartDataset
    {
        /// <summary>
        /// The label for the dataset which appears in the legend and tooltips.
        /// 
        /// </summary>
        public string Label { get; set; }

    }

    public interface IChartDataset<T> : IChartDataset
    {
        ICollection<T> Data { get; }
    }
}
