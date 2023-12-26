namespace AutoPartsShop.View
{
    partial class OrderDetailsForm
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

        private System.Windows.Forms.Label orderIdLabel;
        private System.Windows.Forms.Label orderDateLabel;
        private System.Windows.Forms.DataGridView orderItemsDataGridView;

        private void InitializeComponent()
        {
            this.orderIdLabel = new System.Windows.Forms.Label();
            this.orderDateLabel = new System.Windows.Forms.Label();
            this.orderItemsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // orderIdLabel
            // 
            this.orderIdLabel.AutoSize = true;
            this.orderIdLabel.Location = new System.Drawing.Point(9, 7);
            this.orderIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderIdLabel.Name = "orderIdLabel";
            this.orderIdLabel.Size = new System.Drawing.Size(83, 13);
            this.orderIdLabel.TabIndex = 0;
            this.orderIdLabel.Text = "Номер заказа:";
            // 
            // orderDateLabel
            // 
            this.orderDateLabel.AutoSize = true;
            this.orderDateLabel.Location = new System.Drawing.Point(9, 31);
            this.orderDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderDateLabel.Name = "orderDateLabel";
            this.orderDateLabel.Size = new System.Drawing.Size(75, 13);
            this.orderDateLabel.TabIndex = 1;
            this.orderDateLabel.Text = "Дата заказа:";
            // 
            // orderItemsDataGridView
            // 
            this.orderItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderItemsDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.orderItemsDataGridView.Location = new System.Drawing.Point(0, 58);
            this.orderItemsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.orderItemsDataGridView.Name = "orderItemsDataGridView";
            this.orderItemsDataGridView.RowTemplate.Height = 24;
            this.orderItemsDataGridView.Size = new System.Drawing.Size(958, 267);
            this.orderItemsDataGridView.TabIndex = 2;
            // 
            // OrderDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 325);
            this.Controls.Add(this.orderItemsDataGridView);
            this.Controls.Add(this.orderDateLabel);
            this.Controls.Add(this.orderIdLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OrderDetailsForm";
            this.Text = "Детали заказа";
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
