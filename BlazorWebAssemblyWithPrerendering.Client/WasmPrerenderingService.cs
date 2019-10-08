using BlazorWebAssemblyWithPrerendering.Shared;

namespace BlazorWebAssemblyWithPrerendering.Client
{
    public class WasmPrerenderingService : IPrerenderingService
    {
        public bool IsPrerendering => false;
    }
}
