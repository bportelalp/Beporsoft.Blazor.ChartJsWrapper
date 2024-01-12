using Beporsoft.Blazor.Charts.Interop;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
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
        private IJSObjectReference? _module;

        public ChartJsInterop(IJSRuntime js)
        {
            _js = js;
        }



        public async Task RenderChart(Chart chart)
        {
            var module = await GetModule();

            await module.InvokeVoidAsync(InteropMethods.ActivateChart, chart.ChartId);

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
