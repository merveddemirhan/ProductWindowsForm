using Elements.Business.Abstract;
using Elements.Business.Concrete;
using Elements.DataAccess.Abstract;
using Elements.DataAccess.Concrete.EntityFramework;
using Elements.DataAccess.Concrete.NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elements.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
            _categoryService=new CategoryManager(new EfCategoryDal());
        }
        IProductService _productService;
        ICategoryService _categoryService;

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProduct();
            LoadCategory();

        }

        private void LoadCategory()
        {
            cmbSearchWithCategory.DataSource = _categoryService.GetAll();
            cmbSearchWithCategory.DisplayMember = "CategoryName";
            cmbSearchWithCategory.ValueMember = "CategoryID";
        }

        private void LoadProduct()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }


        private void cmbSearchWithCategory_SelectedIndexChanged(object sender, EventArgs e)
            
        
        {
            try 
            {
                dgwProduct.DataSource = _productService.GetProductByCategoryId(Convert.ToInt32(cmbSearchWithCategory.SelectedValue));
            }
            catch 
            {

            }
           
        }

        private void tbxSearhWithName_TextChanged(object sender, EventArgs e)
        {

            if(cmbSearchWithCategory.SelectedValue !=null && String.IsNullOrEmpty(tbxSearhWithName.Text))
            {
                dgwProduct.DataSource = _productService.GetProductByCategoryId(Convert.ToInt32(cmbSearchWithCategory.SelectedValue));
            }
            if(cmbSearchWithCategory.SelectedValue==null && !String.IsNullOrEmpty(tbxSearhWithName.Text))
            {
                dgwProduct.DataSource = _productService.GetProductByProductName(tbxSearhWithName.Text);
            }
            if (String.IsNullOrEmpty(tbxSearhWithName.Text))
            {
                LoadProduct();
            }
            else
            {
                dgwProduct.DataSource=_productService.GetProductByProductNameAndCatogryId(tbxSearhWithName.Text, Convert.ToInt32(cmbSearchWithCategory.SelectedValue));
            }
            
        }

    }
}
