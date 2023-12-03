namespace SportsNutritionShop.View
{
    partial class ShoppingCartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up all resources being used.
        /// </summary>
        /// <param name="disposing">True, if the managed resources should be disposed; otherwise, false.</param>
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
            this.closeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.ShoppingCartDataGridView = new System.Windows.Forms.DataGridView();
            this.OrderButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ShoppingCartDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(9, 214);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(67, 28);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Закрыть";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(464, 214);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(66, 28);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // ShoppingCartDataGridView
            // 
            this.ShoppingCartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShoppingCartDataGridView.Location = new System.Drawing.Point(9, 12);
            this.ShoppingCartDataGridView.Name = "ShoppingCartDataGridView";
            this.ShoppingCartDataGridView.Size = new System.Drawing.Size(521, 197);
            this.ShoppingCartDataGridView.TabIndex = 3;
            // 
            // OrderButton
            // 
            this.OrderButton.Location = new System.Drawing.Point(242, 214);
            this.OrderButton.Margin = new System.Windows.Forms.Padding(2);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(66, 28);
            this.OrderButton.TabIndex = 4;
            this.OrderButton.Text = "Заказать";
            this.OrderButton.UseVisualStyleBackColor = true;
            this.OrderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // ShoppingCartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 244);
            this.Controls.Add(this.OrderButton);
            this.Controls.Add(this.ShoppingCartDataGridView);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.closeButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ShoppingCartForm";
            this.Text = "Shopping Cart";
            this.Load += new System.EventHandler(this.ShoppingCartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ShoppingCartDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.DataGridView ShoppingCartDataGridView;
        private System.Windows.Forms.Button OrderButton;
    }

}