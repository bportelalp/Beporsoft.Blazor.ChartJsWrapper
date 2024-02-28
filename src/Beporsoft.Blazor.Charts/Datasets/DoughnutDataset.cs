using Beporsoft.Blazor.Charts.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Datasets
{    /// <summary>
     /// Represent a <see cref="PolarDataset{T}"/> which is initialized as <see cref="PolarChartType.Doughnut"/>
     /// with the possibility of edit the internal hole of the doughnut.
     /// </summary>
     /// <typeparam name="T"></typeparam>
    public class DoughnutDataset<T> : PolarDataset<T>
    {
        public DoughnutDataset() : base(PolarChartType.Doughnut)
        {
        }
        public DoughnutDataset(IEnumerable<T> data) : this()
        {
            this.AddRange(data);
        }

        public DoughnutDataset(string title, IEnumerable<T> data) : this(data)
        {
            Label = title;
        }

        /// <summary>
        /// The portion of the chart that is cut out of the middle, from 0 to 1.
        /// </summary>
        public double? CutoutPercentage { get; set; }

        protected override dynamic BuildJsObject()
        {
            dynamic obj = base.BuildJsObject();
            if (CutoutPercentage is not null)
                obj.cutout = $"{NumberHelpers.AdjustInterval(CutoutPercentage.Value, 0, 1) * 100.0}%";
            return obj;
        }
    }


    public static class DoughnutDatasetExtensions
    {
        public static DoughnutDataset<T> SetCutout<T>(this DoughnutDataset<T> dataset, double? cutoutPercentage)
        {
            dataset.CutoutPercentage = cutoutPercentage;
            return dataset;
        }
    }

}
