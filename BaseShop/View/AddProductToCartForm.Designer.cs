namespace AutoPartsShop.View
{
    partial class AddProductToCartForm
    {
        /// <summary>
        /// Обязательная переменная дизайнера.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Очистить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">true, если управляемые ресурсы должны быть удалены; в противном случае — ложь.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, сгенерированный конструктором формы

        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnAddToCart;

        private void InitializeComponent()
        {
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.ProductNameLabel = new System.Windows.Forms.TextBox();
            this.quantityUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.quantityUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(12, 15);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(98, 13);
            this.lblProduct.TabIndex = 1;
            this.lblProduct.Text = "Название товара:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(12, 41);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(69, 13);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Количество:";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.Location = new System.Drawing.Point(83, 75);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(137, 23);
            this.btnAddToCart.TabIndex = 4;
            this.btnAddToCart.Text = "Добавить";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.Location = new System.Drawing.Point(116, 15);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(168, 20);
            this.ProductNameLabel.TabIndex = 5;
            // 
            // quantityUpDown
            // 
            this.quantityUpDown.Location = new System.Drawing.Point(116, 41);
            this.quantityUpDown.Name = "quantityUpDown";
            this.quantityUpDown.Size = new System.Drawing.Size(168, 20);
            this.quantityUpDown.TabIndex = 6;
            // 
            // AddProductToCartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 110);
            this.Controls.Add(this.quantityUpDown);
            this.Controls.Add(this.ProductNameLabel);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblProduct);
            this.Name = "AddProductToCartForm";
            this.Text = "Добавить в корзину";
            ((System.ComponentModel.ISupportInitialize)(this.quantityUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.TextBox ProductNameLabel;
        private System.Windows.Forms.NumericUpDown quantityUpDown;
    }
}
