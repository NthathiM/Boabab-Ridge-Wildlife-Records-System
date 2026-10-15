using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baobab_Ridge_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ConfigureAnimalGrid();
            LoadAnimals();
        }

        private void ConfigureAnimalGrid()
        {
            dgvAnimals.Columns.Clear();
            dgvAnimals.AutoGenerateColumns = false;
            dgvAnimals.ReadOnly = true;
            dgvAnimals.AllowUserToAddRows = false;
            dgvAnimals.AllowUserToDeleteRows = false;
            dgvAnimals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAnimals.MultiSelect = false;
            dgvAnimals.RowHeadersVisible = false;
            dgvAnimals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAnimals.EditMode = DataGridViewEditMode.EditProgrammatically;

            dgvAnimals.Dock = DockStyle.Fill;

            dgvAnimals.Columns.Add("AnimalID", "Animal ID");
            dgvAnimals.Columns.Add("Name", "Name");
            dgvAnimals.Columns.Add("Species", "Species");
            dgvAnimals.Columns.Add("Age", "Age");
            dgvAnimals.Columns.Add("RecoveryScore", "Recovery Score");
            dgvAnimals.Columns.Add("Status", "Status");
            dgvAnimals.Columns.Add("HousingUnit", "HousingUnit");
        }

        private void LoadAnimals()
        {
            try
            {
                AnimalRead reader = new AnimalRead();
                int skippedLines;

                List<Animal> animals = reader.readAnimal(out skippedLines);

                dgvAnimals.Rows.Clear();

                foreach (Animal animal in animals)
                {
                    dgvAnimals.Rows.Add(animal.AnimalID, animal.Name, animal.Species, animal.Age, animal.RecoveryScore, animal.Status, animal.HousingUnit);
                }

                if (skippedLines > 0 )
                {
                    MessageBox.Show(skippedLines + " invalid entries were skipped while loading the file.", "Invalid Entries",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(IOException)
            {
                MessageBox.Show("The animal file could not be read or created. Check that the file is not in use and try again.","File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("The application does not have the permission to access animals.txt. Check the folder permission.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
