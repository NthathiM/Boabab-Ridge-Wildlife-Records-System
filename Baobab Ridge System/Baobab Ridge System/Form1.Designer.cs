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
            label9 = new System.Windows.Forms.Label();
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
            btngenerateSummary = new System.Windows.Forms.Button();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            lbl1 = new System.Windows.Forms.Label();
            label19 = new System.Windows.Forms.Label();
            lblReleaseReadyCount = new System.Windows.Forms.Label();
            lblRecoveringCount = new System.Windows.Forms.Label();
            lblStableCount = new System.Windows.Forms.Label();
            lblSeriousCount = new System.Windows.Forms.Label();
            lblCriticalCount = new System.Windows.Forms.Label();
            lblAvgScoreValue = new System.Windows.Forms.Label();
            lblAvgAgeValue = new System.Windows.Forms.Label();
            lblTotalAnimalsValue = new System.Windows.Forms.Label();
            label20 = new System.Windows.Forms.Label();
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
            grpAnimalDetails.Controls.Add(label9);
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
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(3, 29);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(67, 27);
            label9.TabIndex = 14;
            label9.Text = "label9";
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
            btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnDelete.Location = new System.Drawing.Point(333, 438);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(113, 32);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "Delete";
            btnDelete.UseCompatibleTextRendering = true;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btngenerateSummary
            // 
            btngenerateSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btngenerateSummary.Location = new System.Drawing.Point(173, 438);
            btngenerateSummary.Name = "btngenerateSummary";
            btngenerateSummary.Size = new System.Drawing.Size(154, 32);
            btngenerateSummary.TabIndex = 24;
            btngenerateSummary.Text = "Genarate Summary";
            btngenerateSummary.UseVisualStyleBackColor = true;
            btngenerateSummary.Click += btngenerateSummary_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(1072, 63);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(80, 15);
            label11.TabIndex = 25;
            label11.Text = "Total animals:";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(1039, 84);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(113, 15);
            label12.TabIndex = 26;
            label12.Text = "Average age (years):";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(1020, 113);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(132, 15);
            label13.TabIndex = 27;
            label13.Text = "Average recovery score:";
            label13.Click += label13_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(1105, 143);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(47, 15);
            label14.TabIndex = 28;
            label14.Text = "Critical:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(1104, 169);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(48, 15);
            label15.TabIndex = 29;
            label15.Text = "Serious:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(1110, 199);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(42, 15);
            label16.TabIndex = 30;
            label16.Text = "Stable:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new System.Drawing.Point(1083, 230);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(69, 15);
            label17.TabIndex = 31;
            label17.Text = "Recovering:";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new System.Drawing.Point(1158, 260);
            lbl1.Name = "lbl1";
            lbl1.Size = new System.Drawing.Size(13, 15);
            lbl1.TabIndex = 32;
            lbl1.Text = "0";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new System.Drawing.Point(1092, 20);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(0, 15);
            label19.TabIndex = 33;
            // 
            // lblReleaseReadyCount
            // 
            lblReleaseReadyCount.AutoSize = true;
            lblReleaseReadyCount.Location = new System.Drawing.Point(1066, 260);
            lblReleaseReadyCount.Name = "lblReleaseReadyCount";
            lblReleaseReadyCount.Size = new System.Drawing.Size(86, 15);
            lblReleaseReadyCount.TabIndex = 41;
            lblReleaseReadyCount.Text = "Release-Ready:";
            lblReleaseReadyCount.Click += lblReleaseReadyCount_Click;
            // 
            // lblRecoveringCount
            // 
            lblRecoveringCount.AutoSize = true;
            lblRecoveringCount.Location = new System.Drawing.Point(1158, 230);
            lblRecoveringCount.Name = "lblRecoveringCount";
            lblRecoveringCount.Size = new System.Drawing.Size(13, 15);
            lblRecoveringCount.TabIndex = 40;
            lblRecoveringCount.Text = "0";
            // 
            // lblStableCount
            // 
            lblStableCount.AutoSize = true;
            lblStableCount.Location = new System.Drawing.Point(1158, 199);
            lblStableCount.Name = "lblStableCount";
            lblStableCount.Size = new System.Drawing.Size(13, 15);
            lblStableCount.TabIndex = 39;
            lblStableCount.Text = "0";
            // 
            // lblSeriousCount
            // 
            lblSeriousCount.AutoSize = true;
            lblSeriousCount.Location = new System.Drawing.Point(1158, 169);
            lblSeriousCount.Name = "lblSeriousCount";
            lblSeriousCount.Size = new System.Drawing.Size(13, 15);
            lblSeriousCount.TabIndex = 38;
            lblSeriousCount.Text = "0";
            // 
            // lblCriticalCount
            // 
            lblCriticalCount.AutoSize = true;
            lblCriticalCount.Location = new System.Drawing.Point(1158, 143);
            lblCriticalCount.Name = "lblCriticalCount";
            lblCriticalCount.Size = new System.Drawing.Size(13, 15);
            lblCriticalCount.TabIndex = 37;
            lblCriticalCount.Text = "0";
            // 
            // lblAvgScoreValue
            // 
            lblAvgScoreValue.AutoSize = true;
            lblAvgScoreValue.Location = new System.Drawing.Point(1158, 113);
            lblAvgScoreValue.Name = "lblAvgScoreValue";
            lblAvgScoreValue.Size = new System.Drawing.Size(29, 15);
            lblAvgScoreValue.TabIndex = 36;
            lblAvgScoreValue.Text = "N/A";
            // 
            // lblAvgAgeValue
            // 
            lblAvgAgeValue.AutoSize = true;
            lblAvgAgeValue.Location = new System.Drawing.Point(1158, 84);
            lblAvgAgeValue.Name = "lblAvgAgeValue";
            lblAvgAgeValue.Size = new System.Drawing.Size(29, 15);
            lblAvgAgeValue.TabIndex = 35;
            lblAvgAgeValue.Text = "N/A";
            // 
            // lblTotalAnimalsValue
            // 
            lblTotalAnimalsValue.AutoSize = true;
            lblTotalAnimalsValue.Location = new System.Drawing.Point(1158, 63);
            lblTotalAnimalsValue.Name = "lblTotalAnimalsValue";
            lblTotalAnimalsValue.Size = new System.Drawing.Size(13, 15);
            lblTotalAnimalsValue.TabIndex = 34;
            lblTotalAnimalsValue.Text = "0";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new System.Drawing.Point(1129, 24);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(58, 15);
            label20.TabIndex = 42;
            label20.Text = "Summary";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1452, 794);
            Controls.Add(label20);
            Controls.Add(lblReleaseReadyCount);
            Controls.Add(lblRecoveringCount);
            Controls.Add(lblStableCount);
            Controls.Add(lblSeriousCount);
            Controls.Add(lblCriticalCount);
            Controls.Add(lblAvgScoreValue);
            Controls.Add(lblAvgAgeValue);
            Controls.Add(lblTotalAnimalsValue);
            Controls.Add(label19);
            Controls.Add(lbl1);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(btngenerateSummary);
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
        private System.Windows.Forms.Button btngenerateSummary;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblReleaseReadyCount;
        private System.Windows.Forms.Label lblRecoveringCount;
        private System.Windows.Forms.Label lblStableCount;
        private System.Windows.Forms.Label lblSeriousCount;
        private System.Windows.Forms.Label lblCriticalCount;
        private System.Windows.Forms.Label lblAvgScoreValue;
        private System.Windows.Forms.Label lblAvgAgeValue;
        private System.Windows.Forms.Label lblTotalAnimalsValue;
        private System.Windows.Forms.Label label20;
    }
}

