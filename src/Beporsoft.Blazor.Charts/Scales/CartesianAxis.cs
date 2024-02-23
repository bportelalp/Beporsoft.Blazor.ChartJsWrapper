using Beporsoft.Blazor.Charts.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Scales
{
    public class CartesianAxis : Axis
    {
        public CartesianAxis(string axisId, ScaleType scaleType) : base(axisId, scaleType)
        {

        }

        public TitleOptions? Title { get; set; }
        public Position? Position { get; set; }

        #region Fluent methods
        public TitleOptions AddTitle(string title)
        {
            Title = new TitleOptions(title);
            return Title;
        }

        public override CartesianAxis SetStacked()
        {
            base.SetStacked();
            return this;
        }

        public CartesianAxis SetPosition(Position position)
        {
            Position = position;
            return this;
        }

        public override CartesianAxis SetRange(double? min, double? max)
        {
            base.SetRange(min, max);
            return this;
        }

        public override FontOptions AddFont(int fontSize) => base.AddFont(fontSize);

        public override CartesianAxis SetFont(FontOptions font)
        {
            base.SetFont(font);
            return this;
        }
        #endregion

        internal override object ToChartObject()
        {
            dynamic obj = base.ToChartObject();

            if (Position is not null)
                obj.position = Position.Value;
            if (Title is not null)
                obj.title = Title.ToChartObject();

            return obj;
        }
    }
}
