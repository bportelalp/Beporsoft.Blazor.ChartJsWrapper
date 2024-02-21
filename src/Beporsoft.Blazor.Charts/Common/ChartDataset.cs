using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Common
{
    /// <summary>
    /// Represent the base class for chart dataset of type <typeparamref name="T"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class ChartDataset<T> : IChartDataset<T>
    {
        public ChartType? Type { get; set; }

        public string Label { get; set; } = string.Empty;

        public ICollection<T> Data { get; set; } = new List<T>();

        protected virtual dynamic BuildJsObject()
        {
            dynamic obj = new ExpandoObject();
            obj.label = Label;
            obj.type = Type?.Value;
            obj.data = Data.ToArray();

            return obj;
        }

        dynamic IChartJsObject.ToChartJsObject() => BuildJsObject();
    }
}
