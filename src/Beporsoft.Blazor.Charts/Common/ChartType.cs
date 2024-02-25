using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Common
{
    public abstract class ChartType : StringEnumClass
    {
        protected ChartType(string value) : base(value)
        {
        }
    }
}
