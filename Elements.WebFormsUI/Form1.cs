﻿using Elements.Business.Abstract;
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
            _productService = new ProductManager(new NhProductDal());
        }
        IProductService _productService;
        private void Form1_Load(object sender, EventArgs e)
        {
           
            dgwProduct.DataSource = _productService.GetAll();

        }
    }
}
