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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSearchWithCategory = new System.Windows.Forms.Label();
            this.lblSearchWithName = new System.Windows.Forms.Label();
            this.cmbSearchWithCategory = new System.Windows.Forms.ComboBox();
            this.tbxSearhWithName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(-2, 223);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.RowHeadersWidth = 51;
            this.dgwProduct.RowTemplate.Height = 24;
            this.dgwProduct.Size = new System.Drawing.Size(790, 198);
            this.dgwProduct.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbSearchWithCategory);
            this.groupBox1.Controls.Add(this.lblSearchWithCategory);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 97);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategori ile Ara";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbxSearhWithName);
            this.groupBox2.Controls.Add(this.lblSearchWithName);
            this.groupBox2.Location = new System.Drawing.Point(0, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(788, 114);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Adı ile Ara";
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
            // lblSearchWithName
            // 
            this.lblSearchWithName.AutoSize = true;
            this.lblSearchWithName.Location = new System.Drawing.Point(12, 28);
            this.lblSearchWithName.Name = "lblSearchWithName";
            this.lblSearchWithName.Size = new System.Drawing.Size(58, 16);
            this.lblSearchWithName.TabIndex = 1;
            this.lblSearchWithName.Text = "Ürün Adı";
            // 
            // cmbSearchWithCategory
            // 
            this.cmbSearchWithCategory.FormattingEnabled = true;
            this.cmbSearchWithCategory.Location = new System.Drawing.Point(86, 21);
            this.cmbSearchWithCategory.Name = "cmbSearchWithCategory";
            this.cmbSearchWithCategory.Size = new System.Drawing.Size(157, 24);
            this.cmbSearchWithCategory.TabIndex = 1;
            this.cmbSearchWithCategory.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tbxSearhWithName
            // 
            this.tbxSearhWithName.Location = new System.Drawing.Point(96, 25);
            this.tbxSearhWithName.Name = "tbxSearhWithName";
            this.tbxSearhWithName.Size = new System.Drawing.Size(147, 22);
            this.tbxSearhWithName.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

