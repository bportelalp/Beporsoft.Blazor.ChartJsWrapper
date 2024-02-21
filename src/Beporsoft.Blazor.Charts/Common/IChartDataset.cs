using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Common
{
    public interface IChartDataset : IChartJsObject
    {
        /// <summary>
        /// The title for the dataset which appears in the legend and tooltips.
        /// </summary>
        public string Label { get; set; }

    }

    internal interface IChartDataset<T> : IChartDataset
    {
        ICollection<T> Data { get; }
        
    }
}
