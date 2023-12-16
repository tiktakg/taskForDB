namespace taskForDB.forms
{
    partial class directoryOfModelsWindow
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
            back_button = new Button();
            createModel_button = new Button();
            dataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // back_button
            // 
            back_button.Location = new Point(12, 408);
            back_button.Name = "back_button";
            back_button.Size = new Size(166, 30);
            back_button.TabIndex = 9;
            back_button.Text = "Назад";
            back_button.UseVisualStyleBackColor = true;
            back_button.Click += back_button_Click;
            // 
            // createModel_button
            // 
            createModel_button.Location = new Point(622, 408);
            createModel_button.Name = "createModel_button";
            createModel_button.Size = new Size(166, 30);
            createModel_button.TabIndex = 6;
            createModel_button.Text = "Добавить модель";
            createModel_button.UseVisualStyleBackColor = true;
            createModel_button.Click += createModel_button_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToOrderColumns = true;
            dataGridView.BackgroundColor = SystemColors.ControlLight;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 12);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(776, 390);
            dataGridView.TabIndex = 10;
            // 
            // directoryOfModelsWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView);
            Controls.Add(back_button);
            Controls.Add(createModel_button);
            Name = "directoryOfModelsWindow";
            Text = "Модели";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button back_button;
        private Button settings_button;
        private Button openDirectorys_button;
        private Button createModel_button;
        private DataGridView dataGridView;
    }
}