using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Common
{
    public class Title
    {
        public Title(string text)
        {
            Text = text;
        }


        public string Text { get; } = string.Empty;

        public Align Align { get; set; } = Align.Center;

        [JsonProperty]
        internal bool Display { get; } = true;

        public Color Color { get; set; }
    }
}
