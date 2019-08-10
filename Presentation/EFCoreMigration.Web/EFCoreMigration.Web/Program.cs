using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace EFCoreMigration.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region decompile result
            //WebHostExtensions.Run(Program.CreateWebHostBuilder(args).Build());
            #endregion
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();

        #region decompile result 
        /// <summary>
        /// 使用WebHostBuilderExtensions的扩展方法
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        //public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        //{
        //    return WebHostBuilderExtensions.UseStartup<Startup>(WebHost.CreateDefaultBuilder(args));
        //}
        #endregion
    }
}
