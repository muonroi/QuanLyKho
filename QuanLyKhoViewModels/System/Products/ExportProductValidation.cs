using FluentValidation;
using QuanLyKhoViewModels.Catalog.Exporduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyKhoViewModels.System.Products
{
    public class ExportProductValidation : AbstractValidator<ProductCreateExRequest>
    {
        public ExportProductValidation()
        {
           
            RuleFor(x => x.Quantity).NotEmpty()
                .WithMessage("Quantity is required");
        }
    }
}
