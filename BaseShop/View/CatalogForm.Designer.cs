namespace SportsNutritionShop.View
{
    partial class CatalogForm
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
        private System.Windows.Forms.Button closeButton;

        private void InitializeComponent()
        {
            this.closeButton = new System.Windows.Forms.Button();
            this.catgalogDataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AddProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToShoppingCartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.catgalogDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(11, 381);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(72, 31);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // catgalogDataGridView
            // 
            this.catgalogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.catgalogDataGridView.Location = new System.Drawing.Point(11, 26);
            this.catgalogDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.catgalogDataGridView.Name = "catgalogDataGridView";
            this.catgalogDataGridView.RowTemplate.Height = 24;
            this.catgalogDataGridView.Size = new System.Drawing.Size(970, 351);
            this.catgalogDataGridView.TabIndex = 3;
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
            this.AddProductToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.AddProductToolStripMenuItem.Text = "Add new product";
            this.AddProductToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // AddToShoppingCartButton
            // 
            this.AddToShoppingCartButton.Location = new System.Drawing.Point(422, 381);
            this.AddToShoppingCartButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddToShoppingCartButton.Name = "AddToShoppingCartButton";
            this.AddToShoppingCartButton.Size = new System.Drawing.Size(151, 31);
            this.AddToShoppingCartButton.TabIndex = 5;
            this.AddToShoppingCartButton.Text = "Add to shopping cart";
            this.AddToShoppingCartButton.UseVisualStyleBackColor = true;
            this.AddToShoppingCartButton.Click += new System.EventHandler(this.AddToShoppingCartButton_Click);
            // 
            // CatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 411);
            this.Controls.Add(this.AddToShoppingCartButton);
            this.Controls.Add(this.catgalogDataGridView);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CatalogForm";
            this.Text = "Product Catalog";
            this.Load += new System.EventHandler(this.CatalogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.catgalogDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView catgalogDataGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AddProductToolStripMenuItem;
        private System.Windows.Forms.Button AddToShoppingCartButton;
    }
}