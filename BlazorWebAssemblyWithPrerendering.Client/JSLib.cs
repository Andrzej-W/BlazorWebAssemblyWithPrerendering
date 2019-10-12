using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebAssemblyWithPrerendering.Client
{
    public static class JSLib
    {

        private static void CheckJS(IJSInProcessRuntime JSInProcessRuntime)
        {
            if (JSInProcessRuntime == null)
                throw new ArgumentNullException(nameof(JSInProcessRuntime));
        }
        public static string GetInnerHtml(this ElementReference elementReference, IJSInProcessRuntime JS)
        {
            CheckJS(JS);
            return JS.Invoke<string>("JSLib.getInnerHtml", elementReference);
        }
        public static string GetInnerHtmlById(IJSInProcessRuntime JS, string id)
        {
            CheckJS(JS);
            if (string.IsNullOrEmpty(id))
                throw new ArgumentNullException(nameof(id));
            return JS.Invoke<string>("JSLib.getInnerHtmlById", id);
        }
        public static string GetOuterHtml(this ElementReference elementReference, IJSInProcessRuntime JS)
        {
            CheckJS(JS);
            return JS.Invoke<string>("JSLib.getOuterHtml", elementReference);
        }
        public static string GetOuterHtmlById(IJSInProcessRuntime JS, string id)
        {
            CheckJS(JS);
            if (string.IsNullOrEmpty(id))
                throw new ArgumentNullException(nameof(id));
            return JS.Invoke<string>("JSLib.getOuterHtmlById", id);
        }
    }
}
