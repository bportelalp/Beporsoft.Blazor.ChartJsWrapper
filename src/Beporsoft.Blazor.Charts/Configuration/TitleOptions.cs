using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Configuration
{
    public class TitleOptions
    {
        public TitleOptions(string text)
        {
            Text = text;
        }


        public string Text { get; } = string.Empty;

        /// <summary>
        /// Gets or sets the position of the title around the chart.
        /// </summary>
        public Position Position { get; set; } = Position.Top;

        /// <summary>
        /// Gets or sets the alignment of the title.
        /// </summary>
        public Align Align { get; set; } = Align.Center;

        public FontOptions? Font { get; set; }


        #region Fluent methods
        /// <summary>
        /// Sets the position of the title around the chart and the alignment.
        /// </summary>
        /// <param name="position"></param>
        /// <param name="align"></param>
        /// <returns></returns>
        public TitleOptions WithLocation(Position position, Align align)
        {
            this.Position = position;
            this.Align = align;
            return this;
        }

        public TitleOptions WithFont(int fontSize) => WithFont(fontSize, null!);

        public TitleOptions WithFont(int fontSize, string fontFamily)
        {
            Font = new FontOptions(fontSize);
            Font.FontFamily = fontFamily;
            return this;
        }
        #endregion

        internal object ToChartObject()
        {
            dynamic obj = new ExpandoObject();
            obj.display = true;
            obj.position = Position.Value;
            obj.align = Align.Value;
            obj.text = Text;

            if (Font is not null)
                obj.font = Font.ToChartObject();

            return obj;
        }
    }
}
