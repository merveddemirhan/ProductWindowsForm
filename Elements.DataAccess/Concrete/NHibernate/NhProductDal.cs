using Elements.DataAccess.Abstract;
using Elements.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elements.DataAccess.Concrete.NHibernate
{
    public class NhProductDal : IProductDal
    {
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
           List<Product> list = new List<Product>
           {
               new Product{ProductID=1, CategoryID=2,ProductName="AAA", UnitPrice=21000, UnitsInStock=5, QuantityPerUnit="1 in a box" } };
            return list;
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
