namespace ShopV2
{
    partial class SoldForToday
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
            this.listSoldForToday = new System.Windows.Forms.ListBox();
            this.SoldForTodayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listSoldForToday
            // 
            this.listSoldForToday.FormattingEnabled = true;
            this.listSoldForToday.ItemHeight = 20;
            this.listSoldForToday.Location = new System.Drawing.Point(108, 12);
            this.listSoldForToday.Margin = new System.Windows.Forms.Padding(4);
            this.listSoldForToday.Name = "listSoldForToday";
            this.listSoldForToday.Size = new System.Drawing.Size(517, 284);
            this.listSoldForToday.TabIndex = 3;
            // 
            // SoldForTodayButton
            // 
            this.SoldForTodayButton.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SoldForTodayButton.Location = new System.Drawing.Point(108, 351);
            this.SoldForTodayButton.Margin = new System.Windows.Forms.Padding(4);
            this.SoldForTodayButton.Name = "SoldForTodayButton";
            this.SoldForTodayButton.Size = new System.Drawing.Size(517, 89);
            this.SoldForTodayButton.TabIndex = 2;
            this.SoldForTodayButton.Text = "ПРОДАДЕНО ЗА ДЕНЯ";
            this.SoldForTodayButton.UseVisualStyleBackColor = true;
            this.SoldForTodayButton.Click += new System.EventHandler(this.SoldForTodayButton_Click);
            // 
            // SoldForToday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 452);
            this.Controls.Add(this.listSoldForToday);
            this.Controls.Add(this.SoldForTodayButton);
            this.Name = "SoldForToday";
            this.Text = "SoldForToday";
            this.ResumeLayout(false);

        }

        #endregion

        public ListBox listSoldForToday;
        private Button SoldForTodayButton;
    }
}