namespace ClinicProject
{
    partial class Medicines
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label15;
            System.Windows.Forms.Label label16;
            System.Windows.Forms.Label label17;
            System.Windows.Forms.Label label18;
            System.Windows.Forms.Label label19;
            System.Windows.Forms.Label label20;
            System.Windows.Forms.Label drugDosageLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.medicines_viewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Przepisz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicines_viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetClinic = new ClinicProject.DataSetClinic();
            this.medicinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicinesTableAdapter = new ClinicProject.DataSetClinicTableAdapters.MedicinesTableAdapter();
            this.tableAdapterManager = new ClinicProject.DataSetClinicTableAdapters.TableAdapterManager();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.drugDosageTextBox = new System.Windows.Forms.TextBox();
            this.prescribedMedicinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxVisitFirstName = new System.Windows.Forms.TextBox();
            this.textBoxVisitLastName = new System.Windows.Forms.TextBox();
            this.textBoxVisitStreet = new System.Windows.Forms.TextBox();
            this.textBoxVisitStreetNumer = new System.Windows.Forms.TextBox();
            this.textBoxVisitPostalCode = new System.Windows.Forms.TextBox();
            this.textBoxVisitCity = new System.Windows.Forms.TextBox();
            this.medicines_viewTableAdapter = new ClinicProject.DataSetClinicTableAdapters.Medicines_viewTableAdapter();
            this.prescribedMedicinesTableAdapter = new ClinicProject.DataSetClinicTableAdapters.PrescribedMedicinesTableAdapter();
            this.buttonGenetatePrescription = new System.Windows.Forms.Button();
            this.buttonSaveMedicines = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            label18 = new System.Windows.Forms.Label();
            label19 = new System.Windows.Forms.Label();
            label20 = new System.Windows.Forms.Label();
            drugDosageLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicines_viewDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicines_viewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetClinic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prescribedMedicinesBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(13, 25);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(43, 13);
            label2.TabIndex = 2;
            label2.Text = "Nazwa:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(13, 51);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(59, 13);
            label3.TabIndex = 4;
            label3.Text = "Gramatura:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(13, 36);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(29, 13);
            label15.TabIndex = 2;
            label15.Text = "Imię:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(13, 62);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(56, 13);
            label16.TabIndex = 4;
            label16.Text = "Nazwisko:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new System.Drawing.Point(13, 88);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(34, 13);
            label17.TabIndex = 6;
            label17.Text = "Ulica:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new System.Drawing.Point(13, 114);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(70, 13);
            label18.TabIndex = 8;
            label18.Text = "Numer domu:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new System.Drawing.Point(13, 140);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(77, 13);
            label19.TabIndex = 10;
            label19.Text = "Kod pocztowy:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new System.Drawing.Point(13, 166);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(41, 13);
            label20.TabIndex = 12;
            label20.Text = "Miasto:";
            // 
            // drugDosageLabel
            // 
            drugDosageLabel.AutoSize = true;
            drugDosageLabel.Location = new System.Drawing.Point(13, 77);
            drugDosageLabel.Name = "drugDosageLabel";
            drugDosageLabel.Size = new System.Drawing.Size(72, 13);
            drugDosageLabel.TabIndex = 5;
            drugDosageLabel.Text = "Dawkowanie:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.medicines_viewDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(13, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 191);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Leki przyjmowane przez pacjenta:";
            // 
            // medicines_viewDataGridView
            // 
            this.medicines_viewDataGridView.AutoGenerateColumns = false;
            this.medicines_viewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medicines_viewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Przepisz});
            this.medicines_viewDataGridView.DataSource = this.medicines_viewBindingSource;
            this.medicines_viewDataGridView.Location = new System.Drawing.Point(6, 19);
            this.medicines_viewDataGridView.Name = "medicines_viewDataGridView";
            this.medicines_viewDataGridView.Size = new System.Drawing.Size(543, 161);
            this.medicines_viewDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nazwa";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nazwa";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Dawkowanie";
            this.dataGridViewTextBoxColumn2.HeaderText = "Dawkowanie";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Gramatura";
            this.dataGridViewTextBoxColumn3.HeaderText = "Gramatura";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "VisitID";
            this.dataGridViewTextBoxColumn4.HeaderText = "VisitID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Przepisz
            // 
            this.Przepisz.DataPropertyName = "VisitID";
            this.Przepisz.HeaderText = "Przepisz";
            this.Przepisz.Name = "Przepisz";
            // 
            // medicines_viewBindingSource
            // 
            this.medicines_viewBindingSource.DataMember = "Medicines_view";
            this.medicines_viewBindingSource.DataSource = this.dataSetClinic;
            // 
            // dataSetClinic
            // 
            this.dataSetClinic.DataSetName = "DataSetClinic";
            this.dataSetClinic.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicinesBindingSource
            // 
            this.medicinesBindingSource.DataMember = "Medicines";
            this.medicinesBindingSource.DataSource = this.dataSetClinic;
            // 
            // medicinesTableAdapter
            // 
            this.medicinesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CitiesTableAdapter = null;
            this.tableAdapterManager.ClinicEmployeeTableAdapter = null;
            this.tableAdapterManager.MedicalExaminationsTableAdapter = null;
            this.tableAdapterManager.MedicalServicesTableAdapter = null;
            this.tableAdapterManager.MedicalSpecialistsTableAdapter = null;
            this.tableAdapterManager.MedicalSpecializationsTableAdapter = null;
            this.tableAdapterManager.MedicinesTableAdapter = this.medicinesTableAdapter;
            this.tableAdapterManager.PatientsTableAdapter = null;
            this.tableAdapterManager.PrescribedMedicinesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ClinicProject.DataSetClinicTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserGroupsTableAdapter = null;
            this.tableAdapterManager.VisitsTableAdapter = null;
            this.tableAdapterManager.VoivodeshipsTableAdapter = null;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(drugDosageLabel);
            this.groupBox2.Controls.Add(this.drugDosageTextBox);
            this.groupBox2.Controls.Add(label2);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(label3);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Location = new System.Drawing.Point(13, 417);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(563, 103);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Przepisz nowy lek:";
            // 
            // drugDosageTextBox
            // 
            this.drugDosageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescribedMedicinesBindingSource, "DrugDosage", true));
            this.drugDosageTextBox.Location = new System.Drawing.Point(121, 70);
            this.drugDosageTextBox.Name = "drugDosageTextBox";
            this.drugDosageTextBox.Size = new System.Drawing.Size(428, 20);
            this.drugDosageTextBox.TabIndex = 6;
            // 
            // prescribedMedicinesBindingSource
            // 
            this.prescribedMedicinesBindingSource.DataMember = "FK_PM_Medicine";
            this.prescribedMedicinesBindingSource.DataSource = this.medicinesBindingSource;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicinesBindingSource, "MedicineName", true));
            this.textBox2.Location = new System.Drawing.Point(121, 18);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(428, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicinesBindingSource, "Amount", true));
            this.textBox3.Location = new System.Drawing.Point(121, 44);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(428, 20);
            this.textBox3.TabIndex = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(label15);
            this.groupBox4.Controls.Add(this.textBoxVisitFirstName);
            this.groupBox4.Controls.Add(label16);
            this.groupBox4.Controls.Add(this.textBoxVisitLastName);
            this.groupBox4.Controls.Add(label17);
            this.groupBox4.Controls.Add(this.textBoxVisitStreet);
            this.groupBox4.Controls.Add(label18);
            this.groupBox4.Controls.Add(this.textBoxVisitStreetNumer);
            this.groupBox4.Controls.Add(label19);
            this.groupBox4.Controls.Add(this.textBoxVisitPostalCode);
            this.groupBox4.Controls.Add(label20);
            this.groupBox4.Controls.Add(this.textBoxVisitCity);
            this.groupBox4.Location = new System.Drawing.Point(13, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(563, 202);
            this.groupBox4.TabIndex = 49;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dane pacjenta";
            // 
            // textBoxVisitFirstName
            // 
            this.textBoxVisitFirstName.Enabled = false;
            this.textBoxVisitFirstName.Location = new System.Drawing.Point(121, 33);
            this.textBoxVisitFirstName.Name = "textBoxVisitFirstName";
            this.textBoxVisitFirstName.Size = new System.Drawing.Size(428, 20);
            this.textBoxVisitFirstName.TabIndex = 3;
            // 
            // textBoxVisitLastName
            // 
            this.textBoxVisitLastName.Enabled = false;
            this.textBoxVisitLastName.Location = new System.Drawing.Point(121, 59);
            this.textBoxVisitLastName.Name = "textBoxVisitLastName";
            this.textBoxVisitLastName.Size = new System.Drawing.Size(428, 20);
            this.textBoxVisitLastName.TabIndex = 5;
            // 
            // textBoxVisitStreet
            // 
            this.textBoxVisitStreet.Enabled = false;
            this.textBoxVisitStreet.Location = new System.Drawing.Point(121, 85);
            this.textBoxVisitStreet.Name = "textBoxVisitStreet";
            this.textBoxVisitStreet.Size = new System.Drawing.Size(428, 20);
            this.textBoxVisitStreet.TabIndex = 7;
            // 
            // textBoxVisitStreetNumer
            // 
            this.textBoxVisitStreetNumer.Enabled = false;
            this.textBoxVisitStreetNumer.Location = new System.Drawing.Point(121, 111);
            this.textBoxVisitStreetNumer.Name = "textBoxVisitStreetNumer";
            this.textBoxVisitStreetNumer.Size = new System.Drawing.Size(428, 20);
            this.textBoxVisitStreetNumer.TabIndex = 9;
            // 
            // textBoxVisitPostalCode
            // 
            this.textBoxVisitPostalCode.Enabled = false;
            this.textBoxVisitPostalCode.Location = new System.Drawing.Point(121, 137);
            this.textBoxVisitPostalCode.Name = "textBoxVisitPostalCode";
            this.textBoxVisitPostalCode.Size = new System.Drawing.Size(428, 20);
            this.textBoxVisitPostalCode.TabIndex = 11;
            // 
            // textBoxVisitCity
            // 
            this.textBoxVisitCity.Enabled = false;
            this.textBoxVisitCity.Location = new System.Drawing.Point(121, 163);
            this.textBoxVisitCity.Name = "textBoxVisitCity";
            this.textBoxVisitCity.Size = new System.Drawing.Size(428, 20);
            this.textBoxVisitCity.TabIndex = 13;
            // 
            // medicines_viewTableAdapter
            // 
            this.medicines_viewTableAdapter.ClearBeforeFill = true;
            // 
            // prescribedMedicinesTableAdapter
            // 
            this.prescribedMedicinesTableAdapter.ClearBeforeFill = true;
            // 
            // buttonGenetatePrescription
            // 
            this.buttonGenetatePrescription.Location = new System.Drawing.Point(442, 527);
            this.buttonGenetatePrescription.Name = "buttonGenetatePrescription";
            this.buttonGenetatePrescription.Size = new System.Drawing.Size(134, 23);
            this.buttonGenetatePrescription.TabIndex = 50;
            this.buttonGenetatePrescription.Text = "Generuj receptę";
            this.buttonGenetatePrescription.UseVisualStyleBackColor = true;
            this.buttonGenetatePrescription.Click += new System.EventHandler(this.buttonGenetatePrescription_Click);
            // 
            // buttonSaveMedicines
            // 
            this.buttonSaveMedicines.Location = new System.Drawing.Point(302, 526);
            this.buttonSaveMedicines.Name = "buttonSaveMedicines";
            this.buttonSaveMedicines.Size = new System.Drawing.Size(134, 23);
            this.buttonSaveMedicines.TabIndex = 51;
            this.buttonSaveMedicines.Text = "Zapisz";
            this.buttonSaveMedicines.UseVisualStyleBackColor = true;
            this.buttonSaveMedicines.Click += new System.EventHandler(this.buttonSaveMedicines_Click);
            // 
            // Medicines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 562);
            this.Controls.Add(this.buttonSaveMedicines);
            this.Controls.Add(this.buttonGenetatePrescription);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Medicines";
            this.Text = "Medicines";
            this.Load += new System.EventHandler(this.Medicines_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.medicines_viewDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicines_viewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetClinic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prescribedMedicinesBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private DataSetClinic dataSetClinic;
        private System.Windows.Forms.BindingSource medicinesBindingSource;
        private DataSetClinicTableAdapters.MedicinesTableAdapter medicinesTableAdapter;
        private DataSetClinicTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxVisitFirstName;
        private System.Windows.Forms.TextBox textBoxVisitLastName;
        private System.Windows.Forms.TextBox textBoxVisitStreet;
        private System.Windows.Forms.TextBox textBoxVisitStreetNumer;
        private System.Windows.Forms.TextBox textBoxVisitPostalCode;
        private System.Windows.Forms.TextBox textBoxVisitCity;
        private System.Windows.Forms.BindingSource medicines_viewBindingSource;
        private DataSetClinicTableAdapters.Medicines_viewTableAdapter medicines_viewTableAdapter;
        private System.Windows.Forms.DataGridView medicines_viewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Przepisz;
        private System.Windows.Forms.BindingSource prescribedMedicinesBindingSource;
        private DataSetClinicTableAdapters.PrescribedMedicinesTableAdapter prescribedMedicinesTableAdapter;
        private System.Windows.Forms.TextBox drugDosageTextBox;
        private System.Windows.Forms.Button buttonGenetatePrescription;
        private System.Windows.Forms.Button buttonSaveMedicines;
    }
}