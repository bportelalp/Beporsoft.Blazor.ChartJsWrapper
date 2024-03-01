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

    public static class TitleOptionsExtensions {

        /// <summary>
        /// Configures the location of the title.
        /// </summary>
        /// <param name="options"></param>
        /// <param name="position"></param>
        /// <returns>The same options instance so that multiple calls can be chained</returns>
        public static TitleOptions LocatedOn(this TitleOptions options, Position position)
        {
            options.Position = position;
            return options;
        }

        /// <summary>
        /// Configures the alignment of the title around its position.
        /// </summary>
        /// <param name="options"></param>
        /// <param name="align"></param>
        /// <returns>The same options instance so that multiple calls can be chained</returns>
        public static TitleOptions AlignedAt(this TitleOptions options, Align align)
        {
            options.Align = align;
            return options;
        }


        /// <summary>
        /// Sets the position of the title around the chart and the alignment.
        /// </summary>
        /// <param name="position"></param>
        /// <param name="align"></param>
        /// <returns></returns>
        public static TitleOptions WithLocation(this TitleOptions options, Position position, Align align)
        {
            options.Position = position;
            options.Align = align;
            return options;
        }

        /// <summary>
        /// <inheritdoc cref="WithFont(TitleOptions, int, string)"/>
        /// </summary>
        /// <param name="options"></param>
        /// <param name="fontSize"></param>
        /// <returns>The created <see cref="FontOptions"/> to further configure the font.</returns>
        public static FontOptions WithFont(this TitleOptions options, int fontSize) => options.WithFont(fontSize, null!);

        /// <summary>
        /// Adds font options to the title.
        /// </summary>
        /// <param name="options"></param>
        /// <param name="fontSize"></param>
        /// <param name="fontFamily"></param>
        /// <returns>The created <see cref="FontOptions"/> to further configure the font.</returns>
        public static FontOptions WithFont(this TitleOptions options, int fontSize, string fontFamily)
        {
            options.Font = new FontOptions(fontSize)
            {
                FontFamily = fontFamily
            };
            return options.Font;
        }
    }
}
