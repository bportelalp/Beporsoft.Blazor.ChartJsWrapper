using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Common
{
   public class PointStyle : StringEnumClass
    {
        private PointStyle(string name) : base(name) { }

        public static PointStyle Circle { get; } = new PointStyle("circle");
        public static PointStyle Cross { get; } = new PointStyle("cross");
        public static PointStyle CrossRot { get; } = new PointStyle("crossRot");
        public static PointStyle Dash { get; } = new PointStyle("dash");
        public static PointStyle Line { get; } = new PointStyle("line");
        public static PointStyle Rect { get; } = new PointStyle("rect");
        public static PointStyle RectRounded { get; } = new PointStyle("rectRounded");
        public static PointStyle Star { get; } = new PointStyle("star");
        public static PointStyle Triangle { get; } = new PointStyle("triangle");
    }
}
