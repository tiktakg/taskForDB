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
        internal int idOfUser;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void createOrder_button_Click(object sender, EventArgs e)
        {

        }

        private void openDirectorys_button_Click(object sender, EventArgs e)
        {
            directoryOfModelsWindow directoryOfModelsWindow = new directoryOfModelsWindow();
            directoryOfModelsWindow.Show();
            this.Close();
        }
        private void close_button_Click(object sender, EventArgs e) => Close();

     
    }

}
