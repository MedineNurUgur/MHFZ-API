using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Solution.MhfzDB.MvcWebUI.Middlewares
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseNodeModules(this IApplicationBuilder app,string root)
        {
            var path = Path.Combine(root, "node_modules");
            var provider = new PhysicalFileProvider(path);

            var options = new StaticFileOptions();
            options.RequestPath = "/node_modules";
            options.FileProvider = provider;

            app.UseStaticFiles(options);

            return app;
        }
    }
}
/*<link href = "/node_modules/bootstrap/dist/css/bootstrap.css" rel="stylesheet"/>
    <script src = "/node_modules/jquery/dist/jquery.min.js" ></ script >
    < script src="/node_modules/bootstrap/dist/js/bootstrap.js"></script> */