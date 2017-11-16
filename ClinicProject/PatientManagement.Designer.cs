namespace ClinicProject
{
    partial class PatientManagement
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
            System.Windows.Forms.Label pESELLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label cityIDLabel1;
            System.Windows.Forms.Label phoneNumberLabel1;
            System.Windows.Forms.Label label13;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label firstNameLabel1;
            System.Windows.Forms.Label postalCodeLabel1;
            System.Windows.Forms.Label lastNameLabel1;
            System.Windows.Forms.Label streetNumerLabel1;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label streetLabel1;
            System.Windows.Forms.Label label5;
            this.dataSetClinic = new ClinicProject.DataSetClinic();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientsTableAdapter = new ClinicProject.DataSetClinicTableAdapters.PatientsTableAdapter();
            this.tableAdapterManager = new ClinicProject.DataSetClinicTableAdapters.TableAdapterManager();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.streetNumerTextBox = new System.Windows.Forms.TextBox();
            this.postalCodeTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.pESELTextBox = new System.Windows.Forms.TextBox();
            this.userLoginTextBox = new System.Windows.Forms.TextBox();
            this.userPasswordTextBox = new System.Windows.Forms.TextBox();
            this.textBoxPasswordConfirm = new System.Windows.Forms.TextBox();
            this.comboBoxVoivodeships = new System.Windows.Forms.ComboBox();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.comboBoxUserGroup = new System.Windows.Forms.ComboBox();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            pESELLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            cityIDLabel1 = new System.Windows.Forms.Label();
            phoneNumberLabel1 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            firstNameLabel1 = new System.Windows.Forms.Label();
            postalCodeLabel1 = new System.Windows.Forms.Label();
            lastNameLabel1 = new System.Windows.Forms.Label();
            streetNumerLabel1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            streetLabel1 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetClinic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pESELLabel
            // 
            pESELLabel.AutoSize = true;
            pESELLabel.Location = new System.Drawing.Point(9, 221);
            pESELLabel.Name = "pESELLabel";
            pESELLabel.Size = new System.Drawing.Size(44, 13);
            pESELLabel.TabIndex = 17;
            pESELLabel.Text = "PESEL:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 142);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(77, 13);
            label1.TabIndex = 44;
            label1.Text = "Województwo:";
            // 
            // cityIDLabel1
            // 
            cityIDLabel1.AutoSize = true;
            cityIDLabel1.Location = new System.Drawing.Point(12, 169);
            cityIDLabel1.Name = "cityIDLabel1";
            cityIDLabel1.Size = new System.Drawing.Size(41, 13);
            cityIDLabel1.TabIndex = 37;
            cityIDLabel1.Text = "Miasto:";
            // 
            // phoneNumberLabel1
            // 
            phoneNumberLabel1.AutoSize = true;
            phoneNumberLabel1.Location = new System.Drawing.Point(12, 195);
            phoneNumberLabel1.Name = "phoneNumberLabel1";
            phoneNumberLabel1.Size = new System.Drawing.Size(82, 13);
            phoneNumberLabel1.TabIndex = 38;
            phoneNumberLabel1.Text = "Numer telefonu:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(12, 299);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(39, 13);
            label13.TabIndex = 43;
            label13.Text = "Hasło:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 325);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(39, 13);
            label2.TabIndex = 42;
            label2.Text = "Grupa:";
            // 
            // firstNameLabel1
            // 
            firstNameLabel1.AutoSize = true;
            firstNameLabel1.Location = new System.Drawing.Point(12, 12);
            firstNameLabel1.Name = "firstNameLabel1";
            firstNameLabel1.Size = new System.Drawing.Size(29, 13);
            firstNameLabel1.TabIndex = 32;
            firstNameLabel1.Text = "Imię:";
            // 
            // postalCodeLabel1
            // 
            postalCodeLabel1.AutoSize = true;
            postalCodeLabel1.Location = new System.Drawing.Point(12, 116);
            postalCodeLabel1.Name = "postalCodeLabel1";
            postalCodeLabel1.Size = new System.Drawing.Size(77, 13);
            postalCodeLabel1.TabIndex = 36;
            postalCodeLabel1.Text = "Kod pocztowy:";
            // 
            // lastNameLabel1
            // 
            lastNameLabel1.AutoSize = true;
            lastNameLabel1.Location = new System.Drawing.Point(12, 38);
            lastNameLabel1.Name = "lastNameLabel1";
            lastNameLabel1.Size = new System.Drawing.Size(56, 13);
            lastNameLabel1.TabIndex = 33;
            lastNameLabel1.Text = "Nazwisko:";
            // 
            // streetNumerLabel1
            // 
            streetNumerLabel1.AutoSize = true;
            streetNumerLabel1.Location = new System.Drawing.Point(12, 90);
            streetNumerLabel1.Name = "streetNumerLabel1";
            streetNumerLabel1.Size = new System.Drawing.Size(41, 13);
            streetNumerLabel1.TabIndex = 35;
            streetNumerLabel1.Text = "Numer:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 273);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(39, 13);
            label3.TabIndex = 41;
            label3.Text = "Hasło:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 247);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(36, 13);
            label4.TabIndex = 40;
            label4.Text = "Login:";
            // 
            // streetLabel1
            // 
            streetLabel1.AutoSize = true;
            streetLabel1.Location = new System.Drawing.Point(12, 64);
            streetLabel1.Name = "streetLabel1";
            streetLabel1.Size = new System.Drawing.Size(34, 13);
            streetLabel1.TabIndex = 34;
            streetLabel1.Text = "Ulica:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(12, 351);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(77, 13);
            label5.TabIndex = 51;
            label5.Text = "Ubezpieczony:";
            // 
            // dataSetClinic
            // 
            this.dataSetClinic.DataSetName = "DataSetClinic";
            this.dataSetClinic.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "Patients";
            this.patientsBindingSource.DataSource = this.dataSetClinic;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.MedicinesTableAdapter = null;
            this.tableAdapterManager.PatientsTableAdapter = this.patientsTableAdapter;
            this.tableAdapterManager.PrescribedMedicinesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ClinicProject.DataSetClinicTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserGroupsTableAdapter = null;
            this.tableAdapterManager.VisitsTableAdapter = null;
            this.tableAdapterManager.VoivodeshipsTableAdapter = null;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(136, 9);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.firstNameTextBox.TabIndex = 4;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(136, 35);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // streetTextBox
            // 
            this.streetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "Street", true));
            this.streetTextBox.Location = new System.Drawing.Point(136, 61);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(200, 20);
            this.streetTextBox.TabIndex = 8;
            // 
            // streetNumerTextBox
            // 
            this.streetNumerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "StreetNumer", true));
            this.streetNumerTextBox.Location = new System.Drawing.Point(136, 87);
            this.streetNumerTextBox.Name = "streetNumerTextBox";
            this.streetNumerTextBox.Size = new System.Drawing.Size(200, 20);
            this.streetNumerTextBox.TabIndex = 10;
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "PostalCode", true));
            this.postalCodeTextBox.Location = new System.Drawing.Point(136, 113);
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.Size = new System.Drawing.Size(200, 20);
            this.postalCodeTextBox.TabIndex = 12;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "PhoneNumber", true));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(136, 192);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(200, 20);
            this.phoneNumberTextBox.TabIndex = 16;
            // 
            // pESELTextBox
            // 
            this.pESELTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "PESEL", true));
            this.pESELTextBox.Location = new System.Drawing.Point(136, 218);
            this.pESELTextBox.Name = "pESELTextBox";
            this.pESELTextBox.Size = new System.Drawing.Size(200, 20);
            this.pESELTextBox.TabIndex = 18;
            // 
            // userLoginTextBox
            // 
            this.userLoginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "UserLogin", true));
            this.userLoginTextBox.Location = new System.Drawing.Point(136, 244);
            this.userLoginTextBox.Name = "userLoginTextBox";
            this.userLoginTextBox.Size = new System.Drawing.Size(200, 20);
            this.userLoginTextBox.TabIndex = 20;
            // 
            // userPasswordTextBox
            // 
            this.userPasswordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "UserPassword", true));
            this.userPasswordTextBox.Location = new System.Drawing.Point(136, 270);
            this.userPasswordTextBox.Name = "userPasswordTextBox";
            this.userPasswordTextBox.Size = new System.Drawing.Size(200, 20);
            this.userPasswordTextBox.TabIndex = 22;
            // 
            // textBoxPasswordConfirm
            // 
            this.textBoxPasswordConfirm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "UserPassword", true));
            this.textBoxPasswordConfirm.Location = new System.Drawing.Point(136, 296);
            this.textBoxPasswordConfirm.Name = "textBoxPasswordConfirm";
            this.textBoxPasswordConfirm.Size = new System.Drawing.Size(200, 20);
            this.textBoxPasswordConfirm.TabIndex = 45;
            // 
            // comboBoxVoivodeships
            // 
            this.comboBoxVoivodeships.FormattingEnabled = true;
            this.comboBoxVoivodeships.Location = new System.Drawing.Point(136, 139);
            this.comboBoxVoivodeships.Name = "comboBoxVoivodeships";
            this.comboBoxVoivodeships.Size = new System.Drawing.Size(200, 21);
            this.comboBoxVoivodeships.TabIndex = 47;
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Location = new System.Drawing.Point(136, 166);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(200, 21);
            this.comboBoxCity.TabIndex = 46;
            // 
            // comboBoxUserGroup
            // 
            this.comboBoxUserGroup.FormattingEnabled = true;
            this.comboBoxUserGroup.Location = new System.Drawing.Point(136, 322);
            this.comboBoxUserGroup.Name = "comboBoxUserGroup";
            this.comboBoxUserGroup.Size = new System.Drawing.Size(200, 21);
            this.comboBoxUserGroup.TabIndex = 48;
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Location = new System.Drawing.Point(200, 373);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(136, 23);
            this.buttonAddEmployee.TabIndex = 49;
            this.buttonAddEmployee.Text = "Zapisz";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(136, 350);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(66, 17);
            this.checkBox1.TabIndex = 50;
            this.checkBox1.Text = "Tak/Nie";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // PatientManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 409);
            this.Controls.Add(label5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.buttonAddEmployee);
            this.Controls.Add(this.comboBoxUserGroup);
            this.Controls.Add(this.comboBoxVoivodeships);
            this.Controls.Add(this.comboBoxCity);
            this.Controls.Add(this.textBoxPasswordConfirm);
            this.Controls.Add(label1);
            this.Controls.Add(cityIDLabel1);
            this.Controls.Add(phoneNumberLabel1);
            this.Controls.Add(label13);
            this.Controls.Add(label2);
            this.Controls.Add(firstNameLabel1);
            this.Controls.Add(postalCodeLabel1);
            this.Controls.Add(lastNameLabel1);
            this.Controls.Add(streetNumerLabel1);
            this.Controls.Add(label3);
            this.Controls.Add(label4);
            this.Controls.Add(streetLabel1);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.streetTextBox);
            this.Controls.Add(this.streetNumerTextBox);
            this.Controls.Add(this.postalCodeTextBox);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(pESELLabel);
            this.Controls.Add(this.pESELTextBox);
            this.Controls.Add(this.userLoginTextBox);
            this.Controls.Add(this.userPasswordTextBox);
            this.Name = "PatientManagement";
            this.Text = "PatientManagement";
            this.Load += new System.EventHandler(this.PatientManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetClinic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSetClinic dataSetClinic;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private DataSetClinicTableAdapters.PatientsTableAdapter patientsTableAdapter;
        private DataSetClinicTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.TextBox streetNumerTextBox;
        private System.Windows.Forms.TextBox postalCodeTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox pESELTextBox;
        private System.Windows.Forms.TextBox userLoginTextBox;
        private System.Windows.Forms.TextBox userPasswordTextBox;
        private System.Windows.Forms.TextBox textBoxPasswordConfirm;
        private System.Windows.Forms.ComboBox comboBoxVoivodeships;
        private System.Windows.Forms.ComboBox comboBoxCity;
        private System.Windows.Forms.ComboBox comboBoxUserGroup;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}