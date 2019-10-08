using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorWebAssemblyWithPrerendering.Shared
{
    public interface IPrerenderingService
    {
        bool IsPrerendering { get; }
    }
}