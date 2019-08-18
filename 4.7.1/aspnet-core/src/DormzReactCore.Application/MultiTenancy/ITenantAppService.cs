using Abp.Application.Services;
using Abp.Application.Services.Dto;
using DormzReactCore.MultiTenancy.Dto;

namespace DormzReactCore.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

