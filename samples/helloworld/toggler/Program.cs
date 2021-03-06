﻿using Bytewizer.TinyCLR.Http;
using Bytewizer.TinyCLR.Hosting;
using Bytewizer.TinyCLR.Hardware;

namespace Bytewizer.Toggler
{
    class Program
    {
        static void Main()
        {
            CreateHostBuilder().Build().Run();
        }

        public static IHostBuilder CreateHostBuilder() =>
            Host.CreateDefaultBuilder()
                .ConfigureHardware(config =>
                {
                    config.BoardModel = BoardModel.Sc20260D;
                })
                .ConfigureWebHost(options =>
                {
                    options.UseFileServer();
                    options.UseMvc();
                });
    }
}
