using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Beporsoft.Blazor.Charts.Common;

namespace Beporsoft.Blazor.Charts.Datasets
{
    public class NumberLabelList<T> : List<T>, ILabelList
        where T : struct, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
    {
        public NumberLabelList(IEnumerable<T> data)
        {
            this.AddRange(data);
        }

        List<object> ILabelList.GetLabels()
        {
            return this.Select(i => (object)i).ToList();
        }
    }
}
