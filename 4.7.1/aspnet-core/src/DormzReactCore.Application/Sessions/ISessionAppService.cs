using System.Threading.Tasks;
using Abp.Application.Services;
using DormzReactCore.Sessions.Dto;

namespace DormzReactCore.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
