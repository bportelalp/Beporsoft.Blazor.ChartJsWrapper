using Beporsoft.Blazor.Charts.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Configuration
{
    /// <summary>
    /// Determines the shape used to draw the end points of lines.
    /// </summary>
    public class CapStyle : StringEnumClass
    {
        protected CapStyle(string value) : base(value)
        {
        }

        /// <summary>
        /// The ends of lines are squared of at the endpoints
        /// </summary>
        public static CapStyle Butt { get; } = new CapStyle("butt");

        /// <summary>
        /// The ends of lines are rounded.
        /// </summary>
        public static CapStyle Round { get; } = new CapStyle("round");

        /// <summary>
        /// The end of lines are squared off by adding a box with an equal width and half the height of the line's thickness.
        /// </summary>
        public static CapStyle Square { get; } = new CapStyle("square");
    }
}
