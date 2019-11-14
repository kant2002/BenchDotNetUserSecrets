using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace BenchDotNetUserSecrets
{
    class FakeService
    {
        private readonly IConfiguration configuration;
        private readonly bool useStatic;

        public FakeService(IConfiguration configuration)
        {
            this.configuration = configuration;
            this.useStatic = this.configuration["UseStatic"] == "true";
        }

        public int GetGoogleComLength()
        {
            if (this.useStatic)
            {
                return 5;
            }

            return new Random().Next(100);
        }

        public int GetGoogleComLength2()
        {
            return 5;
        }
    }
}
