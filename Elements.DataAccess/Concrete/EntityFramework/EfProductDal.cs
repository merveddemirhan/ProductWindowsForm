using Elements.DataAccess.Abstract;
using Elements.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elements.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal:IProductDal { 
        public List<Product> GetAll()
        {
            using(ElementsContext elementsContext = new ElementsContext())
            {
            return elementsContext.Products.ToList();
            }

        }
        public Product Get(int id)
        {
            using (ElementsContext elementsContext = new ElementsContext())
            {
                return elementsContext.Products.SingleOrDefault(p=>p.ProductID==id);
            }
        }
        public void Add(Product product)
        {
            using (ElementsContext elementsContext = new ElementsContext())
            {
                 elementsContext.Products.Add(product);
                elementsContext.SaveChanges();

            }
        }
        public void Delete(int id)
        {

        }
        public void Update(Product product)
        {

        }

     }
}
