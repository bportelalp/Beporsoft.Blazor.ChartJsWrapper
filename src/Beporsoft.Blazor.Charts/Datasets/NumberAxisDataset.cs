using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Beporsoft.Blazor.Charts.Common;

namespace Beporsoft.Blazor.Charts.Datasets
{
    public class NumberAxisDataset<T> : List<T>, IAxisLabels
        where T : struct, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
    {
        public NumberAxisDataset(IEnumerable<T> data)
        {
            this.AddRange(data);
        }

        List<object> IAxisLabels.GetLabels()
        {
            return this.Select(i => (object)i).ToList();
        }
    }
}
