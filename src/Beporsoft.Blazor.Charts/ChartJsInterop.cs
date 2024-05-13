using Microsoft.Extensions.Logging;
using Microsoft.JSInterop;

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

            await module.InvokeVoidAsync(InteropConstants.Methods.ActivateChart, chart.ChartId, (object)cfg);

        }

        public async Task DisposeChart(Chart chart)
        {
            var module = await GetModule();

            await module.InvokeVoidAsync(InteropConstants.Methods.DisposeChart, chart.ChartId);
        }


        private async Task<IJSObjectReference> GetModule()
        {
            if (_module is null)
            {
                _module = await _js.InvokeAsync<IJSObjectReference>(InteropConstants.Import, InteropConstants.ScriptPath);
            }

            return _module;
        }


        private static class InteropConstants
        {
            public const string Import = "import";
            public const string ScriptPath = "./_content/Beporsoft.Blazor.Charts/js/chartJsInterop.js";

            public static class Methods
            {
                public const string ActivateChart = "activateChart";
                public const string DisposeChart = "disposeChart";
            }

        }
    }
}
