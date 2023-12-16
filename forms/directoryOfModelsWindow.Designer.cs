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
            allModels_dataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)allModels_dataGrid).BeginInit();
            SuspendLayout();
            // 
            // back_button
            // 
            back_button.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            back_button.Location = new Point(12, 582);
            back_button.Name = "back_button";
            back_button.Size = new Size(181, 29);
            back_button.TabIndex = 9;
            back_button.Text = "Назад";
            back_button.UseVisualStyleBackColor = true;
            back_button.Click += back_button_Click;
            // 
            // createModel_button
            // 
            createModel_button.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            createModel_button.Location = new Point(691, 582);
            createModel_button.Name = "createModel_button";
            createModel_button.Size = new Size(181, 29);
            createModel_button.TabIndex = 6;
            createModel_button.Text = "Добавить модель";
            createModel_button.UseVisualStyleBackColor = true;
            createModel_button.Click += createModel_button_Click;
            // 
            // allModels_dataGrid
            // 
            allModels_dataGrid.AllowUserToOrderColumns = true;
            allModels_dataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            allModels_dataGrid.BackgroundColor = SystemColors.ControlLight;
            allModels_dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            allModels_dataGrid.Location = new Point(12, 12);
            allModels_dataGrid.Name = "allModels_dataGrid";
            allModels_dataGrid.Size = new Size(860, 564);
            allModels_dataGrid.TabIndex = 10;
            // 
            // directoryOfModelsWindow
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(884, 623);
            Controls.Add(allModels_dataGrid);
            Controls.Add(back_button);
            Controls.Add(createModel_button);
            Name = "directoryOfModelsWindow";
            Text = "Модели";
            ((System.ComponentModel.ISupportInitialize)allModels_dataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button back_button;
        private Button settings_button;
        private Button openDirectorys_button;
        private Button createModel_button;
        private DataGridView allModels_dataGrid;
    }
}