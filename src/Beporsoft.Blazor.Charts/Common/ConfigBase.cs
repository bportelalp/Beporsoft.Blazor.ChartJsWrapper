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

        /// <summary>
        /// The main axis used as abscisa axis, commonly x-axis. You can change this value for example to draw an horizontal
        /// bar chart.
        /// </summary>
        public string? MainAxis { get; set; }

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
            obj.options = BuildOptionsNode();

            return obj;
        }

        private object BuildOptionsNode()
        {
            dynamic opt = new ExpandoObject();
            opt.plugins = Options.ToChartObject();
            opt.responsive = Responsive;
            opt.maintainAspectRatio = MaintainAspectRatio;
            AppendScales(ref opt);

            if (Locale is not null)
                opt.locale = Locale.Name;
            if (MainAxis is not null)
                opt.indexAxis = "y";

            return opt;
        }

        private void AppendScales(ref dynamic options)
        {
            if (Axes?.Any() is true)
            {
                var scales = new ExpandoObject() as IDictionary<string, object>;
                foreach (var axis in Axes)
                {
                    scales[axis.Key] = axis.Value.ToChartObject();
                }
                options.scales = scales;
            }
        }
    }
}
