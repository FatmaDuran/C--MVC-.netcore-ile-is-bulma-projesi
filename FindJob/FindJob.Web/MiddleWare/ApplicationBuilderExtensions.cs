using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.FileProviders;

namespace FindJob.Web.MiddleWare
{
    public static class ApplicationBuilderExtensions ///bunun extesion olması için hem clasın static olması gerekir
    {                                                //hem de classın static olması gerekir
        public static IApplicationBuilder UseNodeModules(this IApplicationBuilder app,string root) //rootun içindeki nodemodules klasorunu arayacak
        {
            var path = Path.Combine(root,"node_modules");
            var provider = new PhysicalFileProvider(path);

            var options = new StaticFileOptions();
            options.RequestPath = "/node_modules";
            options.FileProvider = provider;

            app.UseStaticFiles(options);

            return app;
        }
    }
}
