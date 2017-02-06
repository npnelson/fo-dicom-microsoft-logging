# fo-dicom-microsoft-logging
Microsoft.Extensions.Logging Adapter for fo-dicom

**Usage (note you must use the Microsoft.Extensions.Logging namespace to get access to the InterceptDICOMLogging extension method**
```cs
var lf = new LoggerFactory();         
    lf.InterceptDICOMLogging(); 
```
or in case of using Startup.cs like Asp.Net core (note the only thing you need to do is call InterceptDICOMLogging() on your loggerfactory, the rest of the configure code is there for context

```
 public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)

        {

            app.UseDeveloperExceptionPage();

            app.UseStaticFiles();

            loggerFactory

                .AddConsole()

                .InterceptDICOMLogging();

            app.UseMvc(routes =>

            {

                routes.MapRoute(

                    name: "default",

                    template: "{controller=Home}/{action=Index}/{id?}");

            });

        }
```        
