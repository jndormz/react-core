using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace DormzReactCore.Controllers
{
    public abstract class DormzReactCoreControllerBase: AbpController
    {
        protected DormzReactCoreControllerBase()
        {
            LocalizationSourceName = DormzReactCoreConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
