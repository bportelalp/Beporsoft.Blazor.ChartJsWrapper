using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Scales
{
    public class Axis
    {
        public Axis(string axisId)
        {
            Id = axisId;
        }

        public string Id { get; set; }

        public bool Stacked { get; set; }

        public AxisGrid? Grid { get; set; }

        #region Fluent methods
        public virtual Axis SetStacked()
        {
            Stacked = true;
            return this;
        }
        #endregion

        internal virtual object ToChartObject()
        {
            dynamic obj = new ExpandoObject();
            obj.stacked = Stacked;
            if(Grid is not null)
                obj.grid = Grid.ToChartObject();
            return obj;
        }
    }
}
