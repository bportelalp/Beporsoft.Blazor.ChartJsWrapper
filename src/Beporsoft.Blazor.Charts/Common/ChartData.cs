using Beporsoft.Blazor.Charts.Datasets;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Common
{
    public sealed class ChartData : IChartJsObject
    {

        public IList Labels { get; set; } = new List<string>();

        public IList<IChartDataset> Datasets { get; set; } = new List<IChartDataset>();

        public object ToChartObject()
        {
            dynamic data = new ExpandoObject();
            List<object> datasets = Datasets.Select(d => d.ToChartObject()).ToList();
            data.datasets = datasets;
            data.labels = Labels;
            return data;
        }
    }
}
