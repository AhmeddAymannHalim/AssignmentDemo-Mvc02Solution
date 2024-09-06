using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentDemo_Mvc02
{
    public class Program
    {
        
        public static void Main()
        {
            var builder = WebApplication.CreateBuilder();

            builder.Services.AddControllers();
            builder.Services.AddControllersWithViews();
            var app = builder.Build();



            // builder.Services.AddControllersWithViews();
            // builder.Services.AddRazorPages();
            // builder.Services.AddMvc();



           
 #region Configure-Services
             if (app.Environment.IsDevelopment())
             {
                 app.UseDeveloperExceptionPage();//Middleware
             }
             else
             {
                 app.UseStatusCodePagesWithReExecute("/Home/Error");
             }

            #endregion

            app.UseRouting();

            app.UseStaticFiles();
             //app.MapGet("/", () => "Hello World!");
            app.MapGet("/XX{id}", async (context) => await context.Response.WriteAsync($"Id = {context.Request.RouteValues["id"]}"));

           

            


             app.MapControllerRoute(
                 name: "default",                                         //alpha = String
                 pattern /*UrlPath*/: "{controller=Home}/{action=Index}/{id:int?}"
                //defaults : new { controller  ="Movies", action = "Index"};
                //constraints:new {id = new IntRouteConstraint()}


                );
            app.Run();
        }

        
    }
}
