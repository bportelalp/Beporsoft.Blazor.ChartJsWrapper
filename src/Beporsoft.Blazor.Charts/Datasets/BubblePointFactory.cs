using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Datasets
{
    public class BubblePointFactory
    {
        public BubblePointFactory(double scaleZ)
        {
            ScaleZ = scaleZ;
        }

        public double ScaleZ { get; }



    }
}
