using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Common
{
    public class StringEnumClass
    {
        protected StringEnumClass(string value)
        {
            Value = value;
        }
        public string Value { get; set; }

        public override string ToString()
        {
            return Value;
        }

    }
}
