using Beporsoft.Blazor.Charts.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Datasets
{
    public class PolarDataset<T> : Dataset<T>
    {
        public PolarDataset(PolarChartType type) : base(type)
        {
        }

        public PolarDataset(PolarChartType type, IEnumerable<T> data) : this(type)
        {
            this.AddRange(data);
        }

        public PolarDataset(PolarChartType type, string title, IEnumerable<T> data) : this(type, data)
        {
            Label = title;
        }

        /// <summary>
        /// The collection of colors displayed for each pie chart portion. It should have the same
        /// length than <see cref="Dataset{T}.Data"/>.
        /// </summary>
        public ICollection<Color> BackgroundColor { get; set; } = new List<Color>();

        /// <summary>
        /// The collection of colors displayed for each pie chart portion on border. It should have the same
        /// length than <see cref="Dataset{T}.Data"/>.
        /// </summary>
        public ICollection<Color> BorderColor { get;} = new List<Color>();
        public int BorderWidth { get; set; }

        protected override dynamic BuildJsObject()
        {
            dynamic obj = base.BuildJsObject();
            if (BackgroundColor?.Any() is true)
                obj.backgroundColor = BackgroundColor.Select(ColorTranslator.ToHtml).ToArray();
            if(BorderColor?.Any() is true)
                obj.borderColor = BorderColor.Select(ColorTranslator.ToHtml).ToArray();
            return obj;
        }
    }
}
