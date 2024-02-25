using Beporsoft.Blazor.Charts.Configuration;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Scales
{
    /// <summary>
    /// The base class used to defined the chart axes.
    /// </summary>
    public class Axis
    {
        public Axis(string axisId, ScaleType scaleType)
        {
            Id = axisId;
            ScaleType = scaleType;
        }

        public string Id { get; set; }

        public ScaleType ScaleType { get; }

        public bool Stacked { get; set; }

        public double? Min { get; set; }
        public double? Max { get; set; }

        public AxisGrid? Grid { get; set; }

        public FontOptions? Font { get; set; }


        #region Fluent methods
        public virtual Axis SetStacked()
        {
            Stacked = true;
            return this;
        }
        public virtual Axis SetRange(double? min, double? max)
        {
            Min = min;
            Max = max;
            return this;
        }

        public virtual FontOptions AddFont(int fontSize)
        {
            Font ??= new FontOptions(fontSize);
            return Font;
        }

        public virtual Axis SetFont(FontOptions font)
        {
            Font = font;
            return this;
        }
        
        #endregion

        internal virtual object ToChartObject()
        {
            dynamic obj = new ExpandoObject();
            obj.type = ScaleType.Value;
            obj.stacked = Stacked;
            if (Grid is not null)
                obj.grid = Grid.ToChartObject();

            if (Min is not null)
                obj.min = Min;
            if (Max is not null)
                obj.max = Max;
            if (Font is not null)
                obj.font = Font.ToChartObject();
            return obj;
        }
    }
}
