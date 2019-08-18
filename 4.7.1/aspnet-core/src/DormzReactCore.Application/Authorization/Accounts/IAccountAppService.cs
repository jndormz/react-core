using System.Threading.Tasks;
using Abp.Application.Services;
using DormzReactCore.Authorization.Accounts.Dto;

namespace DormzReactCore.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
