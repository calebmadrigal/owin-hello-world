using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SelfHost.Startup))]

namespace SelfHost
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Run(ctx =>
                {
                    IOwinRequest req = ctx.Request;
                    IOwinResponse res = ctx.Response;
                    var name = req.Query["name"];
                    if (name == null)
                    {
                        return res.WriteAsync("Hello World");
                    }
                    else
                    {
                        return res.WriteAsync("Hello " + name);
                    }
                });
        }
    }
}
