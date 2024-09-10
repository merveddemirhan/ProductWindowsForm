using Elements.Business.Abstract;
using Elements.Business.Concrete;
using Elements.Business.DependencyResolves.Ninject;
using Elements.DataAccess.Abstract;
using Elements.DataAccess.Concrete.EntityFramework;
using Elements.DataAccess.Concrete.NHibernate;
using Elements.Entities.Concrete;
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
            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService= InstanceFactory.GetInstance<ICategoryService>();
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

            cmxAddCategoryId.DataSource = _categoryService.GetAll();
            cmxAddCategoryId.DisplayMember = "CategoryName";
            cmxAddCategoryId.ValueMember = "CategoryID";

            cmxUCategoryId.DataSource = _categoryService.GetAll();
            cmxUCategoryId.DisplayMember = "CategoryName";
            cmxUCategoryId.ValueMember = "CategoryID";


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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Add(new Product
                {
                    ProductName = tbxAddProductName.Text,
                    CategoryID = Convert.ToInt32(cmxAddCategoryId.SelectedValue),
                    UnitPrice = Convert.ToDecimal(tbxAddUnitPrice.Text),
                    UnitsInStock = Convert.ToInt16(tbxAddUnitsInStock.Text),
                    QuantityPerUnit = tbxAddQuantityPerUnit.Text,
                });
                MessageBox.Show("Ürün Kaydedildi!");
                LoadProduct();
            }
            catch (Exception exception)
            { 
                MessageBox.Show(exception.Message); 
            }
       
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUProductName.Text = Convert.ToString(dgwProduct.CurrentRow.Cells[1].Value);
            cmxUCategoryId.SelectedValue = dgwProduct.CurrentRow.Cells[2].Value;
            tbxUUnitPrice.Text=dgwProduct.CurrentRow.Cells[3].Value.ToString();
            tbxUUnitInStock.Text = dgwProduct.CurrentRow.Cells[4].Value.ToString();
            tbxUQuantityPerUnit.Text = dgwProduct.CurrentRow.Cells[5].Value.ToString();

        }

        private void btnUppdate_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Update(new Product
                {
                    ProductID = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                    CategoryID = Convert.ToInt32(cmxUCategoryId.SelectedValue),
                    ProductName = tbxUProductName.Text,
                    UnitPrice = Convert.ToDecimal(tbxUUnitPrice.Text),
                    UnitsInStock = Convert.ToInt16(tbxUUnitInStock.Text),
                    QuantityPerUnit = tbxUQuantityPerUnit.Text,


                });
                MessageBox.Show("ürün güncellendi");
                LoadProduct();
            }catch(Exception exception) 
            {
                MessageBox.Show(exception.Message); 
            }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dgwProduct.CurrentRow != null)
            {
                try
                {
                    _productService.Delete(new Product
                    {
                        ProductID = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                    });
                    MessageBox.Show("ürün silindi!");
                    LoadProduct();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }


        }
    }
}
