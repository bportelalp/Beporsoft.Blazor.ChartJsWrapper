using System;
using System.Collections.Generic;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Configuration
{
    /// <summary>
    /// Configures the style of points, displayed tipically on line datasets.
    /// </summary>
    public class PointOptions
    {
        /// <summary>
        /// The radius of the point shape in pixels, or 0 for supress.
        /// </summary>
        public int? Radius { get; set; }

        /// <summary>
        /// <inheritdoc cref="PointStyle"/>
        /// </summary>
        public PointStyle? Style { get; set; }

        /// <summary>
        /// The width of the point border.
        /// </summary>
        public int? BorderWidth { get; set; }

        /// <summary>
        /// The rotation of the point in degrees. This is visible for non-rounded <see cref="PointStyle"/> values.
        /// </summary>
        public int? Rotation { get; set; }

        /// <summary>
        /// The border color for point. Default is the border color of parent dataset.
        /// </summary>
        public Color? BorderColor { get; set; }

        /// <summary>
        /// The fill color for point. Default is the background color of parent dataset.
        /// </summary>
        public Color? FillColor { get; set; }

        /// <summary>
        /// The radius in pixels that reacts to mouse events.
        /// <para>
        /// This property is useful when you want small points but increase the radius where the point interacts with the mouse and displays the tooltip as example.
        /// </para>
        /// </summary>
        public int? HitRadius { get; set; }


        internal void AppendPointOptions(dynamic obj)
        {
            AppendOptions(obj);
            if (Radius is not null)
                obj.pointRadius = Radius.Value;
            if (Rotation is not null)
                obj.pointRotation = Rotation.Value;
            if (HitRadius is not null)
                obj.pointHitRadius = HitRadius.Value;
        }

        internal void AppendBubbleOptions(dynamic obj)
        {
            AppendOptions(obj);
            if (Radius is not null)
                obj.radius = Radius.Value;
            if (Rotation is not null)
                obj.rotation = Rotation.Value;
            if (HitRadius is not null)
                obj.hitRadius = HitRadius.Value;
        }

        private void AppendOptions(dynamic obj)
        {
            if (Style is not null)
                obj.pointStyle = Style.Value;
            if (BorderColor is not null)
                obj.borderColor = ColorTranslator.ToHtml(BorderColor.Value);
            if (FillColor is not null)
                obj.backgroundColor = ColorTranslator.ToHtml(FillColor.Value);
        }
    }

    public static class PointOptionsExtensions
    {
        public static PointOptions WithRadius(this PointOptions options, int radius)
        {
            options.Radius = radius;
            return options;
        }

        public static PointOptions WithStyle(this PointOptions options, PointStyle style)
        {
            options.Style = style;
            return options;
        }

        public static PointOptions WithHitRadius(this PointOptions options, int hitRadius)
        {
            options.HitRadius = hitRadius;
            return options;
        }
    }

}
