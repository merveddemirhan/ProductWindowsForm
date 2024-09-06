namespace ElementsWindowsFormUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgwProduct = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgwProduct).BeginInit();
            SuspendLayout();
            // 
            // dgwProduct
            // 
            dgwProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwProduct.Location = new Point(0, 209);
            dgwProduct.Name = "dgwProduct";
            dgwProduct.RowHeadersWidth = 51;
            dgwProduct.Size = new Size(788, 229);
            dgwProduct.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgwProduct);
            Name = "Form1";
            Text = "Ürünler";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgwProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgwProduct;
    }
}
