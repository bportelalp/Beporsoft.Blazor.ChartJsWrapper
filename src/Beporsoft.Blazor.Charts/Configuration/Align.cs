using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Beporsoft.Blazor.Charts.Common;

namespace Beporsoft.Blazor.Charts.Configuration
{
    /// <summary>
    /// Specifies the alignment of a text container.
    /// </summary>
    public class Align : StringEnumClass
    {
        private Align(string value) : base(value) { }

        public static Align Start { get; } = new Align("start");
        public static Align Center { get; } = new Align("center");
        public static Align End { get; } = new Align("end");

    }
}
