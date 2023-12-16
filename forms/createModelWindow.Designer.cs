namespace taskForDB.forms
{
    partial class createModelWindow
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
            createModel_button = new Button();
            nameOfModel_textBox = new TextBox();
            timeOfModel_textBox = new TextBox();
            countPassengers_textBox = new TextBox();
            speedOfModel_textBox = new TextBox();
            maxBaggageOfModel_textBox = new TextBox();
            addPhoto_button = new Button();
            priceOfModel_textBox = new TextBox();
            openFileDialog = new OpenFileDialog();
            SuspendLayout();
            // 
            // createModel_button
            // 
            createModel_button.Location = new Point(596, 61);
            createModel_button.Name = "createModel_button";
            createModel_button.Size = new Size(175, 24);
            createModel_button.TabIndex = 7;
            createModel_button.Text = "Добавить модель";
            createModel_button.UseVisualStyleBackColor = true;
            createModel_button.Click += createModel_button_Click;
            // 
            // nameOfModel_textBox
            // 
            nameOfModel_textBox.BackColor = SystemColors.InactiveBorder;
            nameOfModel_textBox.BorderStyle = BorderStyle.FixedSingle;
            nameOfModel_textBox.ForeColor = SystemColors.WindowText;
            nameOfModel_textBox.Location = new Point(12, 17);
            nameOfModel_textBox.Name = "nameOfModel_textBox";
            nameOfModel_textBox.Size = new Size(170, 23);
            nameOfModel_textBox.TabIndex = 8;
            nameOfModel_textBox.Text = "Введите название модели";
            nameOfModel_textBox.Enter += nameOfModel_textBox_Enter;
            nameOfModel_textBox.Leave += nameOfModel_textBox_Leave;
            // 
            // timeOfModel_textBox
            // 
            timeOfModel_textBox.BackColor = SystemColors.InactiveBorder;
            timeOfModel_textBox.BorderStyle = BorderStyle.FixedSingle;
            timeOfModel_textBox.ForeColor = SystemColors.WindowText;
            timeOfModel_textBox.Location = new Point(200, 17);
            timeOfModel_textBox.Name = "timeOfModel_textBox";
            timeOfModel_textBox.Size = new Size(170, 23);
            timeOfModel_textBox.TabIndex = 9;
            timeOfModel_textBox.Text = "Введите время полета";
            timeOfModel_textBox.Enter += timeOfModel_textBox_Enter;
            timeOfModel_textBox.Leave += timeOfModel_textBox_Leave;
            // 
            // countPassengers_textBox
            // 
            countPassengers_textBox.BackColor = SystemColors.InactiveBorder;
            countPassengers_textBox.BorderStyle = BorderStyle.FixedSingle;
            countPassengers_textBox.ForeColor = SystemColors.WindowText;
            countPassengers_textBox.Location = new Point(12, 62);
            countPassengers_textBox.Name = "countPassengers_textBox";
            countPassengers_textBox.Size = new Size(170, 23);
            countPassengers_textBox.TabIndex = 11;
            countPassengers_textBox.Text = "Введите кол-во пасажиров";
            countPassengers_textBox.Enter += countPassengers_textBox_Enter;
            countPassengers_textBox.Leave += countPassengers_textBox_Leave;
            // 
            // speedOfModel_textBox
            // 
            speedOfModel_textBox.BackColor = SystemColors.InactiveBorder;
            speedOfModel_textBox.BorderStyle = BorderStyle.FixedSingle;
            speedOfModel_textBox.ForeColor = SystemColors.WindowText;
            speedOfModel_textBox.Location = new Point(387, 17);
            speedOfModel_textBox.Name = "speedOfModel_textBox";
            speedOfModel_textBox.Size = new Size(170, 23);
            speedOfModel_textBox.TabIndex = 10;
            speedOfModel_textBox.Text = "Введите скорость";
            speedOfModel_textBox.Enter += speedOfModel_textBox_Enter;
            speedOfModel_textBox.Leave += speedOfModel_textBox_Leave;
            // 
            // maxBaggageOfModel_textBox
            // 
            maxBaggageOfModel_textBox.BackColor = SystemColors.InactiveBorder;
            maxBaggageOfModel_textBox.BorderStyle = BorderStyle.FixedSingle;
            maxBaggageOfModel_textBox.ForeColor = SystemColors.WindowText;
            maxBaggageOfModel_textBox.Location = new Point(200, 62);
            maxBaggageOfModel_textBox.Name = "maxBaggageOfModel_textBox";
            maxBaggageOfModel_textBox.Size = new Size(170, 23);
            maxBaggageOfModel_textBox.TabIndex = 12;
            maxBaggageOfModel_textBox.Text = "Введите максимальный вес";
            maxBaggageOfModel_textBox.Enter += maxBaggageOfModel_textBox_Enter;
            maxBaggageOfModel_textBox.Leave += maxBaggageOfModel_textBox_Leave;
            // 
            // addPhoto_button
            // 
            addPhoto_button.Location = new Point(596, 16);
            addPhoto_button.Name = "addPhoto_button";
            addPhoto_button.Size = new Size(175, 23);
            addPhoto_button.TabIndex = 13;
            addPhoto_button.Text = "Добавить фото";
            addPhoto_button.UseVisualStyleBackColor = true;
            addPhoto_button.Click += addPhoto_button_Click;
            // 
            // priceOfModel_textBox
            // 
            priceOfModel_textBox.BackColor = SystemColors.InactiveBorder;
            priceOfModel_textBox.BorderStyle = BorderStyle.FixedSingle;
            priceOfModel_textBox.ForeColor = SystemColors.WindowText;
            priceOfModel_textBox.Location = new Point(387, 62);
            priceOfModel_textBox.Name = "priceOfModel_textBox";
            priceOfModel_textBox.Size = new Size(170, 23);
            priceOfModel_textBox.TabIndex = 14;
            priceOfModel_textBox.Text = "Введите цену";
            priceOfModel_textBox.Enter += priceOfModel_textBox_Enter;
            priceOfModel_textBox.Leave += priceOfModel_textBox_Leave;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // createModelWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 104);
            Controls.Add(priceOfModel_textBox);
            Controls.Add(addPhoto_button);
            Controls.Add(maxBaggageOfModel_textBox);
            Controls.Add(countPassengers_textBox);
            Controls.Add(speedOfModel_textBox);
            Controls.Add(timeOfModel_textBox);
            Controls.Add(nameOfModel_textBox);
            Controls.Add(createModel_button);
            ForeColor = SystemColors.ControlText;
            Name = "createModelWindow";
            Text = "Создание модели";
            TransparencyKey = Color.White;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button createModel_button;
        private TextBox nameOfModel_textBox;
        private TextBox timeOfModel_textBox;
        private TextBox countPassengers_textBox;
        private TextBox speedOfModel_textBox;
        private TextBox maxBaggageOfModel_textBox;
        private Button addPhoto_button;
        private TextBox priceOfModel_textBox;
        private OpenFileDialog openFileDialog;
    }
}