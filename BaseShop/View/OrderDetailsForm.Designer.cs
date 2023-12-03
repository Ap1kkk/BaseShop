namespace SportsNutritionShop.View
{
    partial class OrderDetailsForm
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

        private System.Windows.Forms.Label orderIdLabel;
        private System.Windows.Forms.Label orderDateLabel;
        private System.Windows.Forms.DataGridView orderItemsDataGridView;
        private System.Windows.Forms.Button closeButton;

        private void InitializeComponent()
        {
            this.orderIdLabel = new System.Windows.Forms.Label();
            this.orderDateLabel = new System.Windows.Forms.Label();
            this.orderItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // orderIdLabel
            // 
            this.orderIdLabel.AutoSize = true;
            this.orderIdLabel.Location = new System.Drawing.Point(9, 7);
            this.orderIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderIdLabel.Name = "orderIdLabel";
            this.orderIdLabel.Size = new System.Drawing.Size(50, 13);
            this.orderIdLabel.TabIndex = 0;
            this.orderIdLabel.Text = "Order ID:";
            // 
            // orderDateLabel
            // 
            this.orderDateLabel.AutoSize = true;
            this.orderDateLabel.Location = new System.Drawing.Point(9, 31);
            this.orderDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderDateLabel.Name = "orderDateLabel";
            this.orderDateLabel.Size = new System.Drawing.Size(62, 13);
            this.orderDateLabel.TabIndex = 1;
            this.orderDateLabel.Text = "Order Date:";
            // 
            // orderItemsDataGridView
            // 
            this.orderItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderItemsDataGridView.Location = new System.Drawing.Point(9, 58);
            this.orderItemsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.orderItemsDataGridView.Name = "orderItemsDataGridView";
            this.orderItemsDataGridView.RowTemplate.Height = 24;
            this.orderItemsDataGridView.Size = new System.Drawing.Size(938, 226);
            this.orderItemsDataGridView.TabIndex = 2;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(9, 288);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(62, 26);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // OrderDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 325);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.orderItemsDataGridView);
            this.Controls.Add(this.orderDateLabel);
            this.Controls.Add(this.orderIdLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OrderDetailsForm";
            this.Text = "Order Details";
            this.Load += new System.EventHandler(this.OrderDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}