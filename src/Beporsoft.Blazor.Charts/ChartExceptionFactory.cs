using Beporsoft.Blazor.Charts.Common;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts
{
    public static class ChartExceptionFactory
    {
        public static ChartConfigurationException ThrowMissingAxisId(IChartDataset dataset, string axisId)
        {
            string name = dataset.Label;
            string message;
            if (!string.IsNullOrWhiteSpace(name))
                message = $"One dataset is pointing axis {axisId}, but axis is not defined on configuration";
            else
                message = $"Dataset {name} is pointing axis {axisId}, but axis is not defined on configuration";
            var exception = new ChartConfigurationException(message);
            return exception;
        }

        public static ChartConfigurationException CreateMissingConfiguration(string chartId)
        {
            var exception = new ChartConfigurationException($"Missing chart configuration for chart {chartId}");
            return exception;
        }
    }
}
