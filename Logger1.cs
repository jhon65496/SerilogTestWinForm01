using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;
using Serilog.Events;
using Serilog.Formatting.Json;

namespace SerilogTestWinForm01
{
    internal class Logger1
    {
        public void CreateLogger()
        {
            Log.Logger = new LoggerConfiguration()
                            // add console as logging target
                            .WriteTo.Console(
                                            outputTemplate: "{UtcTimestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}") // 
                                             
                            // set default minimum level
                            // .Use
                            .MinimumLevel.Debug()
                            .Enrich.With<UtcTimestampEnricher>()
                            .CreateLogger();


            // string message = "`Parametr logging result`";

            // logging                        
               Log.Information("Some `Information`. Parametr logging");
            // Log.Information($"Some `Information`. Parametr logging -- {message}");
            // Log.Information("Some `Information`. Parametr logging -- {message}", message);



            Log.CloseAndFlush();
        }


    }
}
