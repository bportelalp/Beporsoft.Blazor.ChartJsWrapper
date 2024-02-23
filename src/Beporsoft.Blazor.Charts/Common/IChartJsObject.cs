using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Common
{
    public interface IChartJsObject
    {
        /// <summary>
        /// Converts the instance into the equivalent structure of well-known Chart.Js objects.
        /// </summary>
        /// <returns></returns>
        public object ToChartObject();
    }
}
