using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using taskForDB.forms;


namespace taskForDB
{
    public partial class MainWindow : Form
    {
        internal static int idOfUser;
        public MainWindow()
        {
            InitializeComponent();
            takeModelFromDBAndSet();
        }

        private void createOrder_button_Click(object sender, EventArgs e)
        {
            createOrderWindow createOrderWindow = new createOrderWindow();
            createOrderWindow.ShowDialog();
            takeModelFromDBAndSet();
        }

        private void openDirectorys_button_Click(object sender, EventArgs e)
        {
            directoryOfModelsWindow directoryOfModelsWindow = new directoryOfModelsWindow();
            directoryOfModelsWindow.Show();
            this.Close();
        }
        private void close_button_Click(object sender, EventArgs e) => Close();
        private  void takeModelFromDBAndSet()
        {
           List<dataAboutOrder> listOfOrders = new List<dataAboutOrder>();

            using (DBContext DB = new DBContext())
            {
                var allOrders = DB.orders.ToList();

                foreach (Orders model in allOrders)
                {
                    dataAboutOrder newOrder = new dataAboutOrder(model.id_users, model.id_models, model.payment, model.status, model.comment, model.total_coast);
                    listOfOrders.Add(newOrder);
                }
            }
            allOrders_dataGrid.DataSource = listOfOrders;
        }

        public class dataAboutOrder
        {
            public int idOfUser { get; set; }
            public int idOfModel { get; set; }
            public string payment { get; set; }
            public string staus { get; set; }
            public string comment { get; set; }
            public double totalCost { get; set; }

            public dataAboutOrder(int idofUser, int idOfModel, string payment, string staus, string comment, double totalCost)
            {
                this.idOfUser = idofUser;
                this.idOfModel = idOfModel;
                this.payment = payment;
                this.staus = staus;
                this.comment = comment;
                this.totalCost = totalCost;
            }
        }
    }

}
