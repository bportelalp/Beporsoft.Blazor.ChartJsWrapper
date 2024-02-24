using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public abstract class ChartDataset<T> : Collection<T>, IChartDataset<T>
    {
        #region Properties
        public ChartType? Type { get; set; }

        /// <summary>
        /// The label for the dataset which appears in legend and tooltip.
        /// </summary>
        public string Label { get; set; } = string.Empty;

        public ICollection<T> Data => Items;

        /// <summary>
        /// Gets or sets the identifier for the ordinate axis, commonly y-axis on a cartesian system.
        /// If any value is provided, it will assumed the value of 'y'.
        /// </summary>
        public string? OrdinateAxisId { get; set; }

        #endregion

        protected virtual dynamic BuildJsObject()
        {
            dynamic obj = new ExpandoObject();
            obj.label = Label;
            obj.type = Type?.Value;
            obj.data = Items;

            if (OrdinateAxisId is not null)
                obj.yAxisID = OrdinateAxisId;

            return obj;
        }

        dynamic IChartJsObject.ToChartObject() => BuildJsObject();
    }
}
