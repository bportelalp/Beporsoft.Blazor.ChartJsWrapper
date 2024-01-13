using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Datasets
{
    public class NumberAxisDataset<T> : List<T>, IMainAxisDataset
        where T : struct, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
    {
        public NumberAxisDataset(IEnumerable<T> data)
        {
            this.AddRange(data);
        }

        List<object> IMainAxisDataset.GetLabels()
        {
            return this.Select(i => (object)i).ToList();
        }
    }
}
