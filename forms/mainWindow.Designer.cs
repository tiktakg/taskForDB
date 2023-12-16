namespace taskForDB
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            createOrder_button = new Button();
            openDirectorys_button = new Button();
            settings_button = new Button();
            close_button = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(776, 379);
            listBox1.TabIndex = 0;
            // 
            // createOrder_button
            // 
            createOrder_button.Location = new Point(622, 408);
            createOrder_button.Name = "createOrder_button";
            createOrder_button.Size = new Size(166, 30);
            createOrder_button.TabIndex = 1;
            createOrder_button.Text = "Добавить заказ";
            createOrder_button.UseVisualStyleBackColor = true;
            createOrder_button.Click += createOrder_button_Click;
            // 
            // openDirectorys_button
            // 
            openDirectorys_button.Location = new Point(425, 408);
            openDirectorys_button.Name = "openDirectorys_button";
            openDirectorys_button.Size = new Size(166, 30);
            openDirectorys_button.TabIndex = 2;
            openDirectorys_button.Text = "Открыть справочник";
            openDirectorys_button.UseVisualStyleBackColor = true;
            openDirectorys_button.Click += openDirectorys_button_Click;
            // 
            // settings_button
            // 
            settings_button.Location = new Point(217, 408);
            settings_button.Name = "settings_button";
            settings_button.Size = new Size(166, 30);
            settings_button.TabIndex = 3;
            settings_button.Text = "Настройки";
            settings_button.UseVisualStyleBackColor = true;
            // 
            // close_button
            // 
            close_button.Location = new Point(12, 408);
            close_button.Name = "close_button";
            close_button.Size = new Size(166, 30);
            close_button.TabIndex = 4;
            close_button.Text = "Выйти";
            close_button.UseVisualStyleBackColor = true;
            close_button.Click += close_button_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(close_button);
            Controls.Add(settings_button);
            Controls.Add(openDirectorys_button);
            Controls.Add(createOrder_button);
            Controls.Add(listBox1);
            Name = "MainWindow";
            Text = "Главная страница";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button createOrder_button;
        private Button openDirectorys_button;
        private Button settings_button;
        private Button close_button;
    }
}
