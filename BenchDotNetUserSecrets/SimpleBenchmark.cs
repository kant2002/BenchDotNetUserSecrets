using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BenchDotNetUserSecrets
{
    [SimpleJob(launchCount: 3, warmupCount: 10, targetCount: 10)]
    public class SimpleBenchmark
    {
        private FakeService service;

        [GlobalSetup]
        public void GlobalSetup()
        {
            var host = Host.CreateDefaultBuilder().Build();
            var configuration = host.Services.GetService<IConfiguration>();

            this.service = new FakeService(configuration);
        }

        [Benchmark]
        public int PlaceSimplestBet()
        {
            return this.service.GetGoogleComLength();
        }

        [Benchmark]
        public int PlaceSimplestBet2()
        {
            return this.service.GetGoogleComLength2();
        }
    }
}
