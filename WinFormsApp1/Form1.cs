using System.Text.Json;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public List<Patient> patients = new List<Patient>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            string jsonText = File.ReadAllText("C:\\Users\\admin\\Desktop\\json.json");
            patients = JsonSerializer.Deserialize<List<Patient>>(jsonText);
            LoadData();
        }

        private void LoadData()
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = patients;
            //comboBox1.DataSource = null;
            //comboBox1.DataSource = games;
            ////отображение на комбо боксе
            //comboBox1.DisplayMember = "Genre";
            ////значение в комбо боксе
            //comboBox1.ValueMember = "Genre";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            FileStream fileStream = new FileStream("C:\\Users\\admin\\Desktop\\jsonUpload.json", FileMode.OpenOrCreate);
            var test = JsonSerializer.Serialize(patients);
            fileStream.Write(System.Text.Encoding.UTF8.GetBytes(test), 0, test.Length);
            fileStream.Flush();
            fileStream.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            patients.Add(new Patient
            {
                Name = textBoxName.Text,
                Age = Convert.ToInt32(textBoxAge.Text),
                Palata = textBoxPalata.Text
            });
            LoadData();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var patientsWithFilter = from patient in patients
                                     where patient.Age >= Convert.ToInt32(textBoxAgeFilter.Text)
                                     select patient;
            List<Patient> test = patientsWithFilter.ToList();
            dataGridView.DataSource = test;
        }

        private void buttonGroup_Click(object sender, EventArgs e)
        {
            var res = patients.GroupBy(x => x.Palata).Select(x => new
            {
                Name = x.Key,
                Count = x.Count()
            });
            labelGroup.Text = res.Single(x => x.Count == res.Max(y => y.Count)).Name.ToString();
        }
    }
}
