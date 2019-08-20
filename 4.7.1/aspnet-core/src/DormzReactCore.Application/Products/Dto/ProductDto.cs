using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using DormzReactCore.Models;

namespace DormzReactCore.Products.Dto {

    [AutoMapFrom(typeof(Product))]
    [AutoMapTo(typeof(Product))]
    public class ProductDto : EntityDto<int> {
        [Required]
        public string Description { get; set; }

        public decimal Price { get; set; }
    }
}
