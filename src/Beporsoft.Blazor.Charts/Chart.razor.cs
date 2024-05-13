using Beporsoft.Blazor.Charts.Common;
using Microsoft.AspNetCore.Components;

namespace Beporsoft.Blazor.Charts
{
    public partial class Chart : ComponentBase, IDisposable
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
        public async void Dispose()
        {
            await ChartInterop.DisposeChart(this);
        }
        #endregion

        #region Methods
        public async Task Render()
        {
            await ChartInterop.RenderChart(this);
        }

        #endregion

        #region UI Handlers
        #endregion

    }
}
