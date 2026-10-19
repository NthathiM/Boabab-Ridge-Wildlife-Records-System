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

            dgvAnimals.Dock = DockStyle.None;

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

        private void dgvAnimals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //tells which row has been clicked + prevent clicking of the headers
            if (e.RowIndex < 0) {  return; } 

            //copying values from specific row into its maytching texbox
            txtAnimalID.Text = dgvAnimals.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvAnimals.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSpecies.Text = dgvAnimals.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtAge.Text = dgvAnimals.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtRecoveryScore.Text = dgvAnimals.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtStatus.Text = dgvAnimals.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtHousing.Text = dgvAnimals.Rows[e.RowIndex].Cells[6].Value.ToString();

            //field that are readonly not supposed to be touched by user
            txtAnimalID.ReadOnly = true;
            btnAdd.Enabled = false; //disables it so can't be clicked
            btnSaveChanges.Enabled = true;  //can click it
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchID = txtSearchID.Text.Trim();

            if(searchID == "")
            {
                MessageBox.Show("Please enter an Animal ID.");
                return;
            }

            foreach(DataGridViewRow row in dgvAnimals.Rows)
            {
                if (row.Cells[0].Value.ToString().ToLower() == searchID.ToLower())
                {
                    txtAnimalID.Text = row.Cells[0].Value.ToString();
                    txtName.Text = row.Cells[1].Value.ToString();
                    txtSpecies.Text = row.Cells[2].Value.ToString();
                    txtAge.Text = row.Cells[3].Value.ToString();
                    txtRecoveryScore.Text = row.Cells[4].Value.ToString();
                    txtStatus.Text = row.Cells[5].Value.ToString();
                    txtHousing.Text = row.Cells[6].Value.ToString();

                    txtAnimalID.ReadOnly = true;
                    btnAdd.Enabled = false;
                    btnSaveChanges.Enabled = true;

                    return;
                }
             
            }
            MessageBox.Show("Animal with that ID does not exist.");


        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtAnimalID.Text) || string.IsNullOrWhiteSpace(txtName.Text) || 
               string.IsNullOrWhiteSpace(txtSpecies.Text) || string.IsNullOrWhiteSpace(txtAge.Text) ||
               string.IsNullOrWhiteSpace(txtRecoveryScore.Text))
            {
                MessageBox.Show("Please fill in all required fields","Validation Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }


            if(!int.TryParse(txtAge.Text.Trim(), out int age) || !int.TryParse(txtRecoveryScore.Text.Trim(), out int recoveryScore))
            {
                MessageBox.Show("Age and Recovery Score must be whole numbers","Validation Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            if(age <0 || recoveryScore <0 || age>100 || recoveryScore > 100)
            {
                MessageBox.Show("Age or Recovery Score cannot be negative.They must be between 0 and 100.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Animal updatedAnimal = new Animal(txtAnimalID.Text, txtName.Text.Trim(), txtSpecies.Text.Trim(), age, recoveryScore);

                AnimalRead reader = new AnimalRead();
                reader.UpdateAnimal(updatedAnimal);

                MessageBox.Show("Animal record updated sucessfully","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);

                LoadAnimals();
                ClearForm();
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Couldn't update animal record. \n{ex.Message}","Update Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void ClearForm()
        {
            txtAnimalID.Clear();
            txtName.Clear();
            txtSpecies.Clear();
            txtAge.Clear();
            txtRecoveryScore.Clear();
            txtStatus.Clear();
            txtHousing.Clear();
            txtSearchID.Clear();

            txtAnimalID.ReadOnly = false;
            btnAdd.Enabled = true;
            btnSaveChanges.Enabled = false;

            dgvAnimals.ClearSelection();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
