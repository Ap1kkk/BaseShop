namespace AutoPartsShop.View
{
    partial class ShoppingCartForm
    {
        /// <summary>
        /// Обязательная переменная дизайнера.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Очистить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">Истинно, если управляемые ресурсы должны быть удалены; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, сгенерированный конструктором формы
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.DataGridView ShoppingCartDataGridView;
        private System.Windows.Forms.Button OrderButton;

        /// <summary>
        /// Обязательный метод для поддержки конструктора — не изменяйте
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.clearButton = new System.Windows.Forms.Button();
            this.ShoppingCartDataGridView = new System.Windows.Forms.DataGridView();
            this.OrderButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ShoppingCartDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // clearButton
            // 
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Location = new System.Drawing.Point(444, 214);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(86, 28);
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
            this.OrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderButton.Location = new System.Drawing.Point(9, 214);
            this.OrderButton.Margin = new System.Windows.Forms.Padding(2);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(90, 28);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ShoppingCartForm";
            this.Text = "Корзина";
            ((System.ComponentModel.ISupportInitialize)(this.ShoppingCartDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
