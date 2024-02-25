using Beporsoft.Blazor.Charts.Interop;
using Microsoft.Extensions.Logging;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts
{
    public class ChartJsInterop
    {
        private readonly IJSRuntime _js;
        private readonly ILogger<ChartJsInterop>? _logger;
        private IJSObjectReference? _module;

        public ChartJsInterop(IJSRuntime js, ILogger<ChartJsInterop>? logger)
        {
            _js = js;
            _logger = logger;
        }

        public async Task RenderChart(Chart chart)
        {

            var module = await GetModule();

            if (chart.Config is null)
                throw ChartExceptionFactory.CreateMissingConfiguration(chart.ChartId);

            dynamic cfg = chart.Config.ToChartObject();

            if (chart.Data is null)
                _logger?.LogWarning("Chart {chartId} rendered without data", chart.ChartId);
            else
                cfg.data = chart.Data.ToChartObject();

            await module.InvokeVoidAsync(InteropMethods.ActivateChart, chart.ChartId, (object)cfg);

        }


        private async Task<IJSObjectReference> GetModule()
        {
            if (_module is null)
            {
                _module = await _js.InvokeAsync<IJSObjectReference>(InteropStrings.Import, InteropStrings.ScriptPath);
            }

            return _module;
        }


        private static class InteropStrings
        {
            public static string Import { get; } = "import";
            public static string ScriptPath { get; } = "./_content/Beporsoft.Blazor.Charts/js/chartJsInterop.js";

            public static class Methods
            {
                public static readonly string ActivateChart = "activateChart";
            }

        }
    }
}
