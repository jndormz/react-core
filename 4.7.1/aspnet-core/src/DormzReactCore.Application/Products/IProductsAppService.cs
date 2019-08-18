using Abp.Application.Services;
using DormzReactCore.Products.Dto;

namespace DormzReactCore.Products {
    public interface IProductsAppService : ICrudAppService<ProductDto> {

    }
}
