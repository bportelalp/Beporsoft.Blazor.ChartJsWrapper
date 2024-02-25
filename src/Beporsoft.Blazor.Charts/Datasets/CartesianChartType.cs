using Beporsoft.Blazor.Charts.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Datasets
{
    public class CartesianChartType : ChartType
    {
        protected CartesianChartType(string type) : base(type)
        {
        }

        /// <summary>
        /// Chart whose values are represented by points linked by a line, tipically by (x, y) continuous coordinates.
        /// </summary>
        public static CartesianChartType Line { get; } = new CartesianChartType("line");

        /// <summary>
        /// Chart whose values are represented by bars, tipically with one discrete coordinate (x) and one continuous coordinate (y).
        /// </summary>
        public static CartesianChartType Bar { get; } = new CartesianChartType("bar");

        /// <summary>
        /// Chart whose values are represented by points without a linking line, tipically by (x, y) continuous coordinates.
        /// </summary>
        public static CartesianChartType Scatter { get; } = new CartesianChartType("scatter");

        /// <summary>
        /// Chart which represent tridimensional coordinates, tipically (x, y, z) continuous coordinates, where the point location is determined
        /// by (x, y) and z the sizing of the point.
        /// </summary>
        public static CartesianChartType Bubble { get; } = new CartesianChartType("bubble");
    }
}
