namespace AutoPartsShop.View
{
    partial class RegisterForm
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

        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox AdressTextBox;
        private System.Windows.Forms.Label AdressLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.CheckBox IsAdminCheckBox;

        /// <summary>
        /// Обязательный метод для поддержки конструктора — не изменяйте
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.AdressTextBox = new System.Windows.Forms.TextBox();
            this.AdressLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.IsAdminCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(9, 16);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(106, 13);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "Имя пользователя:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(9, 41);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(35, 13);
            this.EmailLabel.TabIndex = 1;
            this.EmailLabel.Text = "Email:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(119, 16);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(136, 20);
            this.usernameTextBox.TabIndex = 2;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(119, 40);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(136, 20);
            this.EmailTextBox.TabIndex = 3;
            // 
            // registerButton
            // 
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Location = new System.Drawing.Point(11, 116);
            this.registerButton.Margin = new System.Windows.Forms.Padding(2);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(137, 24);
            this.registerButton.TabIndex = 4;
            this.registerButton.Text = "Зарегистрироваться";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // AdressTextBox
            // 
            this.AdressTextBox.Location = new System.Drawing.Point(119, 64);
            this.AdressTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.AdressTextBox.Name = "AdressTextBox";
            this.AdressTextBox.Size = new System.Drawing.Size(136, 20);
            this.AdressTextBox.TabIndex = 6;
            // 
            // AdressLabel
            // 
            this.AdressLabel.AutoSize = true;
            this.AdressLabel.Location = new System.Drawing.Point(9, 65);
            this.AdressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AdressLabel.Name = "AdressLabel";
            this.AdressLabel.Size = new System.Drawing.Size(41, 13);
            this.AdressLabel.TabIndex = 5;
            this.AdressLabel.Text = "Адрес:";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(119, 88);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(136, 20);
            this.PasswordTextBox.TabIndex = 8;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(9, 89);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(48, 13);
            this.PasswordLabel.TabIndex = 7;
            this.PasswordLabel.Text = "Пароль:";
            // 
            // IsAdminCheckBox
            // 
            this.IsAdminCheckBox.AutoSize = true;
            this.IsAdminCheckBox.Location = new System.Drawing.Point(153, 119);
            this.IsAdminCheckBox.Name = "IsAdminCheckBox";
            this.IsAdminCheckBox.Size = new System.Drawing.Size(105, 17);
            this.IsAdminCheckBox.TabIndex = 9;
            this.IsAdminCheckBox.Text = "Администратор";
            this.IsAdminCheckBox.UseVisualStyleBackColor = true;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 148);
            this.Controls.Add(this.IsAdminCheckBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.AdressTextBox);
            this.Controls.Add(this.AdressLabel);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegisterForm";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
