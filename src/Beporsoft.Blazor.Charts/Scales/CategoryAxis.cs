using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Scales
{
    /// <summary>
    /// A case of <see cref="CartesianAxis"/> whose values are considered as discrete values.
    /// </summary>
    public class CategoryAxis : CartesianAxis
    {
        public CategoryAxis(string axisId, ScaleType scaleType) : base(axisId, scaleType)
        {
        }
    }
}
