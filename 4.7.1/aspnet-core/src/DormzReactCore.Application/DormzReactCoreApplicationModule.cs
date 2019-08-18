using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DormzReactCore.Authorization;

namespace DormzReactCore
{
    [DependsOn(
        typeof(DormzReactCoreCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class DormzReactCoreApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<DormzReactCoreAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(DormzReactCoreApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
