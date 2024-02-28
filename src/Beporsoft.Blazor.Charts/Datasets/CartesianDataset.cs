using Beporsoft.Blazor.Charts.Common;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Datasets
{
    /// <summary>
    /// Represent a dataset whose values can be represented in a cartesian system.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CartesianDataset<T> : Dataset<T>
    {
        public CartesianDataset(ChartType type) : base(type)
        {
        }

        /// <summary>
        /// Gets or sets the identifier for the ordinate axis, commonly y-axis on a cartesian system.
        /// If any value is provided, it will assumed the value of 'y'.
        /// </summary>
        public string? OrdinateAxisId { get; set; }

        /// <summary>
        /// Only with stacked axis, allow to stack datasets in groups. Datasets with the same
        /// value on this property will be stacked together.
        /// </summary>
        public string? StackGroup { get; set; }

        protected override dynamic BuildJsObject()
        {
            dynamic obj = base.BuildJsObject();
            if (OrdinateAxisId is not null)
                obj.yAxisID = OrdinateAxisId;
            if(StackGroup is not null)
                obj.group = StackGroup;
            return obj;
        }
    }
}
