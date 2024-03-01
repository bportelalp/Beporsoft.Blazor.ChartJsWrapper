using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Datasets
{
    /// <summary>
    /// Represent a <see cref="DataPoint{Tx, Ty}"/> with the third-dimension value to be used with the
    /// <see cref="BubbleDataset{Tx, Ty, Tz}"/>.
    /// <para>
    /// The third dimension is represented as pixels value of the bubble, so it can be provided a converter from the 
    /// real value to the pixels value.
    /// </para>
    /// </summary>
    /// <typeparam name="Tx"></typeparam>
    /// <typeparam name="Ty"></typeparam>
    /// <typeparam name="Tz"></typeparam>
    public class BubblePoint<Tx, Ty, Tz> : DataPoint<Tx, Ty>
    {

        public BubblePoint(Tx x, Ty y, Tz z) : base(x, y)
        {
            Z = z;
        }

        public BubblePoint(Tx x, Ty y, Tz z, Func<Tz, Tz> bubbleRadiusConverter) : this(x, y, z)
        {
            BubbleRadiusConverter = bubbleRadiusConverter;
        }

        /// <summary>
        /// The z coordinate. The real bubble size is represented by <see cref="R"/>, which can have the same value or a converted value.
        /// </summary>
        [JsonIgnore]
        public Tz Z { get; set; }

        /// <summary>
        /// The real bubble size, calculated from <see cref="Z"/> with the <see cref="BubbleRadiusConverter"/>
        /// </summary>
        public Tz R => BubbleRadiusConverter.Invoke(Z);

        /// <summary>
        /// The converter between <see cref="Z"/> and <see cref="R"/>. Default is <see cref="DefaultBubbleRadiusConverter"/>
        [JsonIgnore]
        /// </summary>
        public Func<Tz, Tz> BubbleRadiusConverter { get; set; } = DefaultBubbleRadiusConverter;

        [JsonIgnore]
        internal static Func<Tz, Tz> DefaultBubbleRadiusConverter { get; } = (Tz z) => z;

    }

    public class BubblePoint<Txy, Tz> : BubblePoint<Txy, Txy, Tz>
    {
        public BubblePoint(Txy x, Txy y, Tz z) : base(x, y, z)
        {
        }
        public BubblePoint(Txy x, Txy y, Tz z, Func<Tz, Tz> bubbleRadiusConverter) : base(x, y, z, bubbleRadiusConverter)
        {
        }
    }

    public class BubblePoint<Txyz> : BubblePoint<Txyz, Txyz, Txyz>
    {
        public BubblePoint(Txyz x, Txyz y, Txyz z) : base(x, y, z)
        {

        }
        public BubblePoint(Txyz x, Txyz y, Txyz z, Func<Txyz, Txyz> bubbleRadiusConverter) : base(x, y, z, bubbleRadiusConverter)
        {
        }
    }


}
