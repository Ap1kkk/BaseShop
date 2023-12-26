namespace AutoPartsShop.View
{
    partial class CatalogForm
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

        private void InitializeComponent()
        {
            this.catalogDataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AddProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToShoppingCartButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.catalogDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // catalogDataGridView
            // 
            this.catalogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.catalogDataGridView.Location = new System.Drawing.Point(11, 29);
            this.catalogDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.catalogDataGridView.Name = "catalogDataGridView";
            this.catalogDataGridView.RowTemplate.Height = 24;
            this.catalogDataGridView.Size = new System.Drawing.Size(970, 348);
            this.catalogDataGridView.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddProductToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(992, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AddProductToolStripMenuItem
            // 
            this.AddProductToolStripMenuItem.Name = "AddProductToolStripMenuItem";
            this.AddProductToolStripMenuItem.Size = new System.Drawing.Size(144, 20);
            this.AddProductToolStripMenuItem.Text = "Добавить новый товар";
            this.AddProductToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // AddToShoppingCartButton
            // 
            this.AddToShoppingCartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddToShoppingCartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddToShoppingCartButton.Location = new System.Drawing.Point(422, 381);
            this.AddToShoppingCartButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddToShoppingCartButton.Name = "AddToShoppingCartButton";
            this.AddToShoppingCartButton.Size = new System.Drawing.Size(151, 31);
            this.AddToShoppingCartButton.TabIndex = 5;
            this.AddToShoppingCartButton.Text = "Добавить в корзину";
            this.AddToShoppingCartButton.UseVisualStyleBackColor = true;
            this.AddToShoppingCartButton.Click += new System.EventHandler(this.AddToShoppingCartButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(777, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Фильтр:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // filterTextBox
            // 
            this.filterTextBox.Location = new System.Drawing.Point(854, 4);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(111, 20);
            this.filterTextBox.TabIndex = 7;
            this.filterTextBox.TextChanged += new System.EventHandler(this.filterTextBox_TextChanged);
            // 
            // CatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 420);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filterTextBox);
            this.Controls.Add(this.AddToShoppingCartButton);
            this.Controls.Add(this.catalogDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CatalogForm";
            this.Text = "Каталог товаров";
            ((System.ComponentModel.ISupportInitialize)(this.catalogDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView catalogDataGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AddProductToolStripMenuItem;
        private System.Windows.Forms.Button AddToShoppingCartButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filterTextBox;
    }
}
