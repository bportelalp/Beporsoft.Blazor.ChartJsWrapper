using Beporsoft.Blazor.Charts.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Datasets
{

    /// <summary>
    /// Represent the base class for chart dataset of type <typeparamref name="T"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class Dataset<T> : Collection<T>, IChartDataset<T>
    {
        public Dataset(ChartType type)
        {
            Type = type;
        }

        #region Properties
        public ChartType Type { get; protected set; }

        /// <summary>
        /// The label for the dataset which appears in legend and tooltip.
        /// </summary>
        public string Label { get; set; } = string.Empty;

        public ICollection<T> Data => Items;
        #endregion

        protected virtual dynamic BuildJsObject()
        {
            dynamic obj = new ExpandoObject();
            obj.label = Label;
            obj.type = Type?.Value;
            obj.data = Items;
            return obj;
        }

        dynamic IChartJsObject.ToChartObject() => BuildJsObject();
    }

    public static class DatasetExtensions
    {
        public static void AddRange<TDataset, T>(this TDataset dataset, IEnumerable<T> values) where TDataset : Dataset<T>
        {
            foreach (var value in values)
            {
                dataset.Add(value);
            }
        }
    }
}
