using Elements.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elements.Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p=>p.ProductName).NotEmpty().WithMessage("ürün ismi boş olamaz");
            RuleFor(p=>p.CategoryID).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(10);
            RuleFor(p=>p.UnitPrice).LessThan(40);
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(11);
            RuleFor(p => p.UnitsInStock).GreaterThanOrEqualTo((short)0);
            RuleFor(p => p.UnitsInStock).LessThanOrEqualTo((short)18).When(p => p.CategoryID == 3);
            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("ÜRÜN ADI A İLE BAŞLAMALI");


        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
