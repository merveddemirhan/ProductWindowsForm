﻿using Elements.Business.Abstract;
using Elements.Business.utilities;
using Elements.Business.ValidationRules.FluentValidation;
using Elements.DataAccess.Abstract;
using Elements.DataAccess.Concrete;
using Elements.DataAccess.Concrete.EntityFramework;
using Elements.Entities.Concrete;

using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elements.Business.Concrete
{
    public class ProductManager:IProductService
    {
        IProductDal _productDal ;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            ValidationTool.Validate(new ProductValidator(), product);

            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            try 
            { 
                _productDal.Delete(product); 
            }
            catch
            {
                throw new Exception("Ürün silinemedi");
            }
            
        }

        public List<Product> GetAll()
        {
            //Business Code
            return _productDal.GetAll();
        }

        public List<Product> GetProductByCategoryId(int categoryId)
        {
            return _productDal.GetAll(p => p.CategoryID == categoryId);
        }

        public List<Product> GetProductByProductName(string productName)
        {
            return _productDal.GetAll(p => p.ProductName.ToLower().Contains(productName.ToLower()));
        }

        public List<Product> GetProductByProductNameAndCatogryId(string productName, int categoryId)
        {
            return _productDal.GetAll(p => p.ProductName.ToLower().Contains(productName.ToLower()) && p.CategoryID==categoryId);
        }

        public void Update(Product product)
        {
            ValidationTool.Validate(new ProductValidator(), product);
            _productDal.Update(product);
        }
    }
}
