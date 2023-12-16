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
            allModels_dataGrid.Columns["Image"].Width = 220;
            allModels_dataGrid.RowTemplate.Height = 160;

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
            setDataToDataGrid();

        }

        private Image convertBase64ToImage(string base64String) 
        {
            int newWidth = 220, newHeight = 160;
            byte[] bytes = Convert.FromBase64String(base64String);

            Image newImage;
            Bitmap BitMapImage = new Bitmap(newWidth, newHeight);


            using (MemoryStream ms = new MemoryStream(bytes))
                newImage = Image.FromStream(ms);

           

            using (Graphics g = Graphics.FromImage(BitMapImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(newImage, 0, 0, newWidth, newHeight);
            }

            return BitMapImage;
        }

        private void setDataToDataGrid()
        {
            List<dataAboutModel> listOfModels = new List<dataAboutModel>();

            using (DBContext DB = new DBContext())
            {
                var allModels = DB.models.ToList();

                foreach (Models model in allModels)
                {
                    dataAboutModel newModel = new dataAboutModel(model.name, Convert.ToString(model.max_time),
                        Convert.ToString(model.speed), Convert.ToString(model.number_passengers),
                        Convert.ToString(model.max_baggage), Convert.ToString(model.price), convertBase64ToImage(model.foto));

                    listOfModels.Add(newModel);
                }
            }


            allModels_dataGrid.DataSource = listOfModels;
        }
    }

    public class dataAboutModel
    {
        public string name { get; set; }
        public string maxTime { get; set; }
        public string speed { get; set; }
        public string numberOfPassengers { get; set; }
        public string maxBaggage { get; set; }
        public string price { get; set; }
        public Image image { get; set; }

        public dataAboutModel(string name,string maxTime, string speed, string numberOfPassengers, string maxBaggage, string price,Image image)
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
