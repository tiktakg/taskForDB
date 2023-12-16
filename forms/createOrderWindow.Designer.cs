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
            statusOfPayment_comboBox = new ComboBox();
            createOrder_button = new Button();
            paymentOfOrder_textBox = new TextBox();
            totalCostOfOrder_textBox = new TextBox();
            commentOfOrder_textBox = new TextBox();
            SuspendLayout();
            // 
            // allModelsName_comboBox
            // 
            allModelsName_comboBox.FormattingEnabled = true;
            allModelsName_comboBox.Location = new Point(4, 12);
            allModelsName_comboBox.Name = "allModelsName_comboBox";
            allModelsName_comboBox.Size = new Size(152, 23);
            allModelsName_comboBox.TabIndex = 0;
            allModelsName_comboBox.Text = "Выберите название";
            // 
            // statusOfPayment_comboBox
            // 
            statusOfPayment_comboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            statusOfPayment_comboBox.FormattingEnabled = true;
            statusOfPayment_comboBox.Location = new Point(478, 12);
            statusOfPayment_comboBox.Name = "statusOfPayment_comboBox";
            statusOfPayment_comboBox.Size = new Size(152, 23);
            statusOfPayment_comboBox.TabIndex = 1;
            statusOfPayment_comboBox.Tag = "";
            statusOfPayment_comboBox.Text = "Выберите статус";
            // 
            // createOrder_button
            // 
            createOrder_button.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            createOrder_button.AutoEllipsis = true;
            createOrder_button.AutoSize = true;
            createOrder_button.Location = new Point(4, 49);
            createOrder_button.Name = "createOrder_button";
            createOrder_button.Size = new Size(92, 25);
            createOrder_button.TabIndex = 2;
            createOrder_button.Text = "Создать заказ";
            createOrder_button.UseVisualStyleBackColor = true;
            createOrder_button.Click += createOrder_button_Click;
            // 
            // paymentOfOrder_textBox
            // 
            paymentOfOrder_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            paymentOfOrder_textBox.Location = new Point(162, 12);
            paymentOfOrder_textBox.Name = "paymentOfOrder_textBox";
            paymentOfOrder_textBox.Size = new Size(152, 23);
            paymentOfOrder_textBox.TabIndex = 3;
            paymentOfOrder_textBox.Text = "Ввелиие оплату";
            paymentOfOrder_textBox.Enter += paymentOfOrder_textBox_Enter;
            paymentOfOrder_textBox.Leave += paymentOfOrder_textBox_Leave;
            // 
            // totalCostOfOrder_textBox
            // 
            totalCostOfOrder_textBox.Anchor = AnchorStyles.Top;
            totalCostOfOrder_textBox.Location = new Point(320, 12);
            totalCostOfOrder_textBox.Name = "totalCostOfOrder_textBox";
            totalCostOfOrder_textBox.Size = new Size(152, 23);
            totalCostOfOrder_textBox.TabIndex = 4;
            totalCostOfOrder_textBox.Text = "Введите стоимость";
            totalCostOfOrder_textBox.Enter += totalCostOfOrder_textBox_Enter;
            totalCostOfOrder_textBox.Leave += totalCostOfOrder_textBox_Leave;
            // 
            // commentOfOrder_textBox
            // 
            commentOfOrder_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            commentOfOrder_textBox.Location = new Point(636, 12);
            commentOfOrder_textBox.Name = "commentOfOrder_textBox";
            commentOfOrder_textBox.Size = new Size(152, 23);
            commentOfOrder_textBox.TabIndex = 5;
            commentOfOrder_textBox.Text = "Введите коментарий";
            commentOfOrder_textBox.Enter += commentOfOrder_textBox_Enter;
            commentOfOrder_textBox.Leave += commentOfOrder_textBox_Leave;
            // 
            // createOrderWindow
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(796, 92);
            Controls.Add(commentOfOrder_textBox);
            Controls.Add(totalCostOfOrder_textBox);
            Controls.Add(paymentOfOrder_textBox);
            Controls.Add(createOrder_button);
            Controls.Add(statusOfPayment_comboBox);
            Controls.Add(allModelsName_comboBox);
            Name = "createOrderWindow";
            Text = "Создать заказ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox allModelsName_comboBox;
        private ComboBox statusOfPayment_comboBox;
        private Button createOrder_button;
        private TextBox paymentOfOrder_textBox;
        private TextBox totalCostOfOrder_textBox;
        private TextBox commentOfOrder_textBox;
    }
}