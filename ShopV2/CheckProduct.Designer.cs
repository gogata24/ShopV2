namespace ShopV2
{
    partial class CheckProduct
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckButton = new System.Windows.Forms.Button();
            this.Product = new System.Windows.Forms.ComboBox();
            this.Category = new System.Windows.Forms.ComboBox();
            this.listCheckProducts = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(168, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Избери продукт:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(155, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Избери категория:";
            // 
            // CheckButton
            // 
            this.CheckButton.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CheckButton.Location = new System.Drawing.Point(34, 234);
            this.CheckButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(416, 113);
            this.CheckButton.TabIndex = 9;
            this.CheckButton.Text = "Провери";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // Product
            // 
            this.Product.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Product.FormattingEnabled = true;
            this.Product.Location = new System.Drawing.Point(34, 177);
            this.Product.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(416, 33);
            this.Product.TabIndex = 8;
            // 
            // Category
            // 
            this.Category.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Category.FormattingEnabled = true;
            this.Category.Items.AddRange(new object[] {
            "СЛАДКИ ИЗДЕЛИЯ",
            "СНАКС",
            "ПЛОДОВЕ И ЗЕЛЕНЧУЦИ",
            "НАПИТКИ",
            "АЛКОХОЛ"});
            this.Category.Location = new System.Drawing.Point(34, 86);
            this.Category.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(416, 33);
            this.Category.TabIndex = 7;
            this.Category.SelectedIndexChanged += new System.EventHandler(this.Category_SelectedIndexChanged);
            // 
            // listCheckProducts
            // 
            this.listCheckProducts.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listCheckProducts.FormattingEnabled = true;
            this.listCheckProducts.ItemHeight = 25;
            this.listCheckProducts.Location = new System.Drawing.Point(518, 70);
            this.listCheckProducts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listCheckProducts.Name = "listCheckProducts";
            this.listCheckProducts.Size = new System.Drawing.Size(419, 254);
            this.listCheckProducts.TabIndex = 6;
            // 
            // CheckProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 417);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.Product);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.listCheckProducts);
            this.Name = "CheckProduct";
            this.Text = "CheckProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Label label1;
        private Button CheckButton;
        private ComboBox Product;
        private ComboBox Category;
        private ListBox listCheckProducts;
    }
}