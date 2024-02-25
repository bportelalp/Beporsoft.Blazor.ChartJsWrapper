using Beporsoft.Blazor.Charts.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Configuration
{
    public class Position : StringEnumClass
    {
        private Position(string value) : base(value)
        {
            Value = value;
        }

        public static Position Top { get; } = new Position("top");
        public static Position Bottom { get; } = new Position("bottom");
        public static Position Left { get; } = new Position("left");
        public static Position Right { get; } = new Position("right");


    }
}
