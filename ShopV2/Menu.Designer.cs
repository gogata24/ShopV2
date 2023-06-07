namespace ShopV2
{
    partial class Menu
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
            this.ExitButton = new System.Windows.Forms.Button();
            this.SoldForDayButton = new System.Windows.Forms.Button();
            this.CheckButton = new System.Windows.Forms.Button();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.BuyProductButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ExitButton.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.ForeColor = System.Drawing.Color.Red;
            this.ExitButton.Location = new System.Drawing.Point(106, 301);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(495, 88);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "ИЗХОД";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SoldForDayButton
            // 
            this.SoldForDayButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SoldForDayButton.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SoldForDayButton.Location = new System.Drawing.Point(383, 179);
            this.SoldForDayButton.Name = "SoldForDayButton";
            this.SoldForDayButton.Size = new System.Drawing.Size(218, 88);
            this.SoldForDayButton.TabIndex = 8;
            this.SoldForDayButton.Text = "ПРОДАДЕНО ЗА ДЕНЯ";
            this.SoldForDayButton.UseVisualStyleBackColor = false;
            this.SoldForDayButton.Click += new System.EventHandler(this.SoldForDayButton_Click);
            // 
            // CheckButton
            // 
            this.CheckButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CheckButton.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CheckButton.Location = new System.Drawing.Point(106, 179);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(218, 88);
            this.CheckButton.TabIndex = 7;
            this.CheckButton.Text = "ПРОВЕРКА ЗА НАЛИЧНОСТ";
            this.CheckButton.UseVisualStyleBackColor = false;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // AddProductButton
            // 
            this.AddProductButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AddProductButton.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddProductButton.Location = new System.Drawing.Point(383, 61);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(218, 91);
            this.AddProductButton.TabIndex = 6;
            this.AddProductButton.Text = "ДОБАВЯНЕ НА СТОКА";
            this.AddProductButton.UseVisualStyleBackColor = false;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // BuyProductButton
            // 
            this.BuyProductButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BuyProductButton.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BuyProductButton.Location = new System.Drawing.Point(106, 61);
            this.BuyProductButton.Name = "BuyProductButton";
            this.BuyProductButton.Size = new System.Drawing.Size(218, 91);
            this.BuyProductButton.TabIndex = 5;
            this.BuyProductButton.Text = "ПОКУПКА";
            this.BuyProductButton.UseVisualStyleBackColor = false;
            this.BuyProductButton.Click += new System.EventHandler(this.BuyProductButton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 450);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SoldForDayButton);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.BuyProductButton);
            this.Name = "Menu";
            this.Text = "Меню";
            this.ResumeLayout(false);

        }

        #endregion

        private Button ExitButton;
        private Button SoldForDayButton;
        private Button CheckButton;
        private Button AddProductButton;
        private Button BuyProductButton;
    }
}