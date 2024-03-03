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
        /// The color applied to the bar border.
        /// </summary>
        public Color? BorderColor { get; set; }

        /// <summary>
        /// The color applied to the bar fill.
        /// </summary>
        public Color? BackgroundColor { get; set; }

        /// <summary>
        /// The bar border width in pixels.
        /// </summary>
        public int? BorderWidth { get; set; }

        /// <summary>
        /// The bar border radius in pixels.
        /// </summary>
        public int? BorderRadius { get; set; }

        /// <summary>
        /// Skip edges when drawing bar.
        /// </summary>
        public BarBorderSkip? SkipBorderEdges { get; set; }

        /// <summary>
        /// Percentage, between 0 and 1 of the available width.
        /// </summary>
        public double? WidthPercentage { get; set; }

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
            if (SkipBorderEdges is not null)
                obj.borderSkipped = SkipBorderEdges.Value;
            return obj;
        }
    }

    public static class BarDatasetExtensions
    {

        /// <summary>
        /// Sets the color for both border and fill of bar.
        /// </summary>
        /// <param name="color"></param>
        /// <returns>The same dataset instance so multiple calls can be chained.</returns>
        public static BarDataset<T> SetBarColor<T>(this BarDataset<T> dataset, Color color)
        {
            dataset.BorderColor = color;
            dataset.BackgroundColor = color;
            return dataset;
        }

        /// <summary>
        /// Sets border for bars.
        /// </summary>
        /// <param name="color"></param>
        /// <returns>The same dataset instance so multiple calls can be chained.</returns>
        public static BarDataset<T> SetBorder<T>(this BarDataset<T> dataset, Color color, int width)
        {
            dataset.BorderWidth = width;
            dataset.BorderColor = color;
            return dataset;
        }
    }
}
