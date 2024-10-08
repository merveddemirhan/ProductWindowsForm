﻿using Elements.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elements.Business.Abstract
{
    public interface IProductService
    {
        void Add(Product product);
        void Delete(Product product);
        List<Product> GetAll();
        List<Product> GetProductByCategoryId(int categoryId);
        List<Product> GetProductByProductName(string productName);
        List<Product> GetProductByProductNameAndCatogryId(string productName, int categoryId);
        void Update(Product product);
    }
}
