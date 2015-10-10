using System;
using System.Net.Http;
using Microsoft.Azure.AppService;

namespace Orneholm.ApplicationInsights.Web
{
    public static class PoAiDemoApiAppServiceExtensions
    {
        public static PoAiDemoApi CreatePoAiDemoApi(this IAppServiceClient client)
        {
            return new PoAiDemoApi(client.CreateHandler());
        }

        public static PoAiDemoApi CreatePoAiDemoApi(this IAppServiceClient client, params DelegatingHandler[] handlers)
        {
            return new PoAiDemoApi(client.CreateHandler(handlers));
        }

        public static PoAiDemoApi CreatePoAiDemoApi(this IAppServiceClient client, Uri uri, params DelegatingHandler[] handlers)
        {
            return new PoAiDemoApi(uri, client.CreateHandler(handlers));
        }

        public static PoAiDemoApi CreatePoAiDemoApi(this IAppServiceClient client, HttpClientHandler rootHandler, params DelegatingHandler[] handlers)
        {
            return new PoAiDemoApi(rootHandler, client.CreateHandler(handlers));
        }
    }
}
