using Beporsoft.Blazor.Charts.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Cartesian
{
    /// <summary>
    /// Represent a dataset whose values can be represented in a cartesian system.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CartesianDataset<T> : Dataset<T>
    {
        public CartesianDataset(ChartType type) : base(type)
        {
        }
    }
}
