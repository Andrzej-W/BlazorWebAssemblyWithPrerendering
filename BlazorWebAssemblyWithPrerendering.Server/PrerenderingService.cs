using BlazorWebAssemblyWithPrerendering.Shared;

namespace BlazorWebAssemblyWithPrerendering.Server
{
    public class PrerenderingService : IPrerenderingService
    {
        public bool IsPrerendering => true;
    }
}
