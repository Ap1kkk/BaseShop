namespace AutoPartsShop.View
{
    partial class PaymentHistoryForm
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

        private System.Windows.Forms.DataGridView dgvPaymentHistory;
        private System.Windows.Forms.BindingSource receiptBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiptDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvPaymentHistory = new System.Windows.Forms.DataGridView();
            this.receiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPaymentHistory
            // 
            this.dgvPaymentHistory.AllowUserToAddRows = false;
            this.dgvPaymentHistory.AllowUserToDeleteRows = false;
            this.dgvPaymentHistory.AutoGenerateColumns = false;
            this.dgvPaymentHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaymentHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIdDataGridViewTextBoxColumn,
            this.receiptDateDataGridViewTextBoxColumn,
            this.totalAmountDataGridViewTextBoxColumn});
            this.dgvPaymentHistory.DataSource = this.receiptBindingSource;
            this.dgvPaymentHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPaymentHistory.Location = new System.Drawing.Point(0, 0);
            this.dgvPaymentHistory.Name = "dgvPaymentHistory";
            this.dgvPaymentHistory.ReadOnly = true;
            this.dgvPaymentHistory.Size = new System.Drawing.Size(588, 300);
            this.dgvPaymentHistory.TabIndex = 0;
            // 
            // receiptBindingSource
            // 
            this.receiptBindingSource.DataSource = typeof(AutoPartsShop.Model.Receipt);
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "Идентификатор заказа";
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            this.orderIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderIdDataGridViewTextBoxColumn.Width = 146;
            // 
            // receiptDateDataGridViewTextBoxColumn
            // 
            this.receiptDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.receiptDateDataGridViewTextBoxColumn.DataPropertyName = "ReceiptDate";
            this.receiptDateDataGridViewTextBoxColumn.HeaderText = "Дата оплаты";
            this.receiptDateDataGridViewTextBoxColumn.Name = "receiptDateDataGridViewTextBoxColumn";
            this.receiptDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.receiptDateDataGridViewTextBoxColumn.Width = 101;
            // 
            // totalAmountDataGridViewTextBoxColumn
            // 
            this.totalAmountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.totalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.HeaderText = "Общая сумма";
            this.totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            this.totalAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalAmountDataGridViewTextBoxColumn.Width = 108;
            // 
            // PaymentHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 300);
            this.Controls.Add(this.dgvPaymentHistory);
            this.Name = "PaymentHistoryForm";
            this.Text = "История платежей";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
