using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Beporsoft.Blazor.Charts.Common;

namespace Beporsoft.Blazor.Charts.Datasets
{
    /// <summary>
    /// Represent a point valid to <see cref="CartesianDataset{T}"/> where both coordinates are defined on that
    /// object instead of using labels and numbers.
    /// <para>
    /// You can use any <see cref="CartesianDataset{T}"/> where <typeparamref name="T"/> is <see cref="DataPoint{Tx, Ty}"/>. This makes that
    /// x coordinate is defined inside the dataset and it shouldn't be common to other datasets appended to the same chart. In that case, the 
    /// values defined inside <see cref="ChartData.Labels"/> are not taken into account to plot this dataset.
    /// </para>
    /// </summary>
    /// <typeparam name="Tx">The data type for x coordinate. It should be a number type</typeparam>
    /// <typeparam name="Ty">The data type for x coordinate. It should be a number type</typeparam>
    public class DataPoint<Tx, Ty>
    {
        public DataPoint(Tx x, Ty y)
        {

            X = x;
            Y = y;
        }

        /// <summary>
        /// The x coordinate.
        /// </summary>
        public Tx X { get; set; }

        /// <summary>
        /// The y coordinate.
        /// </summary>
        public Ty Y { get; set; }
    }

    /// <summary>
    /// <inheritdoc cref="DataPoint{Tx, Ty}"/>
    /// </summary>
    /// <typeparam name="Txy">The data type for x and y coordinate. It should be a number type</typeparam>
    public class DataPoint<Txy> : DataPoint<Txy, Txy>
    {
        public DataPoint(Txy x, Txy y) : base(x, y)
        {
        }
    }
}
