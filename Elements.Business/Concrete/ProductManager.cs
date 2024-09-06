using Elements.Business.Abstract;
using Elements.DataAccess.Abstract;
using Elements.DataAccess.Concrete;
using Elements.DataAccess.Concrete.EntityFramework;
using Elements.Entities.Concrete;
using System;
using System.Collections.Generic;
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
        public List<Product> GetAll()
        {
            //Business Code
            return _productDal.GetAll();
        }

    }
}
