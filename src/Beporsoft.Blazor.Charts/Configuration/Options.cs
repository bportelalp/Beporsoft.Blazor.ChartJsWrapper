using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Configuration
{
    public class Options
    {

        public LegendOptions? Legend { get; set; }

        public TitleOptions? Title { get; set; }

        public TitleOptions? Subtitle { get; set; }


        #region Fluent methods
        /// <summary>
        /// Add a title to chart initialized with the given text.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public TitleOptions AddTitle(string text)
        {
            Title = new TitleOptions(text);
            return Title;
        }

        /// <summary>
        /// Adds a subtitle initialized with the given text.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public TitleOptions AddSubtitle(string text)
        {
            Subtitle = new TitleOptions(text);
            return Subtitle;
        }

        /// <summary>
        /// Adds a <see cref="LegendOptions"/> to the chart, starting its configuration on the following calls.
        /// </summary>
        /// <returns>The <see cref="LegendOptions"/> appended, so multiple calls can be chained.</returns>
        public LegendOptions ConfigureLegend()
        {
            Legend = new LegendOptions();
            return Legend;
        }
        #endregion

        internal object ToChartObject()
        {
            dynamic obj = new ExpandoObject();
            if(Legend is not null)
                obj.legend = Legend.ToChartObject();
            if (Title is not null)
                obj.title = Title.ToChartObject();
            if (Subtitle is not null)
                obj.subtitle = Subtitle.ToChartObject();

            return obj;
        }

    }
}
