using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorWebAssemblyWithPrerendering.Shared
{
    public interface IPrerenderingService
    {
        // Alternative to: RuntimeInformation.IsOSPlatform(OSPlatform.Create("WEBASSEMBLY"))
        bool IsPrerendering { get; }
    }
}