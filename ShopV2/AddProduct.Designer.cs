namespace ShopV2
{
    partial class AddProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ExistProduct = new System.Windows.Forms.ComboBox();
            this.AddExistProduct = new System.Windows.Forms.RadioButton();
            this.NewProduct = new System.Windows.Forms.RadioButton();
            this.ProductAddButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.Stock = new System.Windows.Forms.TextBox();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.Category = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ExistProduct
            // 
            this.ExistProduct.FormattingEnabled = true;
            this.ExistProduct.Location = new System.Drawing.Point(212, 191);
            this.ExistProduct.Name = "ExistProduct";
            this.ExistProduct.Size = new System.Drawing.Size(283, 28);
            this.ExistProduct.TabIndex = 23;
            this.ExistProduct.Visible = false;
            // 
            // AddExistProduct
            // 
            this.AddExistProduct.AutoSize = true;
            this.AddExistProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddExistProduct.Location = new System.Drawing.Point(175, 63);
            this.AddExistProduct.Name = "AddExistProduct";
            this.AddExistProduct.Size = new System.Drawing.Size(410, 29);
            this.AddExistProduct.TabIndex = 22;
            this.AddExistProduct.Text = "Добавяне на стока на съществуващ продукт";
            this.AddExistProduct.UseVisualStyleBackColor = true;
            this.AddExistProduct.CheckedChanged += new System.EventHandler(this.AddExistProduct_CheckedChanged);
            // 
            // NewProduct
            // 
            this.NewProduct.AutoSize = true;
            this.NewProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NewProduct.Location = new System.Drawing.Point(175, 13);
            this.NewProduct.Name = "NewProduct";
            this.NewProduct.Size = new System.Drawing.Size(254, 29);
            this.NewProduct.TabIndex = 21;
            this.NewProduct.Text = "Добавяне на нов продукт";
            this.NewProduct.UseVisualStyleBackColor = true;
            this.NewProduct.CheckedChanged += new System.EventHandler(this.NewProduct_CheckedChanged);
            // 
            // ProductAddButton
            // 
            this.ProductAddButton.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProductAddButton.Location = new System.Drawing.Point(82, 351);
            this.ProductAddButton.Name = "ProductAddButton";
            this.ProductAddButton.Size = new System.Drawing.Size(448, 87);
            this.ProductAddButton.TabIndex = 20;
            this.ProductAddButton.Text = "ДОБАВИ";
            this.ProductAddButton.UseVisualStyleBackColor = true;
            this.ProductAddButton.Click += new System.EventHandler(this.ProductAddButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(140, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "Цена";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(123, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Брой/КГ";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(123, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Продукт";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(123, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Избери";
            this.label1.Visible = false;
            // 
            // Price
            // 
            this.Price.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Price.Location = new System.Drawing.Point(212, 284);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(229, 30);
            this.Price.TabIndex = 15;
            this.Price.Visible = false;
            // 
            // Stock
            // 
            this.Stock.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Stock.Location = new System.Drawing.Point(212, 234);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(230, 30);
            this.Stock.TabIndex = 14;
            this.Stock.Visible = false;
            // 
            // ProductName
            // 
            this.ProductName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProductName.Location = new System.Drawing.Point(212, 188);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(229, 30);
            this.ProductName.TabIndex = 13;
            this.ProductName.Visible = false;
            // 
            // Category
            // 
            this.Category.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Category.FormattingEnabled = true;
            this.Category.Items.AddRange(new object[] {
            "СЛАДКИ ИЗДЕЛИЯ",
            "СНАКС",
            "ПЛОДОВЕ И ЗЕЛЕНЧУЦИ",
            "НАПИТКИ",
            "АЛКОХОЛ"});
            this.Category.Location = new System.Drawing.Point(212, 131);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(281, 32);
            this.Category.TabIndex = 12;
            this.Category.Visible = false;
            this.Category.SelectedIndexChanged += new System.EventHandler(this.Category_SelectedIndexChanged);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 481);
            this.Controls.Add(this.ExistProduct);
            this.Controls.Add(this.AddExistProduct);
            this.Controls.Add(this.NewProduct);
            this.Controls.Add(this.ProductAddButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Stock);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.Category);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox ExistProduct;
        private RadioButton AddExistProduct;
        private RadioButton NewProduct;
        private Button ProductAddButton;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox Price;
        private TextBox Stock;
        private TextBox ProductName;
        private ComboBox Category;
    }
}