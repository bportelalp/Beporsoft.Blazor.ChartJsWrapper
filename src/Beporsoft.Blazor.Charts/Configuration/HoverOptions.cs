using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Beporsoft.Blazor.Charts.Datasets;

namespace Beporsoft.Blazor.Charts.Configuration
{
    /// <summary>
    /// Options for configure how the elements interacts with the mouse.
    /// <para>
    /// Options can apply to points, bars...
    /// </para>
    /// </summary>
    public class HoverOptions
    {
        /// <summary>
        /// Border color of the element when hover.
        /// </summary>
        public Color? BorderColor { get; set; }

        /// <summary>
        /// Fill color of the element when hover.
        /// </summary>
        public Color? FillColor { get; set; }

        /// <summary>
        /// Border width of the element when hover.
        /// </summary>
        public int? BorderWidth { get; set; }

        /// <summary>
        /// Radius of the element when hover.
        /// </summary>
        public int? BorderRadius { get; set; }


        /// <summary>
        /// Method destinated to add to <see cref="LineDataset{T}"/>
        /// </summary>
        /// <param name="opt"></param>
        internal void AppendPointInteractions(dynamic opt)
        {
            if (BorderColor is not null)
                opt.pointHoverBorderColor = ColorTranslator.ToHtml(BorderColor.Value);
            if (FillColor is not null)
                opt.pointHoverBackgroundColor = ColorTranslator.ToHtml(FillColor.Value);
            if (BorderWidth is not null)
                opt.pointHoverBorderWidth = BorderWidth;
            if (BorderRadius is not null)
                opt.pointHoverRadius = BorderRadius;
        }

        /// <summary>
        /// Method destinated to add to <see cref="BarDataset{T}"/>
        /// </summary>
        /// <param name="opt"></param>
        internal void AppendBarInteractions(ref dynamic opt)
        {
            if (BorderColor is not null)
                opt.hoverBorderColor = ColorTranslator.ToHtml(BorderColor.Value);
            if (FillColor is not null)
                opt.hoverBackgroundColor = ColorTranslator.ToHtml(FillColor.Value);
            if (BorderWidth is not null)
                opt.hoverBorderWidth = BorderWidth;
            if (BorderRadius is not null)
                opt.hoverRadius = BorderRadius;
        }
    }
}
