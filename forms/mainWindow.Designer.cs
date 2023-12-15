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
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(776, 244);
            listBox1.TabIndex = 0;
            // 
            // createOrder_button
            // 
            createOrder_button.Location = new Point(603, 377);
            createOrder_button.Name = "createOrder_button";
            createOrder_button.Size = new Size(185, 61);
            createOrder_button.TabIndex = 1;
            createOrder_button.Text = "Добавить заказ";
            createOrder_button.UseVisualStyleBackColor = true;
            createOrder_button.Click += createOrder_button_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(createOrder_button);
            Controls.Add(listBox1);
            Name = "MainWindow";
            Text = "Главная страница";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button createOrder_button;
    }
}
