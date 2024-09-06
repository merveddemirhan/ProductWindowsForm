using Elements.Business.Concrete;

namespace ElementsWindowsFormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProductManager productManager = new ProductManager();
            dgwProduct.DataSource = productManager.GetAll();
        }
    }
}
