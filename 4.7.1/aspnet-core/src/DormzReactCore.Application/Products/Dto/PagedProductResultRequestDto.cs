using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services.Dto;

namespace DormzReactCore.Products.Dto {
    public class PagedProductResultRequestDto : PagedAndSortedResultRequestDto {
        public string Keyword { get; set; }
        public bool? IsActive { get; set; }
    }
}
