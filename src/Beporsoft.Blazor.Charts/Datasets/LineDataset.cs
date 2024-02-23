using Beporsoft.Blazor.Charts.Common;
using Beporsoft.Blazor.Charts.Configuration;
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
            foreach (var item in data)
            {
                Add(item);
            }
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

        public PointOptions PointOptions { get; set; } = new();

        public string? VerticalAxisId { get; set; }

        #region Fluent methods
        public LineDataset<T> SetStepped()
        {
            Stepped = true;
            return this;
        }

        public LineDataset<T> SetLineColor(Color lineColor)
        {
            BorderColor = lineColor;
            BackgroundColor = lineColor;
            return this;
        }

        public LineDataset<T> SetPointStyle(PointStyle style, int radius)
        {
            PointOptions.PointStyle = style;
            PointOptions.Radius = radius;
            PointOptions.HoverRadius = radius + 3;
            return this;
        }

        public LineDataset<T> SetVerticalAxis(string id)
        {
            VerticalAxisId = id;
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
            if (Stepped is not null)
                obj.stepped = Stepped;

            if (VerticalAxisId is not null)
                obj.yAxisID = VerticalAxisId;

            PointOptions?.AppendLineDatasetProperties(obj);

            return obj;
        }
    }
}
