using System.Threading.Tasks;
using DormzReactCore.Configuration.Dto;

namespace DormzReactCore.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
