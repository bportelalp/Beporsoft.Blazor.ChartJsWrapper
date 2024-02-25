using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Datasets
{
    public class BubblePoint<Tx, Ty, Tz>
    {

        public BubblePoint(Tx x, Ty y, Tz z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public BubblePoint(Tx x, Ty y, Tz z, Func<Tz, Tz> bubbleRadiusConverter) : this(x, y, z)
        {
            BubbleRadiusConverter = bubbleRadiusConverter;
        }



        /// <summary>
        /// The x coordinate.
        /// </summary>
        public Tx X { get; set; }

        /// <summary>
        /// The y coordinate.
        /// </summary>
        public Ty Y { get; set; }

        /// <summary>
        /// The z coordinate. The real bubble size is represented by <see cref="R"/>, which can have the same value or a converted value.
        /// </summary>
        [JsonIgnore]
        public Tz Z { get; set; }

        /// <summary>
        /// The real bubble size, calculated from <see cref="Z"/> with the <see cref="BubbleRadiusConverter"/>
        /// </summary>
        [JsonIgnore]
        public Tz R => BubbleRadiusConverter.Invoke(Z);

        /// <summary>
        /// The converter between <see cref="Z"/> and <see cref="R"/>. Default is <see cref="DefaultBubbleRadiusConverter"/>
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
