using Beporsoft.Blazor.Charts.Common;
using Beporsoft.Blazor.Charts.Serialization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Datasets
{
    public sealed class LineDataset<T> : ChartDataset<T>
    {
        public LineDataset()
        {
            Type = ChartType.Line;
        }

        public LineDataset(IEnumerable<T> data) : this()
        {
            base.Data = data.ToList();
        }

        public LineDataset(string title, IEnumerable<T> data) : this(data)
        {
            Label = title;
        }

        public Color? BorderColor { get; set; }

        public Color? BackgroundColor { get; set; }

        public int? BorderWidth { get; set; }

        public bool? Stepped { get; set; }

        public double? Tension { get; set; }

        /// <summary>
        /// Style of the point.
        /// </summary>
        public PointStyle? PointStyle { get; set; }

        /// <summary>
        /// The radius of the point shape, or 0 for not render.
        /// </summary>
        public int? PointRadius { get; set; }

        /// <summary>
        /// The radius of the point shape when the mouse interacts with it.
        /// </summary>
        internal int? PointHitRadius { get; set; }

        public LineDataset<T> SetLineColor(Color lineColor)
        {
            BorderColor = lineColor;
            BackgroundColor = lineColor;
            return this;
        }

        public LineDataset<T> SetPointStyle(PointStyle style, int radius)
        {
            PointStyle = style;
            PointRadius = radius;
            PointHitRadius = radius + 10;
            return this;
        }

        

        protected override dynamic BuildJsObject()
        {
            dynamic obj = base.BuildJsObject();
            if (BorderColor is not null)
                obj.borderColor = ColorTranslator.ToHtml(BorderColor.Value);

            return obj;
        }
    }
}
