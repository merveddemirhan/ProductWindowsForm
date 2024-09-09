using Elements.Business.Abstract;
using Elements.DataAccess.Abstract;
using Elements.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elements.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal= categoryDal;
        }

        public List<Category> GetAll()
        {
           return _categoryDal.GetAll();
        }
    }
}
