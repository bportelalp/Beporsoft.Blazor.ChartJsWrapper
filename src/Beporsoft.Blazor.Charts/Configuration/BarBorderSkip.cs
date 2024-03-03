using Beporsoft.Blazor.Charts.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Configuration
{
    /// <summary>
    /// Controls the bar border drawing to skip some borders of fill or apply radius, e.g. those which
    /// are near to the axis line.
    /// </summary>
    public class BarBorderSkip : ObjectEnumClass
    {
        protected BarBorderSkip(object value) : base(value)
        {
        }

        /// <summary>
        /// Skip border at the bar start.
        /// </summary>
        public static BarBorderSkip Start { get; } = new BarBorderSkip("start");

        /// <summary>
        /// Skip border at the bar end.
        /// </summary>
        public static BarBorderSkip End { get; } = new BarBorderSkip("end");

        /// <summary>
        /// When stacked bars, skip borders between bars.
        /// </summary>
        public static BarBorderSkip Middle { get; } = new BarBorderSkip("middle");

        /// <summary>
        /// Skip border at top.
        /// </summary>
        public static BarBorderSkip Top { get; } = new BarBorderSkip("start");

        /// <summary>
        /// Skip border at bottom.
        /// </summary>
        public static BarBorderSkip Bottom { get; } = new BarBorderSkip("start");

        /// <summary>
        /// Skip border at left.
        /// </summary>
        public static BarBorderSkip Left { get; } = new BarBorderSkip("start");

        /// <summary>
        /// Skip border at right.
        /// </summary>
        public static BarBorderSkip Right { get; } = new BarBorderSkip("start");

        /// <summary>
        /// Don't skip any border.
        /// </summary>
        public static BarBorderSkip Nothing { get; } = new BarBorderSkip(false);

        /// <summary>
        /// Skip all borders.
        /// </summary>
        public static BarBorderSkip All { get; } = new BarBorderSkip(true);
    }
}
