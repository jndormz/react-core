using DormzReactCore.Products;
using DormzReactCore.Products.Dto;
using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace DormzReactCore.Tests.Inventories {
    public class ProductAppService_Tests : DormzReactCoreTestBase {
        private readonly IProductsAppService _productsAppService;

        public ProductAppService_Tests() {
            _productsAppService = Resolve<IProductsAppService>();
        }

        [Fact]
        public async Task GetProducts_Test() {

            // Act
            var output = await _productsAppService.GetAll(new PagedProductResultRequestDto { MaxResultCount = 10, SkipCount = 0 });

            //Assert
            output.Items.Count.ShouldBeGreaterThan(0);
        }
    }
}
