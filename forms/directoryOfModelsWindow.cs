using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taskForDB.forms
{
    public partial class directoryOfModelsWindow : Form
    {
        public directoryOfModelsWindow()
        {
            InitializeComponent();
            setDataToDataGrid();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void createModel_button_Click(object sender, EventArgs e)
        {
            createModelWindow createModelWindow = new createModelWindow();
            createModelWindow.ShowDialog();
        }

        private Image convertBase64ToImage(string base64String) 
        {
            Image newImage;
            byte[] bytes = Convert.FromBase64String(base64String);

            using (MemoryStream ms = new MemoryStream(bytes))
                newImage = Image.FromStream(ms);

            return newImage;
        }

        private void setDataToDataGrid()
        {
            List<dataOFModel> listOfModels = new List<dataOFModel>();

            using (DBContext DB = new DBContext())
            {
                var allModels = DB.models.ToList();

                foreach (Models model in allModels)
                {
                    dataOFModel newModel = new dataOFModel(model.name, Convert.ToString(model.max_time), 
                        Convert.ToString(model.speed), Convert.ToString(model.number_passengers),
                        Convert.ToString(model.max_baggage), Convert.ToString(model.price), convertBase64ToImage(model.foto));

                    listOfModels.Add(newModel);
                }
            }
            
           
            dataGridView.DataSource = listOfModels;
        }
    }

    public class dataOFModel
    {
        public string name { get; set; }
        public string maxTime { get; set; }
        public string speed { get; set; }
        public string numberOfPassengers { get; set; }
        public string maxBaggage { get; set; }
        public string price { get; set; }
        public Image image { get; set; }

        public dataOFModel(string name,string maxTime, string speed, string numberOfPassengers, string maxBaggage, string price,Image image)
        {
            this.name = name;
            this.maxTime = maxTime;
            this.speed = speed;
            this.numberOfPassengers = numberOfPassengers;
            this.maxBaggage = maxBaggage;
            this.price = price; 
            this.image = image; 
            
        }
    }

}
