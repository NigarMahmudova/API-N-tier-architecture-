using FluentValidation;

namespace ShopApp.Api.Dtos.ProductDtos
{
    public class ProductPutDto
    {
        public int BrandId { get; set; }
        public string Name { get; set; }
        public decimal CostPrice { get; set; }
        public decimal SalePrice { get; set; }

        public class ProductPutDtoValidator : AbstractValidator<ProductPutDto>
        {
            public ProductPutDtoValidator()
            {
                RuleFor(x => x.Name).NotEmpty().MinimumLength(2).MaximumLength(100);
                RuleFor(x => x.CostPrice).GreaterThanOrEqualTo(0);
                RuleFor(x => x.BrandId).GreaterThanOrEqualTo(1);
                RuleFor(x => x.SalePrice).GreaterThanOrEqualTo(x => x.CostPrice);
            }
        }
    }
}
