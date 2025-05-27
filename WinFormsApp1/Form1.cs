using System.Text.Json;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public List<Patient> patients = new List<Patient>();
        private const string path = "C:\\Users\\admin\\Desktop\\json.json";
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            if (!File.Exists(path))
            {
                MessageBox.Show("Файл не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var jsonText = File.ReadAllText(path);
            patients = JsonSerializer.Deserialize<List<Patient>>(jsonText);
            LoadData();
        }

        private void LoadData()
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = patients;
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Введите имя пациента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(textBoxAge.Text, out _))
            {
                MessageBox.Show("Введите корректный возраст", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxPalata.Text))
            {
                MessageBox.Show("Введите номер палаты", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate);
            var test = JsonSerializer.Serialize(patients);
            fileStream.Write(System.Text.Encoding.UTF8.GetBytes(test), 0, test.Length);
            fileStream.Flush();
            fileStream.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;
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
