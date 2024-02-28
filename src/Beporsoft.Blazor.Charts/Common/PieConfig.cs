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
using Beporsoft.Blazor.Charts.Datasets;
using Beporsoft.Blazor.Charts.Scales;

namespace Beporsoft.Blazor.Charts.Common
{
    public class PieConfig : ConfigBase
    {
        public PieConfig(PolarChartType type)
        {
            Type = type;
        }
    }
}
