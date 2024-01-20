using Microsoft.JSInterop;

namespace BlazorDemos.LifecycleDemos
{
    public static class Extensions
    {
        public static bool IsPreRendering(this IJSRuntime runtime)
        {
            // The peculiar thing in prerender is that Blazor circuit isn't yet created, so we can't use JSInterop
            return !(bool)runtime.GetType().GetProperty("IsInitialized").GetValue(runtime);
        }
    }
}
