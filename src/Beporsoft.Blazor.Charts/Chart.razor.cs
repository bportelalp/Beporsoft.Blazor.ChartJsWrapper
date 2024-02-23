using Beporsoft.Blazor.Charts.Common;
using Beporsoft.Blazor.Charts.Interop;
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

        #region Injects
        [Inject] ChartJsInterop ChartInterop { get; set; } = null!;
        #endregion

        #region Parameters
        [Parameter] public ChartData? Data { get; set; } = default!;
        [Parameter] public ConfigBase? Config { get; set; } = default!;

        /// <summary>
        /// Allow to render the chart inmediately after the first render.
        /// </summary>
        [Parameter] public bool AllowFirstRender { get; set; } = true;

        public string ChartId {get; } = Guid.NewGuid().ToString();


        #endregion

        #region Privates
        #endregion

        #region Lifecycle
        
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                if(AllowFirstRender)
                    await ChartInterop.RenderChart(this);
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
