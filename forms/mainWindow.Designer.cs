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
            createOrder_button = new Button();
            openDirectorys_button = new Button();
            settings_button = new Button();
            close_button = new Button();
            allOrders_dataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)allOrders_dataGrid).BeginInit();
            SuspendLayout();
            // 
            // createOrder_button
            // 
            createOrder_button.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
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
            openDirectorys_button.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
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
            settings_button.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            settings_button.Location = new Point(211, 408);
            settings_button.Name = "settings_button";
            settings_button.Size = new Size(166, 30);
            settings_button.TabIndex = 3;
            settings_button.Text = "Настройки";
            settings_button.UseVisualStyleBackColor = true;
            // 
            // close_button
            // 
            close_button.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            close_button.Location = new Point(12, 408);
            close_button.Name = "close_button";
            close_button.Size = new Size(166, 30);
            close_button.TabIndex = 4;
            close_button.Text = "Выйти";
            close_button.UseVisualStyleBackColor = true;
            close_button.Click += close_button_Click;
            // 
            // allOrders_dataGrid
            // 
            allOrders_dataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            allOrders_dataGrid.BackgroundColor = SystemColors.ControlLight;
            allOrders_dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            allOrders_dataGrid.GridColor = Color.White;
            allOrders_dataGrid.Location = new Point(12, 12);
            allOrders_dataGrid.Name = "allOrders_dataGrid";
            allOrders_dataGrid.Size = new Size(776, 390);
            allOrders_dataGrid.TabIndex = 5;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(allOrders_dataGrid);
            Controls.Add(close_button);
            Controls.Add(settings_button);
            Controls.Add(openDirectorys_button);
            Controls.Add(createOrder_button);
            Name = "MainWindow";
            Text = "Главная страница";
            ((System.ComponentModel.ISupportInitialize)allOrders_dataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button createOrder_button;
        private Button openDirectorys_button;
        private Button settings_button;
        private Button close_button;
        private DataGridView allOrders_dataGrid;
    }
}
