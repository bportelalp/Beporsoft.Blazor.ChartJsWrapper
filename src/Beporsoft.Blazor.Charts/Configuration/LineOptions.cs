using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Configuration
{
    public class LineOptions
    {
        /// <summary>
        /// Line width, in pixels.
        /// </summary>
        public int? Width { get; set; }

        /// <summary>
        /// Cap style of the line. See <see href="https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/lineCap">MDN</see> for more information.
        /// </summary>
        public CapStyle? CapStyle { get; set; }

        /// <summary>
        /// <inheritdoc cref="CubicInterpolationMode"/>
        /// </summary>
        public CubicInterpolationMode? InterpolationMode { get; set; }

        /// <summary>
        /// <see href="https://en.wikipedia.org/wiki/B%C3%A9zier_curve">Bezier curve tension</see> of the line. Set 0 to straigth lines.
        /// This field has no effect with <see cref="CubicInterpolationMode.Monotone"/>.
        /// </summary>
        public double? Tension { get; set; }

        /// <summary>
        /// Set to <see langword="true"/> to fill the area under the line.
        /// </summary>
        public bool? Fill { get; set; }

        /// <summary>
        /// If <see langword="true"/>, lines will be drawn between points with null data, otherwise data will create a break.
        /// </summary>
        public bool? SpanGaps { get; set; }

        internal void AppendLineDatasetProperties(dynamic obj)
        {
            if (InterpolationMode is not null)
                obj.cubicInterpolationMode = InterpolationMode.Value;
            if (Tension is not null)
                obj.tension = Tension.Value;
            if (CapStyle is not null)
                obj.borderCapStyle = CapStyle.Value;
            if (Width is not null)
                obj.borderWidth = Width.Value;
            if (SpanGaps is not null)
                obj.spanGaps = SpanGaps.Value;
            if(Fill is not null)
                obj.fill = Fill.Value;
        }
    }

    public static class LineOptionsExtensions
    {
        /// <summary>
        /// Configures the interpolation mode of the line as monotone, showing a line near to y = f(x).
        /// <para>
        /// </para>
        /// </summary>
        /// <param name="options"></param>
        /// <returns>The same options instance so that multiple calls can be chained.</returns>
        public static LineOptions WithMonotoneInterpolation(this LineOptions options)
            => options.SetDrawingStyle(CubicInterpolationMode.Monotone, default, default);

        /// <summary>
        /// Configures the line style when the slope changes.
        /// </summary>
        /// <param name="options"></param>
        /// <param name="capStyle">How the end of lines is displayed.</param>
        /// <returns>The same options instance so that multiple calls can be chained.</returns>
        public static LineOptions WithStyle(this LineOptions options, CapStyle capStyle)
            => options.SetDrawingStyle(default, default, capStyle);

        /// <summary>
        /// Configures the line style to smooth the line with the given tension.
        /// </summary>
        /// <param name="options"></param>
        /// <param name="tension">Bezier curve tension for the line.</param>
        /// <returns>The same options instance so that multiple calls can be chained.</returns>
        public static LineOptions WithStyle(this LineOptions options, double tension)
            => options.SetDrawingStyle(default, tension, default);

        /// <summary>
        /// Configures the line style main values.
        /// </summary>
        /// <param name="options"></param>
        /// <param name="capStyle">How the end of lines is displayed.</param>
        /// <param name="tension">Bezier curve tension for the line.</param>
        /// <returns>The same options instance so that multiple calls can be chained.</returns>
        public static LineOptions WithStyle(this LineOptions options, CapStyle capStyle, double tension)
            => options.SetDrawingStyle(default, tension, capStyle);

        /// <summary>
        /// Breaks the line if there is one missing value along the dataset.
        /// </summary>
        /// <param name="options"></param>
        /// <returns>The same options instance so that multiple calls can be chained.</returns>
        public static LineOptions BreakOnMissingValues(this LineOptions options)
        {
            options.SpanGaps = true;
            return options;
        }

        /// <summary>
        /// Adds a fill on the area under the lane. The same color of the line will be applied.
        /// </summary>
        /// <param name="options"></param>
        /// <returns>The same options instance so that multiple calls can be chained.</returns>
        public static LineOptions WithFill(this LineOptions options)
        {
            options.Fill = true;
            return options;
        }


        private static LineOptions SetDrawingStyle(this LineOptions options,
            CubicInterpolationMode? interpolationMode,
            double? tension,
            CapStyle? capStyle)
        {
            options.InterpolationMode = interpolationMode is null ? options.InterpolationMode : interpolationMode;
            options.Tension = tension is null ? options.Tension : tension;
            options.CapStyle = capStyle is null ? options.CapStyle : capStyle;
            return options;
        }
    }
}
