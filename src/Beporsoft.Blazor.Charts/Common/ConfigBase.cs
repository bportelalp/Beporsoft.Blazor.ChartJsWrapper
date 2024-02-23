using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Beporsoft.Blazor.Charts.Configuration;
using Beporsoft.Blazor.Charts.Scales;

namespace Beporsoft.Blazor.Charts.Common
{
    public class ConfigBase : IChartJsObject
    {

        public ChartType Type { get; set; } = ChartType.Bar;


        public bool Responsive { get; set; } = true;

        internal bool MaintainAspectRatio { get; } = true;

        public  CultureInfo?  Locale { get; set; }

        public Options Options { get; set; } = new();

        public Dictionary<string,Axis>? Axes { get; set; }

        #region Fluent methods
        public CartesianAxis AddLinearAxis(string axisId) => AddCartesianAxis(axisId, ScaleType.Linear);
        public CartesianAxis AddLogarithmicAxis(string axisId) => AddCartesianAxis(axisId, ScaleType.Logarithmic);
        public CartesianAxis AddCartesianAxis(string axisId, ScaleType scaleType)
        {
            Axes ??= new Dictionary<string,Axis>();

            CartesianAxis axis = new(axisId, scaleType);
            Axes.Add(axisId, axis);
            return axis;
        }
        #endregion

        public virtual object ToChartObject()
        {
            dynamic obj = new ExpandoObject();
            obj.type = Type.Value;
            obj.options = new ExpandoObject();
            obj.options.plugins = Options.ToChartObject();
            obj.options.responsive = Responsive;
            obj.options.maintainAspectRatio = MaintainAspectRatio;

            if(Axes?.Any() is true)
            {
                var scales = new ExpandoObject() as IDictionary<string, object>;
                foreach(var axis in Axes)
                {
                    scales[axis.Key] = axis.Value.ToChartObject();
                }
                obj.options.scales = scales;
            }

            if (Locale is not null)
                obj.options.locale = Locale.Name;

            return obj;
        }
    }
}
