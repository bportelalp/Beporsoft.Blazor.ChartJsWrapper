using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Configuration
{
    public class LegendOptions
    {
        public Position Position { get; set; } = Position.Top;
        public Align Align { get; set; } = Align.Center;

        #region Fluent methods
        public LegendOptions WithLocation(Position position, Align align)
        {
            Position = position;
            Align = align;
            return this;
        }
        #endregion

        internal object ToChartObject()
        {
            dynamic obj = new ExpandoObject();
            obj.position = Position.Value;
            obj.align = Align.Value;

            return obj;
        }
    }
}
