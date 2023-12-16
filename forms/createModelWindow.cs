using System.Diagnostics;

namespace taskForDB.forms
{
    public partial class createModelWindow : Form
    {
        public string shortFileName, fullFileName;
        public double maxTime, maxBaggage, price;
        public int speed, numberOfPassangers;
        public createModelWindow()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            openFileDialog.Filter = "JPEG files(*.jpg)|*.jpg|All files(*.*)|*.*";
        }

        private void createModel_button_Click(object sender, EventArgs e)
        {
            
            
            if (nameOfModel_textBox.Text != "Введите название модели" & double.TryParse(timeOfModel_textBox.Text,out maxTime)
                & Int32.TryParse(speedOfModel_textBox.Text, out speed) & Int32.TryParse(countPassengers_textBox.Text, out numberOfPassangers)
                & double.TryParse(maxBaggageOfModel_textBox.Text, out maxBaggage) & double.TryParse(priceOfModel_textBox.Text, out price))
            {
                insertDataToDb();
                MessageBox.Show("Добавление модели прошло успешно!");
                Close();
            }
            else
                MessageBox.Show("Не правильные данные!","Ошибка!");
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
                byte[] imageBytes = File.ReadAllBytes(pathOfImage);
                string base64String = Convert.ToBase64String(imageBytes);

                return base64String;
            };
        }
        private void insertDataToDb()
        {
            using (DBContext DB = new DBContext())
            {
                Models models = new Models();
                models.name = nameOfModel_textBox.Text;
                models.max_time = maxTime;
                models.speed = speed;
                models.number_passengers = numberOfPassangers;
                models.max_baggage = maxBaggage;
                models.price = price;
                models.foto = ConvertImageToBase64(fullFileName);

                DB.models.Add(models);
                DB.SaveChanges();
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
        private void nameOfModel_textBox_Enter(object sender, EventArgs e) => updateTextOfTextBox(nameOfModel_textBox, "Введите название модели");
        private void nameOfModel_textBox_Leave(object sender, EventArgs e) => updateTextOfTextBox(nameOfModel_textBox, "Введите название модели");
        private void timeOfModel_textBox_Enter(object sender, EventArgs e) => updateTextOfTextBox(timeOfModel_textBox, "Введите время полета");
        private void timeOfModel_textBox_Leave(object sender, EventArgs e) => updateTextOfTextBox(timeOfModel_textBox, "Введите время полета");
        private void speedOfModel_textBox_Enter(object sender, EventArgs e) => updateTextOfTextBox(speedOfModel_textBox, "Введите скорость");
        private void speedOfModel_textBox_Leave(object sender, EventArgs e) => updateTextOfTextBox(speedOfModel_textBox, "Введите скорость");
        private void countPassengers_textBox_Enter(object sender, EventArgs e) => updateTextOfTextBox(countPassengers_textBox, "Введите кол-во пасажиров");
        private void countPassengers_textBox_Leave(object sender, EventArgs e) => updateTextOfTextBox(countPassengers_textBox, "Введите кол-во пасажиров");
        private void maxBaggageOfModel_textBox_Enter(object sender, EventArgs e) => updateTextOfTextBox(maxBaggageOfModel_textBox, "Введите максимальный вес");
        private void maxBaggageOfModel_textBox_Leave(object sender, EventArgs e) => updateTextOfTextBox(maxBaggageOfModel_textBox, "Введите максимальный вес");
        private void priceOfModel_textBox_Enter(object sender, EventArgs e) => updateTextOfTextBox(priceOfModel_textBox, "Введите цену");
        private void priceOfModel_textBox_Leave(object sender, EventArgs e) => updateTextOfTextBox(priceOfModel_textBox, "Введите цену");
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
