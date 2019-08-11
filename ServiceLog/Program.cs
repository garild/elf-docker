using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using NLog;
using NLog.Web;
//using Serilog;
//using Serilog.Sinks.Elasticsearch;
//using System;

namespace ServiceLog
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseNLog();

                // SERILOG 
                //.UseSerilog((context, config) =>
                //{
                //    var elasticUri = context.Configuration["ElasticSearchUri"]; // this should be add in EVN_VARIABLES

                //    config.Enrich.FromLogContext()
                //    .WriteTo.Elasticsearch(new ElasticsearchSinkOptions(new Uri(elasticUri))
                //    {
                //        AutoRegisterTemplate = true,
                //    });
                //});

        }
    }
}
