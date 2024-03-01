using Beporsoft.Blazor.Charts.Common;
using Beporsoft.Blazor.Charts.Configuration;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Datasets
{
    public class LineDataset<T> : CartesianDataset<T>
    {

        #region Constructors
        public LineDataset() : base(CartesianChartType.Line) { }

        protected LineDataset(CartesianChartType type) : base(type) { }

        public LineDataset(IEnumerable<T> data) : this()
        {
            this.AddRange(data);
        }

        public LineDataset(string title, IEnumerable<T> data) : this(data)
        {
            Label = title;
        }
        #endregion

        /// <summary>
        /// The color applied to the line and the border of points.
        /// </summary>
        public Color? BorderColor { get; set; }

        /// <summary>
        /// The color applied to the fill of points and under line if activated.
        /// </summary>
        public Color? BackgroundColor { get; set; }

        /// <summary>
        /// Set to <see langword="true"/> for a stepped chart.
        /// </summary>
        public bool? Stepped { get; set; }

        /// <summary>
        /// Configures the style of points.
        /// </summary>
        public PointOptions? PointOptions { get; set; } = new();

        /// <summary>
        /// Configures the style of line.
        /// </summary>
        public LineOptions? LineOptions { get; set; } = new();

        /// <summary>
        /// Configures how the points interact on hover
        /// </summary>
        public HoverOptions? HoverOptions { get; set; } = new();



        #region Fluent methods

        #endregion



        protected override dynamic BuildJsObject()
        {
            dynamic obj = base.BuildJsObject();
            if (BorderColor is not null)
                obj.borderColor = ColorTranslator.ToHtml(BorderColor.Value);
            if (BackgroundColor is not null)
                obj.backgroundColor = ColorTranslator.ToHtml(BackgroundColor.Value);
            if (Stepped is not null)
                obj.stepped = Stepped;

            LineOptions?.AppendLineDatasetProperties(obj);
            PointOptions?.AppendPointOptions(obj);
            HoverOptions?.AppendPointInteractions(obj);
            return obj;
        }
    }


    public static class LineDatasetExtensions
    {
        public static LineDataset<T> SetStepped<T>(this LineDataset<T> dataset)
        {
            dataset.Stepped = true;
            return dataset;
        }

        public static LineDataset<T> SetLineColor<T>(this LineDataset<T> dataset, Color lineColor)
        {
            dataset.BorderColor = lineColor;
            dataset.BackgroundColor = lineColor;
            return dataset;
        }

        public static LineDataset<T> SetPointStyle<T>(this LineDataset<T> dataset, PointStyle style, int radius)
        {
            dataset.PointOptions.Style = style;
            dataset.PointOptions.Radius = radius;
            return dataset;
        }

        /// <summary>
        /// Provides the Id of the vertical axis which will be used with this dataset. It is
        /// usefull only when multiple y axis are configured. Defaults to 'y'.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static LineDataset<T> SetVerticalAxis<T>(this LineDataset<T> dataset, string id)
        {
            dataset.OrdinateAxisId = id;
            return dataset;
        }

        /// <summary>
        /// Configures the dataset to supress the points rendering.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dataset"></param>
        /// <returns>The same dataset instance so multiple calls can be chained.</returns>
        public static LineDataset<T> SupressPoints<T>(this LineDataset<T> dataset)
        {
            dataset.PointOptions = new PointOptions
            {
                Radius = 0
            };
            return dataset;
        }

        /// <summary>
        /// Adds a <see cref="PointOptions"/> instance to the dataset for configuration of point styling.
        /// </summary>
        /// <returns>The <see cref="PointOptions"/> instance created for further configuring.</returns>
        public static PointOptions AddPointOptions<T>(this LineDataset<T> dataset)
        {
            dataset.PointOptions = new();
            return dataset.PointOptions;
        }

        /// <summary>
        /// Adds a <see cref="LineOptions"/> instance to the dataset for configuration of line styling.
        /// </summary>
        /// <returns>The <see cref="LineOptions"/> instance created for further configuring.</returns>
        public static LineOptions AddLineOptions<T>(this LineDataset<T> dataset)
        {
            dataset.LineOptions = new();
            return dataset.LineOptions;
        }

        /// <summary>
        /// Adds a <see cref="HoverOptions"/> instance to the dataset for configuring the hover interactions.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dataset"></param>
        /// <returns>The <see cref="HoverOptions"/> instance created for further configuring.</returns>
        public static HoverOptions AddHoverOptions<T>(this LineDataset<T> dataset)
        {
            dataset.HoverOptions = new();
            return dataset.HoverOptions;
        }
    }
}
