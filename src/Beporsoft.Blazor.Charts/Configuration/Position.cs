using Beporsoft.Blazor.Charts.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Configuration
{
    /// <summary>
    /// Specifies one location around a chart.
    /// </summary>
    public class Position : StringEnumClass
    {
        private Position(string value) : base(value)
        {
            Value = value;
        }

        /// <summary>
        /// Over the chart.
        /// </summary>
        public static Position Top { get; } = new Position("top");

        /// <summary>
        /// Under the chart.
        /// </summary>
        public static Position Bottom { get; } = new Position("bottom");

        /// <summary>
        /// At left hand.
        /// </summary>
        public static Position Left { get; } = new Position("left");

        /// <summary>
        /// At right hand.
        /// </summary>
        public static Position Right { get; } = new Position("right");


    }
}
