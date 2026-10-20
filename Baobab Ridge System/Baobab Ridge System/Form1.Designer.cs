namespace Baobab_Ridge_System
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvAnimals = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtSearchID = new System.Windows.Forms.TextBox();
            btnSearch = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            btnSaveChanges = new System.Windows.Forms.Button();
            label10 = new System.Windows.Forms.Label();
            grpAnimalDetails = new System.Windows.Forms.GroupBox();
            txtStatus = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            txtHousing = new System.Windows.Forms.TextBox();
            txtAge = new System.Windows.Forms.TextBox();
            txtRecoveryScore = new System.Windows.Forms.TextBox();
            txtSpecies = new System.Windows.Forms.TextBox();
            txtName = new System.Windows.Forms.TextBox();
            txtAnimalID = new System.Windows.Forms.TextBox();
            label = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).BeginInit();
            grpAnimalDetails.SuspendLayout();
            SuspendLayout();
            // 
            // dgvAnimals
            // 
            dgvAnimals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnimals.Location = new System.Drawing.Point(39, 532);
            dgvAnimals.Margin = new System.Windows.Forms.Padding(4);
            dgvAnimals.Name = "dgvAnimals";
            dgvAnimals.RowHeadersWidth = 51;
            dgvAnimals.Size = new System.Drawing.Size(908, 234);
            dgvAnimals.TabIndex = 0;
            dgvAnimals.CellClick += dgvAnimals_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(33, 8);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(344, 31);
            label1.TabIndex = 1;
            label1.Text = "Baobab Ridge Wildlife Records";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(37, 63);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(117, 15);
            label2.TabIndex = 2;
            label2.Text = "Search animal by ID";
            // 
            // txtSearchID
            // 
            txtSearchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtSearchID.Location = new System.Drawing.Point(39, 84);
            txtSearchID.Name = "txtSearchID";
            txtSearchID.Size = new System.Drawing.Size(662, 23);
            txtSearchID.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnSearch.Location = new System.Drawing.Point(724, 84);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(109, 32);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnClear.Location = new System.Drawing.Point(452, 438);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(113, 32);
            btnClear.TabIndex = 18;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnAdd.Location = new System.Drawing.Point(570, 438);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(122, 32);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "Add Animal";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnSaveChanges.Location = new System.Drawing.Point(697, 438);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new System.Drawing.Size(147, 32);
            btnSaveChanges.TabIndex = 20;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(40, 502);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(116, 15);
            label10.TabIndex = 21;
            label10.Text = "Animal records table";
            // 
            // grpAnimalDetails
            // 
            grpAnimalDetails.Controls.Add(txtStatus);
            grpAnimalDetails.Controls.Add(label8);
            grpAnimalDetails.Controls.Add(txtHousing);
            grpAnimalDetails.Controls.Add(txtAge);
            grpAnimalDetails.Controls.Add(txtRecoveryScore);
            grpAnimalDetails.Controls.Add(txtSpecies);
            grpAnimalDetails.Controls.Add(txtName);
            grpAnimalDetails.Controls.Add(txtAnimalID);
            grpAnimalDetails.Controls.Add(label);
            grpAnimalDetails.Controls.Add(label7);
            grpAnimalDetails.Controls.Add(label6);
            grpAnimalDetails.Controls.Add(label5);
            grpAnimalDetails.Controls.Add(label4);
            grpAnimalDetails.Controls.Add(label3);
            grpAnimalDetails.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            grpAnimalDetails.Location = new System.Drawing.Point(39, 128);
            grpAnimalDetails.Name = "grpAnimalDetails";
            grpAnimalDetails.Size = new System.Drawing.Size(805, 297);
            grpAnimalDetails.TabIndex = 22;
            grpAnimalDetails.TabStop = false;
            grpAnimalDetails.Text = "Animal Details";
            // 
            // txtStatus
            // 
            txtStatus.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtStatus.Location = new System.Drawing.Point(5, 247);
            txtStatus.MaxLength = 3;
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new System.Drawing.Size(353, 24);
            txtStatus.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label8.Location = new System.Drawing.Point(5, 224);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(43, 17);
            label8.TabIndex = 12;
            label8.Text = "Status";
            // 
            // txtHousing
            // 
            txtHousing.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtHousing.Location = new System.Drawing.Point(377, 188);
            txtHousing.Name = "txtHousing";
            txtHousing.ReadOnly = true;
            txtHousing.Size = new System.Drawing.Size(388, 24);
            txtHousing.TabIndex = 11;
            txtHousing.TabStop = false;
            // 
            // txtAge
            // 
            txtAge.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtAge.Location = new System.Drawing.Point(377, 123);
            txtAge.MaxLength = 3;
            txtAge.Name = "txtAge";
            txtAge.Size = new System.Drawing.Size(388, 24);
            txtAge.TabIndex = 10;
            // 
            // txtRecoveryScore
            // 
            txtRecoveryScore.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtRecoveryScore.Location = new System.Drawing.Point(5, 181);
            txtRecoveryScore.MaxLength = 3;
            txtRecoveryScore.Name = "txtRecoveryScore";
            txtRecoveryScore.Size = new System.Drawing.Size(353, 24);
            txtRecoveryScore.TabIndex = 9;
            // 
            // txtSpecies
            // 
            txtSpecies.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtSpecies.Location = new System.Drawing.Point(5, 118);
            txtSpecies.MaxLength = 30;
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new System.Drawing.Size(353, 24);
            txtSpecies.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtName.Location = new System.Drawing.Point(377, 62);
            txtName.MaxLength = 30;
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(388, 24);
            txtName.TabIndex = 7;
            // 
            // txtAnimalID
            // 
            txtAnimalID.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtAnimalID.Location = new System.Drawing.Point(5, 62);
            txtAnimalID.MaxLength = 7;
            txtAnimalID.Name = "txtAnimalID";
            txtAnimalID.Size = new System.Drawing.Size(353, 24);
            txtAnimalID.TabIndex = 6;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label.Location = new System.Drawing.Point(374, 158);
            label.Name = "label";
            label.Size = new System.Drawing.Size(53, 17);
            label.TabIndex = 5;
            label.Text = "Housing";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label7.Location = new System.Drawing.Point(374, 100);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(30, 17);
            label7.TabIndex = 4;
            label7.Text = "Age";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(374, 38);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(42, 17);
            label6.TabIndex = 3;
            label6.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(5, 96);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(49, 17);
            label5.TabIndex = 2;
            label5.Text = "Species";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(5, 158);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(94, 17);
            label4.TabIndex = 1;
            label4.Text = "Recovery Score";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(5, 38);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(63, 17);
            label3.TabIndex = 0;
            label3.Text = "Animal ID";
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(350, 438);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(93, 32);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "Delete";
            btnDelete.UseCompatibleTextRendering = true;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1011, 794);
            Controls.Add(btnDelete);
            Controls.Add(grpAnimalDetails);
            Controls.Add(label10);
            Controls.Add(btnSaveChanges);
            Controls.Add(btnAdd);
            Controls.Add(btnClear);
            Controls.Add(btnSearch);
            Controls.Add(txtSearchID);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvAnimals);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).EndInit();
            grpAnimalDetails.ResumeLayout(false);
            grpAnimalDetails.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAnimals;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox grpAnimalDetails;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHousing;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtRecoveryScore;
        private System.Windows.Forms.TextBox txtSpecies;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAnimalID;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDelete;
    }
}

