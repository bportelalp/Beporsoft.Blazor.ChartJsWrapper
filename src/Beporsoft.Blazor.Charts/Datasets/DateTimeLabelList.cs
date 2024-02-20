using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Beporsoft.Blazor.Charts.Common;

namespace Beporsoft.Blazor.Charts.Datasets
{
    public class DateTimeLabelList : List<DateTime>, ILabelList
    {
        List<object> ILabelList.GetLabels()
        {
            return this.Select(i => (object)i).ToList();
        }
    }
}
