using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProxyTester
{
    public class ProxyConfig
    {
        public static void SetGlobalProxy()
        {
            var proxyAddress = Environment.GetEnvironmentVariable("PROXY_ADDRESS");
            var bypassProxyAddresses = Environment.GetEnvironmentVariable("BYPASS_PROXY_ADDRESSES");

            var webProxy = new System.Net.WebProxy(proxyAddress);

            webProxy.BypassArrayList.AddRange(bypassProxyAddresses.Split(','));
            webProxy.BypassProxyOnLocal = true;

            System.Net.WebRequest.DefaultWebProxy = webProxy;

        }
    }
}