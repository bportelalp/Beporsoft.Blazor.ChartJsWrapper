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
        public TitleOptions AddTitle(string text)
        {
            Title = new TitleOptions(text);
            return Title;
        }

        public TitleOptions AddSubtitle(string text)
        {
            Subtitle = new TitleOptions(text);
            return Subtitle;
        }

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
