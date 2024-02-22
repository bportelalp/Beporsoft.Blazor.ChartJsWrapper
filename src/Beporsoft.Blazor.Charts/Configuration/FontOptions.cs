using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Configuration
{
    public class FontOptions
    {
        public FontOptions(int size)
        {
            Size = size;
        }
        public int Size { get; set; } = 12;

        /// <summary>
        /// A unique, or comma separated values for alternatives, like "'Helvetica Neue', 'Helvetica', 'Arial', sans-serif".
        /// </summary>
        public string? FontFamily { get; set; }

        internal object ToChartObject()
        {
            dynamic obj = new ExpandoObject();
            obj.size = Size;
            if(!string.IsNullOrWhiteSpace(FontFamily))
                obj.fontFamily = FontFamily;

            return obj;
        }
    }
}
