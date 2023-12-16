namespace taskForDB.forms
{
    partial class createOrderWindow
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
            allModelsName_comboBox = new ComboBox();
            SuspendLayout();
            // 
            // allModelsName_comboBox
            // 
            allModelsName_comboBox.FormattingEnabled = true;
            allModelsName_comboBox.Location = new Point(12, 12);
            allModelsName_comboBox.Name = "allModelsName_comboBox";
            allModelsName_comboBox.Size = new Size(121, 23);
            allModelsName_comboBox.TabIndex = 0;
            // 
            // createOrderWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(allModelsName_comboBox);
            Name = "createOrderWindow";
            Text = "Создать заказ";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox allModelsName_comboBox;
    }
}