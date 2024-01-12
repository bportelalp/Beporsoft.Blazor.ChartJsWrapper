using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Datasets
{
    public class DateTimeAxisDataset : List<DateTime>, IMainAxisDataset
    {
        List<object> IMainAxisDataset.GetLabels()
        {
            return this.Select(i => (object)i).ToList();
        }
    }
}
