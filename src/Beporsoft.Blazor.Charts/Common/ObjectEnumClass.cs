using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Common
{
    public class ObjectEnumClass
    {
        protected ObjectEnumClass(object value)
        {
            Value = value;
        }
        public object Value { get; set; }

        public override string ToString()
        {
            return Value.ToString()!;
        }

    }
}
