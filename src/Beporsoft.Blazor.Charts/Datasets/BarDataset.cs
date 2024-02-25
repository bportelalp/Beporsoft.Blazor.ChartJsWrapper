using Beporsoft.Blazor.Charts.Cartesian;
using Beporsoft.Blazor.Charts.Common;
using Beporsoft.Blazor.Charts.Configuration;
using Beporsoft.Blazor.Charts.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Datasets
{
    public class BarDataset<T> : CartesianDataset<T>
    {
        #region Constructors
        public BarDataset() : base(CartesianChartType.Bar)
        {
        }

        public BarDataset(IEnumerable<T> data) : this()
        {
            foreach (var item in data)
            {
                Add(item);
            }
        }

        public BarDataset(string title, IEnumerable<T> data) : this(data)
        {
            Label = title;
        }
        #endregion

        #region Properties
        /// <summary>
        /// The color applied to the line and the border of points.
        /// </summary>
        public Color? BorderColor { get; set; }

        /// <summary>
        /// The color applied to the fill of points.
        /// </summary>
        public Color? BackgroundColor { get; set; }

        public int? BorderWidth { get; set; }

        /// <summary>
        /// Percentage, between 0 and 1 of the available width.
        /// </summary>
        public double? WidthPercentage { get; set; }

        /// <summary>
        /// Only with stacked axis, allow to stack datasets in groups. Datasets with the same
        /// value on this property will be stacked together.
        /// </summary>
        public string? StackGroup { get; set; }
        #endregion

        #region Fluent methods
        /// <summary>
        /// Sets the color for both border and fill of bar.
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public BarDataset<T> SetBarColor(Color color)
        {
            BorderColor = color;
            BackgroundColor = color;
            return this;
        }

        public BarDataset<T> SetBorder(Color color, int width)
        {
            BorderWidth = width;
            BorderColor = color;
            return this;
        }
        #endregion


        protected override dynamic BuildJsObject()
        {
            dynamic obj = base.BuildJsObject();
            if (BorderColor is not null)
                obj.borderColor = ColorTranslator.ToHtml(BorderColor.Value);
            if (BackgroundColor is not null)
                obj.backgroundColor = ColorTranslator.ToHtml(BackgroundColor.Value);
            if (BorderWidth is not null)
                obj.borderWidth = BorderWidth.Value;
            if (WidthPercentage is not null)
                obj.barPercentage = NumberHelpers.AdjustInterval(WidthPercentage.Value, 0, 1);
            return obj;
        }
    }
}
