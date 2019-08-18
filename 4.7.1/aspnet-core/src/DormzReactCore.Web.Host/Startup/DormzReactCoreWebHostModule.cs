using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DormzReactCore.Configuration;

namespace DormzReactCore.Web.Host.Startup
{
    [DependsOn(
       typeof(DormzReactCoreWebCoreModule))]
    public class DormzReactCoreWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public DormzReactCoreWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DormzReactCoreWebHostModule).GetAssembly());
        }
    }
}
