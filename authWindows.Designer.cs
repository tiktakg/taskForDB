namespace taskForDB
{
    partial class authWindow
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            login_textBox = new TextBox();
            password_textBox = new TextBox();
            auth_button = new Button();
            SuspendLayout();
            // 
            // login_textBox
            // 
            login_textBox.Location = new Point(35, 36);
            login_textBox.Name = "login_textBox";
            login_textBox.Size = new Size(223, 23);
            login_textBox.TabIndex = 0;
            login_textBox.Text = "Введите логин";
            login_textBox.TextChanged += login_textBox_TextChanged;
            // 
            // password_textBox
            // 
            password_textBox.Location = new Point(311, 36);
            password_textBox.Name = "password_textBox";
            password_textBox.Size = new Size(223, 23);
            password_textBox.TabIndex = 1;
            password_textBox.Text = "Введите пароль";
            password_textBox.TextChanged += password_textBox_TextChanged;
            // 
            // auth_button
            // 
            auth_button.Location = new Point(35, 118);
            auth_button.Name = "auth_button";
            auth_button.Size = new Size(119, 43);
            auth_button.TabIndex = 2;
            auth_button.Text = "Войти";
            auth_button.UseVisualStyleBackColor = true;
            // 
            // authWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 189);
            Controls.Add(auth_button);
            Controls.Add(password_textBox);
            Controls.Add(login_textBox);
            Name = "authWindow";
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox login_textBox;
        private TextBox password_textBox;
        private Button auth_button;
    }
}