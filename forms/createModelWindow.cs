using System.Diagnostics;

namespace taskForDB.forms
{
    public partial class createModelWindow : Form
    {
        string shortFileName;
        string fullFileName;

        public createModelWindow()
        {
            InitializeComponent();

            openFileDialog.Filter = "JPEG files(*.jpg)|*.jpg|All files(*.*)|*.*";
        }

        private void createModel_button_Click(object sender, EventArgs e)
        {
            if(nameOfModel_textBox.Text != "Введите название модели" & timeOfModel_textBox.Text != "Введите время полета"
                & speedOfModel_textBox.Text != "Введите скорость" & countPassengers_textBox.Text != "Введите кол-во пасажиров"
                & maxBaggageOfModel_textBox.Text != "Введите максимальный вес" & priceOfModel_textBox.Text != "Введите цену")
            {
                insertDataToDb();
            }
        }

        private void addPhoto_button_Click(object sender, EventArgs e)
        {
           

            if (openFileDialog.ShowDialog() == DialogResult.Cancel) // open file dialog to take path of file 
                return;

            fullFileName = openFileDialog.FileName;
            shortFileName = clearNameText(fullFileName);

            addPhoto_button.Text = shortFileName;

        }
        public string ConvertImageToBase64(string pathOfImage)
        {
            Image image = Image.FromFile(pathOfImage);

            using (MemoryStream m = new MemoryStream())
            {
                image.Save(m, image.RawFormat);
                byte[] imageBytes = m.ToArray();

                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            };
        }
        private void insertDataToDb()
        {
            using(DBContext DB = new DBContext()) 
            {
                //Models models = new Models(nameOfModel_textBox.Text, 1, 1, 1, 1, 1, ConvertImageToBase64(fullFileName));

                //DB.models.Add(models);
                //DB.SaveChanges();
            }
        }
        private string clearNameText(string fileName)
        {
            string newFileName;
            int lastIndex = fileName.LastIndexOf("\\");

            Debug.WriteLine(lastIndex.ToString());
            newFileName = fileName.Substring(lastIndex + 1);

            return newFileName;
        }

        #region get and lost focus of text box
        private void nameOfModel_textBox_Enter(object sender, EventArgs e)
        {

            if (nameOfModel_textBox.Text == "Введите название модели")
                nameOfModel_textBox.Text = "";
        }

        private void nameOfModel_textBox_Leave(object sender, EventArgs e)
        {
            if (nameOfModel_textBox.Text == "")
                nameOfModel_textBox.Text = "Введите название модели";
        }
       

        private void timeOfModel_textBox_Enter(object sender, EventArgs e)
        {

            if (timeOfModel_textBox.Text == "Введите время полета")
                timeOfModel_textBox.Text = "";
        }

        private void timeOfModel_textBox_Leave(object sender, EventArgs e)
        {
            if (timeOfModel_textBox.Text == "")
                timeOfModel_textBox.Text = "Введите время полета";
        }

        private void speedOfModel_textBox_Enter(object sender, EventArgs e)
        {

            if (speedOfModel_textBox.Text == "Введите скорость")
                speedOfModel_textBox.Text = "";
        }

        private void speedOfModel_textBox_Leave(object sender, EventArgs e)
        {
            if (speedOfModel_textBox.Text == "")
                speedOfModel_textBox.Text = "Введите скорость";
        }

        private void countPassengers_textBox_Enter(object sender, EventArgs e)
        {

            if (countPassengers_textBox.Text == "Введите кол-во пасажиров")
                countPassengers_textBox.Text = "";
        }

        private void countPassengers_textBox_Leave(object sender, EventArgs e)
        {
            if (countPassengers_textBox.Text == "")
                countPassengers_textBox.Text = "Введите кол-во пасажиров";
        }

        private void maxBaggageOfModel_textBox_Enter(object sender, EventArgs e)
        {

            if (maxBaggageOfModel_textBox.Text == "Введите максимальный вес")
                maxBaggageOfModel_textBox.Text = "";
        }

        private void maxBaggageOfModel_textBox_Leave(object sender, EventArgs e)
        {
            if (maxBaggageOfModel_textBox.Text == "")
                maxBaggageOfModel_textBox.Text = "Введите максимальный вес";

        }

        private void priceOfModel_textBox_Enter(object sender, EventArgs e)
        {

            if (priceOfModel_textBox.Text == "Введите цену")
                priceOfModel_textBox.Text = "";
        }

        private void priceOfModel_textBox_Leave(object sender, EventArgs e)
        {
            if (priceOfModel_textBox.Text == "")
                priceOfModel_textBox.Text = "Введите цену";
        }
        #endregion
    }
}
