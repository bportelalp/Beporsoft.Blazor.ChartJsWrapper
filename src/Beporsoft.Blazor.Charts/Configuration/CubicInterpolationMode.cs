using Beporsoft.Blazor.Charts.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Configuration
{
    /// <summary>
    /// Interpolation mode for line drawing.
    /// </summary>
    public class CubicInterpolationMode : StringEnumClass
    {
        protected CubicInterpolationMode(string value) : base(value)
        {
        }

        /// <summary>
        /// Produces pleasant curves.
        /// </summary>
        public static CubicInterpolationMode Default { get; } = new CubicInterpolationMode("default");

        /// <summary>
        /// Preserves monotonicity of the interpolated dataset, suited to the following function:
        /// <code>y = f(x)</code>
        /// </summary>
        public static CubicInterpolationMode Monotone { get; } = new CubicInterpolationMode("monotone");

    }
}
