using Elements.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elements.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
