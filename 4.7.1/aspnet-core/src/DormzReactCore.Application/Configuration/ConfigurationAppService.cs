using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using DormzReactCore.Configuration.Dto;

namespace DormzReactCore.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : DormzReactCoreAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
