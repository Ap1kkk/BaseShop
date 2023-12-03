﻿namespace SportsNutritionShop.View
{
    partial class OrdersForm
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
        private System.Windows.Forms.Button viewDetailsButton;
        private System.Windows.Forms.Button closeButton;

        private void InitializeComponent()
        {
            this.viewDetailsButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.OrdersDataGridView = new System.Windows.Forms.DataGridView();
            this.PayButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // viewDetailsButton
            // 
            this.viewDetailsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewDetailsButton.Location = new System.Drawing.Point(11, 253);
            this.viewDetailsButton.Margin = new System.Windows.Forms.Padding(2);
            this.viewDetailsButton.Name = "viewDetailsButton";
            this.viewDetailsButton.Size = new System.Drawing.Size(101, 30);
            this.viewDetailsButton.TabIndex = 1;
            this.viewDetailsButton.Text = "See details";
            this.viewDetailsButton.UseVisualStyleBackColor = true;
            this.viewDetailsButton.Click += new System.EventHandler(this.viewDetailsButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.closeButton.Location = new System.Drawing.Point(635, 253);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(62, 30);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // OrdersDataGridView
            // 
            this.OrdersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.OrdersDataGridView.Location = new System.Drawing.Point(0, 0);
            this.OrdersDataGridView.Name = "OrdersDataGridView";
            this.OrdersDataGridView.Size = new System.Drawing.Size(708, 236);
            this.OrdersDataGridView.TabIndex = 3;
            // 
            // PayButton
            // 
            this.PayButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PayButton.Location = new System.Drawing.Point(321, 253);
            this.PayButton.Margin = new System.Windows.Forms.Padding(2);
            this.PayButton.Name = "PayButton";
            this.PayButton.Size = new System.Drawing.Size(71, 30);
            this.PayButton.TabIndex = 4;
            this.PayButton.Text = "Pay for";
            this.PayButton.UseVisualStyleBackColor = true;
            this.PayButton.Click += new System.EventHandler(this.PayButton_Click);
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 294);
            this.Controls.Add(this.PayButton);
            this.Controls.Add(this.OrdersDataGridView);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.viewDetailsButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OrdersForm";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView OrdersDataGridView;
        private System.Windows.Forms.Button PayButton;
    }
}