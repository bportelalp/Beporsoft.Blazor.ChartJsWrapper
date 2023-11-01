using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Beporsoft.Blazor.Charts
{
    public partial class Chart : ComponentBase
    {
        private const string _jsImport = "import";
        private const string _jsPath = "./_content/Beporsoft.Blazor.Charts/js/chartJsInterop.js";
        private readonly string _chartId = Guid.NewGuid().ToString();

        #region Injects
        [Inject] IJSRuntime Js { get; set; } = null!;
        #endregion

        #region Parameters
        #endregion

        #region Privates
        private IJSObjectReference? _chartLibrary;
        #endregion

        #region Lifecycle
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                _chartLibrary = await Js.InvokeAsync<IJSObjectReference>(_jsImport, _jsPath);

                await _chartLibrary.InvokeVoidAsync(ChartInteropMethods.ActivateChart, _chartId);
            }
        }
        #endregion

        #region Interface
        #endregion

        #region Methods
        #endregion

        #region UI Handlers
        #endregion

    }
}
