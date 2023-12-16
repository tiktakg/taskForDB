using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace taskForDB.forms
{
    public partial class createOrderWindow : Form
    {
        public createOrderWindow()
        {
            InitializeComponent();
            takeModelFromDBAndSet();
            setStausOfPaymentToComboBox();

            FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private void takeModelFromDBAndSet()
        {
            using (DBContext DB = new DBContext())
            {
                var allModels = DB.models.ToList();

                foreach (Models model in allModels)
                    allModelsName_comboBox.Items.Add(model.name);
            }
        }

        private void setStausOfPaymentToComboBox()
        {
            statusOfPayment_comboBox.Items.Add("Не оплачено");
            statusOfPayment_comboBox.Items.Add("Оплачено");
        }

        private void createOrder_button_Click(object sender, EventArgs e)
        {
            double totalCostOfOrder;
            if (paymentOfOrder_textBox.Text != "Ввелиие оплату" & totalCostOfOrder_textBox.Text != "Введите стоимость"
                & commentOfOrder_textBox.Text != "Введите коментарий" & double.TryParse(totalCostOfOrder_textBox.Text, out totalCostOfOrder))
            {
                using (DBContext DB = new DBContext())
                {
                    Orders newOrder = new Orders();

                    newOrder.id_users = MainWindow.idOfUser;
                    newOrder.id_models = findIndexOfSelectedItem(allModelsName_comboBox.SelectedItem.ToString());
                    newOrder.payment = paymentOfOrder_textBox.Text;
                    newOrder.total_coast = totalCostOfOrder;
                    newOrder.status = statusOfPayment_comboBox.SelectedItem.ToString();
                    newOrder.comment = commentOfOrder_textBox.Text;

                    DB.orders.Add(newOrder);
                    DB.SaveChanges();
                }
                MessageBox.Show("Добавление заказа прошло успешно!");
                Close();
            }
            else
                MessageBox.Show("Не правильные данные!", "Ошибка!");
        }

        private int findIndexOfSelectedItem(string selectedModelName)
        {
            using (DBContext DB = new DBContext())
            {
                var allModels = DB.models.ToList();

                foreach (Models model in allModels)
                    if (model.name == selectedModelName)
                        return model.id_models;
            }

            return -1;
        }

        #region get and lost focus of text box
        private void paymentOfOrder_textBox_Enter(object sender, EventArgs e) => updateTextOfTextBox(paymentOfOrder_textBox, "Ввелиие оплату");
        private void paymentOfOrder_textBox_Leave(object sender, EventArgs e) => updateTextOfTextBox(paymentOfOrder_textBox, "Ввелиие оплату");
        private void totalCostOfOrder_textBox_Enter(object sender, EventArgs e) => updateTextOfTextBox(totalCostOfOrder_textBox, "Введите стоимость");
        private void totalCostOfOrder_textBox_Leave(object sender, EventArgs e) => updateTextOfTextBox(totalCostOfOrder_textBox, "Введите стоимость");
        private void commentOfOrder_textBox_Enter(object sender, EventArgs e) => updateTextOfTextBox(commentOfOrder_textBox, "Введите коментарий");
        private void commentOfOrder_textBox_Leave(object sender, EventArgs e) => updateTextOfTextBox(commentOfOrder_textBox, "Введите коментарий");
        private void updateTextOfTextBox(TextBox textBox, string textToWrite)
        {
            if (textBox.Text == textToWrite)
                textBox.Text = "";
            else if (textBox.Text == "")
                textBox.Text = textToWrite;
        }
        #endregion
    }
}
