using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Web.Extensions
{
    public static class JSExtension
    {
        public static async Task Focus(this ElementReference elementRef, IJSRuntime jsRuntime)
        {
            await jsRuntime.InvokeVoidAsync(
                "poJsFunctions.focusElement", elementRef);
        }

        public static async Task SaveAs(this IJSRuntime jsRuntime, string filename, byte[] data)
        {
            await jsRuntime.InvokeAsync<object>("saveAsFile", filename, Convert.ToBase64String(data));
        }
    }
}
