namespace AutoPartsShop.View
{
    partial class UserProfileForm
    {
        /// <summary>
        /// Обязательная переменная дизайнера.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
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

        #region Код, автоматически созданный конструктором форм Windows

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label AdminLabel;
        private System.Windows.Forms.Label lblAdress;

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.AdminLabel = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(12, 12);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(106, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Имя пользователя:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 38);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(107, 13);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Электронная почта:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LogoutButton);
            this.panel1.Controls.Add(this.LoginButton);
            this.panel1.Location = new System.Drawing.Point(242, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 67);
            this.panel1.TabIndex = 2;
            // 
            // LogoutButton
            // 
            this.LogoutButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.Location = new System.Drawing.Point(12, 8);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(75, 23);
            this.LogoutButton.TabIndex = 1;
            this.LogoutButton.Text = "Выйти";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Location = new System.Drawing.Point(12, 8);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Войти";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // AdminLabel
            // 
            this.AdminLabel.AutoSize = true;
            this.AdminLabel.Location = new System.Drawing.Point(121, 96);
            this.AdminLabel.Name = "AdminLabel";
            this.AdminLabel.Size = new System.Drawing.Size(103, 13);
            this.AdminLabel.TabIndex = 3;
            this.AdminLabel.Text = "Вы администратор";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(12, 63);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(41, 13);
            this.lblAdress.TabIndex = 4;
            this.lblAdress.Text = "Адрес:";
            // 
            // UserProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 118);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.AdminLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblUsername);
            this.Name = "UserProfileForm";
            this.Text = "Профиль пользователя";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
