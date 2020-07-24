using Microsoft.AspNetCore.Components;
using EDI2020.Services;

namespace EDI2020.Shared
{
    public class ChildComponentBase : ComponentBase
    {
        protected bool DarkThemeOn;

        [Inject]
        protected RandomService RandomService { get; set; }

        protected string AlertTheme => DarkThemeOn ? "dark" : "light";

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        protected override void OnInitialized()
        {
            DarkThemeOn = true;
        }
    }
}