using FluentValidation;
using QuanLyKhoViewModels.Catalog.Products;
using QuanLyKhoViewModels.System.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyKhoViewModels.System.Products
{
    public class CreateImportProductValidator : AbstractValidator<ProductCreateRequest>
    {
        public CreateImportProductValidator()
        {
            RuleFor(x => x.Id).NotEmpty().MinimumLength(3).MaximumLength(25)
               .WithMessage("ProductID is required and 3-25 character");
            RuleFor(x => x.Name).NotEmpty().MinimumLength(3).MaximumLength(50)
              .WithMessage("Name Product is required and 3-50 character");
            RuleFor(x => x.ImportDate).GreaterThan(DateTime.Now.AddDays(-100)).WithMessage("ExportDate cannot greater than 100 year");
            RuleFor(x => x.Quantity).NotEmpty()
                .WithMessage("Quantity is required");
        }
    }
}
