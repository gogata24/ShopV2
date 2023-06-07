namespace ShopV2
{
    partial class BuyProduct
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
            this.stockLabel = new System.Windows.Forms.Label();
            this.productLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.BuyButton = new System.Windows.Forms.Button();
            this.Stock = new System.Windows.Forms.TextBox();
            this.Product = new System.Windows.Forms.ComboBox();
            this.Category = new System.Windows.Forms.ComboBox();
            this.listProducts = new System.Windows.Forms.ListBox();
            this.AddToCartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stockLabel
            // 
            this.stockLabel.AutoSize = true;
            this.stockLabel.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stockLabel.Location = new System.Drawing.Point(184, 156);
            this.stockLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(179, 21);
            this.stockLabel.TabIndex = 17;
            this.stockLabel.Text = "Въведи количество:";
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productLabel.Location = new System.Drawing.Point(196, 91);
            this.productLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(147, 21);
            this.productLabel.TabIndex = 16;
            this.productLabel.Text = "Избери продукт:";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.categoryLabel.Location = new System.Drawing.Point(188, 16);
            this.categoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(164, 21);
            this.categoryLabel.TabIndex = 15;
            this.categoryLabel.Text = "Избери категория:";
            // 
            // BuyButton
            // 
            this.BuyButton.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BuyButton.Location = new System.Drawing.Point(33, 347);
            this.BuyButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(481, 90);
            this.BuyButton.TabIndex = 14;
            this.BuyButton.Text = "ПЛАТИ";
            this.BuyButton.UseVisualStyleBackColor = true;
            this.BuyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // Stock
            // 
            this.Stock.Location = new System.Drawing.Point(33, 182);
            this.Stock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(480, 27);
            this.Stock.TabIndex = 13;
            // 
            // Product
            // 
            this.Product.FormattingEnabled = true;
            this.Product.Location = new System.Drawing.Point(33, 117);
            this.Product.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(480, 28);
            this.Product.TabIndex = 12;
            // 
            // Category
            // 
            this.Category.FormattingEnabled = true;
            this.Category.Items.AddRange(new object[] {
            "СЛАДКИ ИЗДЕЛИЯ",
            "СНАКС",
            "ПЛОДОВЕ И ЗЕЛЕНЧУЦИ",
            "НАПИТКИ",
            "АЛКОХОЛ"});
            this.Category.Location = new System.Drawing.Point(33, 47);
            this.Category.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(480, 28);
            this.Category.TabIndex = 11;
            this.Category.SelectedIndexChanged += new System.EventHandler(this.Category_SelectedIndexChanged);
            // 
            // listProducts
            // 
            this.listProducts.FormattingEnabled = true;
            this.listProducts.ItemHeight = 20;
            this.listProducts.Location = new System.Drawing.Point(610, 13);
            this.listProducts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listProducts.Name = "listProducts";
            this.listProducts.Size = new System.Drawing.Size(379, 424);
            this.listProducts.TabIndex = 10;
            // 
            // AddToCartButton
            // 
            this.AddToCartButton.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddToCartButton.Location = new System.Drawing.Point(33, 238);
            this.AddToCartButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddToCartButton.Name = "AddToCartButton";
            this.AddToCartButton.Size = new System.Drawing.Size(481, 90);
            this.AddToCartButton.TabIndex = 9;
            this.AddToCartButton.Text = "ДОБАВИ В КОЛИЧКАТА";
            this.AddToCartButton.UseVisualStyleBackColor = true;
            this.AddToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
            // 
            // BuyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 450);
            this.Controls.Add(this.stockLabel);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.BuyButton);
            this.Controls.Add(this.Stock);
            this.Controls.Add(this.Product);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.listProducts);
            this.Controls.Add(this.AddToCartButton);
            this.Name = "BuyProduct";
            this.Text = "BuyProduct";
            this.Load += new System.EventHandler(this.BuyProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label stockLabel;
        private Label productLabel;
        private Label categoryLabel;
        private Button BuyButton;
        private TextBox Stock;
        private ComboBox Product;
        private ComboBox Category;
        private ListBox listProducts;
        private Button AddToCartButton;
    }
}