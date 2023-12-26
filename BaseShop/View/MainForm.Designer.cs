namespace AutoPartsShop.View
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Очистить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">Истина, если управляемые ресурсы должны быть удалены; в противном случае — ложь.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, сгенерированный конструктором форм

        /// <summary>
        /// Обязательный метод для поддержки конструктора — не изменяйте
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.catalogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shoppingCartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PaymentHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catalogToolStripMenuItem,
            this.shoppingCartToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.PaymentHistoryToolStripMenuItem,
            this.profileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(599, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // catalogToolStripMenuItem
            // 
            this.catalogToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.catalogToolStripMenuItem.Name = "catalogToolStripMenuItem";
            this.catalogToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.catalogToolStripMenuItem.Text = "Каталог";
            this.catalogToolStripMenuItem.Click += new System.EventHandler(this.catalogToolStripMenuItem_Click);
            // 
            // shoppingCartToolStripMenuItem
            // 
            this.shoppingCartToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.shoppingCartToolStripMenuItem.Name = "shoppingCartToolStripMenuItem";
            this.shoppingCartToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.shoppingCartToolStripMenuItem.Text = "Корзина товаров";
            this.shoppingCartToolStripMenuItem.Click += new System.EventHandler(this.shoppingCartToolStripMenuItem_Click);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ordersToolStripMenuItem.Text = "Заказы";
            this.ordersToolStripMenuItem.Click += new System.EventHandler(this.ordersToolStripMenuItem_Click);
            // 
            // PaymentHistoryToolStripMenuItem
            // 
            this.PaymentHistoryToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.PaymentHistoryToolStripMenuItem.Name = "PaymentHistoryToolStripMenuItem";
            this.PaymentHistoryToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.PaymentHistoryToolStripMenuItem.Text = "История платежей";
            this.PaymentHistoryToolStripMenuItem.Click += new System.EventHandler(this.PaymentHistoryToolStripMenuItem_Click);
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.profileToolStripMenuItem.Text = "Профиль";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(168, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Магазин автозапчастей";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 178);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Магазин автозапчастей";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem shoppingCartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem PaymentHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogToolStripMenuItem;
    }
}