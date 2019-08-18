using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using DormzReactCore.Authorization;
using DormzReactCore.Products.Dto;

namespace DormzReactCore.Products {
    [AbpAuthorize(PermissionNames.Pages_Products)]
    public class ProductsAppService : CrudAppService<Product, ProductDto>, IProductsAppService {
        public ProductsAppService(IRepository<Product, int> repository) : base(repository) {
        }
    }
}
