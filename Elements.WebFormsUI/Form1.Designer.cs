namespace Elements.WebFormsUI
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbSearchWithCategory = new System.Windows.Forms.ComboBox();
            this.lblSearchWithCategory = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxSearhWithName = new System.Windows.Forms.TextBox();
            this.lblSearchWithName = new System.Windows.Forms.Label();
            this.gbxProductAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmxAddCategoryId = new System.Windows.Forms.ComboBox();
            this.tbxAddQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.tbxAddUnitsInStock = new System.Windows.Forms.TextBox();
            this.tbxAddUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxAddProductName = new System.Windows.Forms.TextBox();
            this.lblAddQuantityPerUnit = new System.Windows.Forms.Label();
            this.lblAddUnitsInStock = new System.Windows.Forms.Label();
            this.lblAddUnitPrice = new System.Windows.Forms.Label();
            this.lblKategoriId = new System.Windows.Forms.Label();
            this.lblAddProductName = new System.Windows.Forms.Label();
            this.gbxProductUpdate = new System.Windows.Forms.GroupBox();
            this.btnUppdate = new System.Windows.Forms.Button();
            this.cmxUCategoryId = new System.Windows.Forms.ComboBox();
            this.tbxUQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.tbxUUnitInStock = new System.Windows.Forms.TextBox();
            this.tbxUUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxUProductName = new System.Windows.Forms.TextBox();
            this.lblUQuantityPerUnit = new System.Windows.Forms.Label();
            this.lblUUnitsInStock = new System.Windows.Forms.Label();
            this.lblUStockAmount = new System.Windows.Forms.Label();
            this.lblUCategoryId = new System.Windows.Forms.Label();
            this.lblUProductName = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbxProductAdd.SuspendLayout();
            this.gbxProductUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(0, 135);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.RowHeadersWidth = 51;
            this.dgwProduct.RowTemplate.Height = 24;
            this.dgwProduct.Size = new System.Drawing.Size(790, 249);
            this.dgwProduct.TabIndex = 0;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbSearchWithCategory);
            this.groupBox1.Controls.Add(this.lblSearchWithCategory);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 61);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategori ile Ara";
            // 
            // cmbSearchWithCategory
            // 
            this.cmbSearchWithCategory.FormattingEnabled = true;
            this.cmbSearchWithCategory.Location = new System.Drawing.Point(86, 21);
            this.cmbSearchWithCategory.Name = "cmbSearchWithCategory";
            this.cmbSearchWithCategory.Size = new System.Drawing.Size(157, 24);
            this.cmbSearchWithCategory.TabIndex = 1;
            this.cmbSearchWithCategory.SelectedIndexChanged += new System.EventHandler(this.cmbSearchWithCategory_SelectedIndexChanged);
            // 
            // lblSearchWithCategory
            // 
            this.lblSearchWithCategory.AutoSize = true;
            this.lblSearchWithCategory.Location = new System.Drawing.Point(13, 24);
            this.lblSearchWithCategory.Name = "lblSearchWithCategory";
            this.lblSearchWithCategory.Size = new System.Drawing.Size(57, 16);
            this.lblSearchWithCategory.TabIndex = 0;
            this.lblSearchWithCategory.Text = "Kategori";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbxSearhWithName);
            this.groupBox2.Controls.Add(this.lblSearchWithName);
            this.groupBox2.Location = new System.Drawing.Point(0, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(788, 62);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Adı ile Ara";
            // 
            // tbxSearhWithName
            // 
            this.tbxSearhWithName.Location = new System.Drawing.Point(96, 25);
            this.tbxSearhWithName.Name = "tbxSearhWithName";
            this.tbxSearhWithName.Size = new System.Drawing.Size(147, 22);
            this.tbxSearhWithName.TabIndex = 2;
            this.tbxSearhWithName.TextChanged += new System.EventHandler(this.tbxSearhWithName_TextChanged);
            // 
            // lblSearchWithName
            // 
            this.lblSearchWithName.AutoSize = true;
            this.lblSearchWithName.Location = new System.Drawing.Point(12, 28);
            this.lblSearchWithName.Name = "lblSearchWithName";
            this.lblSearchWithName.Size = new System.Drawing.Size(58, 16);
            this.lblSearchWithName.TabIndex = 1;
            this.lblSearchWithName.Text = "Ürün Adı";
            // 
            // gbxProductAdd
            // 
            this.gbxProductAdd.Controls.Add(this.btnAdd);
            this.gbxProductAdd.Controls.Add(this.cmxAddCategoryId);
            this.gbxProductAdd.Controls.Add(this.tbxAddQuantityPerUnit);
            this.gbxProductAdd.Controls.Add(this.tbxAddUnitsInStock);
            this.gbxProductAdd.Controls.Add(this.tbxAddUnitPrice);
            this.gbxProductAdd.Controls.Add(this.tbxAddProductName);
            this.gbxProductAdd.Controls.Add(this.lblAddQuantityPerUnit);
            this.gbxProductAdd.Controls.Add(this.lblAddUnitsInStock);
            this.gbxProductAdd.Controls.Add(this.lblAddUnitPrice);
            this.gbxProductAdd.Controls.Add(this.lblKategoriId);
            this.gbxProductAdd.Controls.Add(this.lblAddProductName);
            this.gbxProductAdd.Location = new System.Drawing.Point(0, 440);
            this.gbxProductAdd.Name = "gbxProductAdd";
            this.gbxProductAdd.Size = new System.Drawing.Size(417, 205);
            this.gbxProductAdd.TabIndex = 3;
            this.gbxProductAdd.TabStop = false;
            this.gbxProductAdd.Text = "Yeni Ürün Ekle";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(137, 175);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(157, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmxAddCategoryId
            // 
            this.cmxAddCategoryId.FormattingEnabled = true;
            this.cmxAddCategoryId.Location = new System.Drawing.Point(137, 53);
            this.cmxAddCategoryId.Name = "cmxAddCategoryId";
            this.cmxAddCategoryId.Size = new System.Drawing.Size(157, 24);
            this.cmxAddCategoryId.TabIndex = 9;
            // 
            // tbxAddQuantityPerUnit
            // 
            this.tbxAddQuantityPerUnit.Location = new System.Drawing.Point(137, 139);
            this.tbxAddQuantityPerUnit.Name = "tbxAddQuantityPerUnit";
            this.tbxAddQuantityPerUnit.Size = new System.Drawing.Size(157, 22);
            this.tbxAddQuantityPerUnit.TabIndex = 8;
            // 
            // tbxAddUnitsInStock
            // 
            this.tbxAddUnitsInStock.Location = new System.Drawing.Point(137, 111);
            this.tbxAddUnitsInStock.Name = "tbxAddUnitsInStock";
            this.tbxAddUnitsInStock.Size = new System.Drawing.Size(157, 22);
            this.tbxAddUnitsInStock.TabIndex = 7;
            // 
            // tbxAddUnitPrice
            // 
            this.tbxAddUnitPrice.Location = new System.Drawing.Point(137, 83);
            this.tbxAddUnitPrice.Name = "tbxAddUnitPrice";
            this.tbxAddUnitPrice.Size = new System.Drawing.Size(157, 22);
            this.tbxAddUnitPrice.TabIndex = 6;
            // 
            // tbxAddProductName
            // 
            this.tbxAddProductName.Location = new System.Drawing.Point(137, 23);
            this.tbxAddProductName.Name = "tbxAddProductName";
            this.tbxAddProductName.Size = new System.Drawing.Size(157, 22);
            this.tbxAddProductName.TabIndex = 5;
            // 
            // lblAddQuantityPerUnit
            // 
            this.lblAddQuantityPerUnit.AutoSize = true;
            this.lblAddQuantityPerUnit.Location = new System.Drawing.Point(13, 145);
            this.lblAddQuantityPerUnit.Name = "lblAddQuantityPerUnit";
            this.lblAddQuantityPerUnit.Size = new System.Drawing.Size(76, 16);
            this.lblAddQuantityPerUnit.TabIndex = 4;
            this.lblAddQuantityPerUnit.Text = "Birim Adedi";
            // 
            // lblAddUnitsInStock
            // 
            this.lblAddUnitsInStock.AutoSize = true;
            this.lblAddUnitsInStock.Location = new System.Drawing.Point(13, 117);
            this.lblAddUnitsInStock.Name = "lblAddUnitsInStock";
            this.lblAddUnitsInStock.Size = new System.Drawing.Size(73, 16);
            this.lblAddUnitsInStock.TabIndex = 3;
            this.lblAddUnitsInStock.Text = "Stok Adedi";
            // 
            // lblAddUnitPrice
            // 
            this.lblAddUnitPrice.AutoSize = true;
            this.lblAddUnitPrice.Location = new System.Drawing.Point(13, 89);
            this.lblAddUnitPrice.Name = "lblAddUnitPrice";
            this.lblAddUnitPrice.Size = new System.Drawing.Size(72, 16);
            this.lblAddUnitPrice.TabIndex = 2;
            this.lblAddUnitPrice.Text = "Birim Fiyati";
            // 
            // lblKategoriId
            // 
            this.lblKategoriId.AutoSize = true;
            this.lblKategoriId.Location = new System.Drawing.Point(12, 61);
            this.lblKategoriId.Name = "lblKategoriId";
            this.lblKategoriId.Size = new System.Drawing.Size(57, 16);
            this.lblKategoriId.TabIndex = 1;
            this.lblKategoriId.Text = "Kategori";
            // 
            // lblAddProductName
            // 
            this.lblAddProductName.AutoSize = true;
            this.lblAddProductName.Location = new System.Drawing.Point(12, 26);
            this.lblAddProductName.Name = "lblAddProductName";
            this.lblAddProductName.Size = new System.Drawing.Size(58, 16);
            this.lblAddProductName.TabIndex = 0;
            this.lblAddProductName.Text = "Ürün Adı";
            // 
            // gbxProductUpdate
            // 
            this.gbxProductUpdate.Controls.Add(this.btnUppdate);
            this.gbxProductUpdate.Controls.Add(this.cmxUCategoryId);
            this.gbxProductUpdate.Controls.Add(this.tbxUQuantityPerUnit);
            this.gbxProductUpdate.Controls.Add(this.tbxUUnitInStock);
            this.gbxProductUpdate.Controls.Add(this.tbxUUnitPrice);
            this.gbxProductUpdate.Controls.Add(this.tbxUProductName);
            this.gbxProductUpdate.Controls.Add(this.lblUQuantityPerUnit);
            this.gbxProductUpdate.Controls.Add(this.lblUUnitsInStock);
            this.gbxProductUpdate.Controls.Add(this.lblUStockAmount);
            this.gbxProductUpdate.Controls.Add(this.lblUCategoryId);
            this.gbxProductUpdate.Controls.Add(this.lblUProductName);
            this.gbxProductUpdate.Location = new System.Drawing.Point(423, 440);
            this.gbxProductUpdate.Name = "gbxProductUpdate";
            this.gbxProductUpdate.Size = new System.Drawing.Size(365, 205);
            this.gbxProductUpdate.TabIndex = 0;
            this.gbxProductUpdate.TabStop = false;
            this.gbxProductUpdate.Text = "Ürün Güncelle";
            // 
            // btnUppdate
            // 
            this.btnUppdate.Location = new System.Drawing.Point(166, 170);
            this.btnUppdate.Name = "btnUppdate";
            this.btnUppdate.Size = new System.Drawing.Size(157, 23);
            this.btnUppdate.TabIndex = 20;
            this.btnUppdate.Text = "Güncelle";
            this.btnUppdate.UseVisualStyleBackColor = true;
            this.btnUppdate.Click += new System.EventHandler(this.btnUppdate_Click);
            // 
            // cmxUCategoryId
            // 
            this.cmxUCategoryId.FormattingEnabled = true;
            this.cmxUCategoryId.Location = new System.Drawing.Point(166, 53);
            this.cmxUCategoryId.Name = "cmxUCategoryId";
            this.cmxUCategoryId.Size = new System.Drawing.Size(157, 24);
            this.cmxUCategoryId.TabIndex = 19;
            // 
            // tbxUQuantityPerUnit
            // 
            this.tbxUQuantityPerUnit.Location = new System.Drawing.Point(166, 142);
            this.tbxUQuantityPerUnit.Name = "tbxUQuantityPerUnit";
            this.tbxUQuantityPerUnit.Size = new System.Drawing.Size(157, 22);
            this.tbxUQuantityPerUnit.TabIndex = 18;
            // 
            // tbxUUnitInStock
            // 
            this.tbxUUnitInStock.Location = new System.Drawing.Point(166, 114);
            this.tbxUUnitInStock.Name = "tbxUUnitInStock";
            this.tbxUUnitInStock.Size = new System.Drawing.Size(157, 22);
            this.tbxUUnitInStock.TabIndex = 17;
            // 
            // tbxUUnitPrice
            // 
            this.tbxUUnitPrice.Location = new System.Drawing.Point(166, 83);
            this.tbxUUnitPrice.Name = "tbxUUnitPrice";
            this.tbxUUnitPrice.Size = new System.Drawing.Size(157, 22);
            this.tbxUUnitPrice.TabIndex = 16;
            // 
            // tbxUProductName
            // 
            this.tbxUProductName.Location = new System.Drawing.Point(166, 20);
            this.tbxUProductName.Name = "tbxUProductName";
            this.tbxUProductName.Size = new System.Drawing.Size(157, 22);
            this.tbxUProductName.TabIndex = 15;
            // 
            // lblUQuantityPerUnit
            // 
            this.lblUQuantityPerUnit.AutoSize = true;
            this.lblUQuantityPerUnit.Location = new System.Drawing.Point(45, 145);
            this.lblUQuantityPerUnit.Name = "lblUQuantityPerUnit";
            this.lblUQuantityPerUnit.Size = new System.Drawing.Size(76, 16);
            this.lblUQuantityPerUnit.TabIndex = 14;
            this.lblUQuantityPerUnit.Text = "Birim Adedi";
            // 
            // lblUUnitsInStock
            // 
            this.lblUUnitsInStock.AutoSize = true;
            this.lblUUnitsInStock.Location = new System.Drawing.Point(45, 117);
            this.lblUUnitsInStock.Name = "lblUUnitsInStock";
            this.lblUUnitsInStock.Size = new System.Drawing.Size(73, 16);
            this.lblUUnitsInStock.TabIndex = 13;
            this.lblUUnitsInStock.Text = "Stok Adedi";
            // 
            // lblUStockAmount
            // 
            this.lblUStockAmount.AutoSize = true;
            this.lblUStockAmount.Location = new System.Drawing.Point(45, 89);
            this.lblUStockAmount.Name = "lblUStockAmount";
            this.lblUStockAmount.Size = new System.Drawing.Size(72, 16);
            this.lblUStockAmount.TabIndex = 12;
            this.lblUStockAmount.Text = "Birim Fiyati";
            // 
            // lblUCategoryId
            // 
            this.lblUCategoryId.AutoSize = true;
            this.lblUCategoryId.Location = new System.Drawing.Point(45, 56);
            this.lblUCategoryId.Name = "lblUCategoryId";
            this.lblUCategoryId.Size = new System.Drawing.Size(57, 16);
            this.lblUCategoryId.TabIndex = 11;
            this.lblUCategoryId.Text = "Kategori";
            // 
            // lblUProductName
            // 
            this.lblUProductName.AutoSize = true;
            this.lblUProductName.Location = new System.Drawing.Point(45, 26);
            this.lblUProductName.Name = "lblUProductName";
            this.lblUProductName.Size = new System.Drawing.Size(58, 16);
            this.lblUProductName.TabIndex = 10;
            this.lblUProductName.Text = "Ürün Adı";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(589, 403);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(157, 31);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 648);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gbxProductUpdate);
            this.Controls.Add(this.gbxProductAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwProduct);
            this.Name = "Form1";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbxProductAdd.ResumeLayout(false);
            this.gbxProductAdd.PerformLayout();
            this.gbxProductUpdate.ResumeLayout(false);
            this.gbxProductUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSearchWithCategory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSearchWithName;
        private System.Windows.Forms.ComboBox cmbSearchWithCategory;
        private System.Windows.Forms.TextBox tbxSearhWithName;
        private System.Windows.Forms.GroupBox gbxProductAdd;
        private System.Windows.Forms.GroupBox gbxProductUpdate;
        private System.Windows.Forms.Label lblAddQuantityPerUnit;
        private System.Windows.Forms.Label lblAddUnitsInStock;
        private System.Windows.Forms.Label lblAddUnitPrice;
        private System.Windows.Forms.Label lblKategoriId;
        private System.Windows.Forms.Label lblAddProductName;
        private System.Windows.Forms.ComboBox cmxAddCategoryId;
        private System.Windows.Forms.TextBox tbxAddQuantityPerUnit;
        private System.Windows.Forms.TextBox tbxAddUnitsInStock;
        private System.Windows.Forms.TextBox tbxAddUnitPrice;
        private System.Windows.Forms.TextBox tbxAddProductName;
        private System.Windows.Forms.ComboBox cmxUCategoryId;
        private System.Windows.Forms.TextBox tbxUQuantityPerUnit;
        private System.Windows.Forms.TextBox tbxUUnitInStock;
        private System.Windows.Forms.TextBox tbxUUnitPrice;
        private System.Windows.Forms.TextBox tbxUProductName;
        private System.Windows.Forms.Label lblUQuantityPerUnit;
        private System.Windows.Forms.Label lblUUnitsInStock;
        private System.Windows.Forms.Label lblUStockAmount;
        private System.Windows.Forms.Label lblUCategoryId;
        private System.Windows.Forms.Label lblUProductName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUppdate;
        private System.Windows.Forms.Button btnDelete;
    }
}

