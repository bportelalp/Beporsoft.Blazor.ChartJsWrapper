using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Common
{
    public sealed class ChartData : IChartJsObject
    {

        public ILabelList Labels { get; set; }

        public IList<IChartDataset> Datasets { get; set; } = new List<IChartDataset>();

        public object ToChartJsObject()
        {
            dynamic data = new ExpandoObject();
            List<object> datasets = Datasets.Select(d => d.ToChartJsObject()).ToList();
            data.datasets = datasets;
            data.labels = Labels;
            return data;
        }
    }
}
