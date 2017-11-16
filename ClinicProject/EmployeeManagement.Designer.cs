namespace ClinicProject
{
    partial class EmployeeManagement
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
            System.Windows.Forms.Label label13;
            System.Windows.Forms.Label userGroupIDLabel;
            System.Windows.Forms.Label firstNameLabel1;
            System.Windows.Forms.Label lastNameLabel1;
            System.Windows.Forms.Label userPasswordLabel;
            System.Windows.Forms.Label streetLabel1;
            System.Windows.Forms.Label userLoginLabel;
            System.Windows.Forms.Label streetNumerLabel1;
            System.Windows.Forms.Label employeeDescriptionLabel;
            System.Windows.Forms.Label postalCodeLabel1;
            System.Windows.Forms.Label phoneNumberLabel1;
            System.Windows.Forms.Label cityIDLabel1;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label medicalSpecializationNameLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.comboBoxUserGroup = new System.Windows.Forms.ComboBox();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.textBoxPasswordConfirm = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.userPasswordTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.userLoginTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.employeeDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.streetNumerTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.postalCodeTextBox = new System.Windows.Forms.TextBox();
            this.messageQueue1 = new System.Messaging.MessageQueue();
            this.comboBoxVoivodeships = new System.Windows.Forms.ComboBox();
            this.textBoxPicture = new System.Windows.Forms.TextBox();
            this.dataSetClinic = new ClinicProject.DataSetClinic();
            this.medicalSpecializationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicalSpecializationsTableAdapter = new ClinicProject.DataSetClinicTableAdapters.MedicalSpecializationsTableAdapter();
            this.tableAdapterManager = new ClinicProject.DataSetClinicTableAdapters.TableAdapterManager();
            this.medicalSpecializationNameTextBox = new System.Windows.Forms.TextBox();
            this.comboBoxmedicalSpecializationName = new System.Windows.Forms.ComboBox();
            this.textBoxSpecializations = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            label13 = new System.Windows.Forms.Label();
            userGroupIDLabel = new System.Windows.Forms.Label();
            firstNameLabel1 = new System.Windows.Forms.Label();
            lastNameLabel1 = new System.Windows.Forms.Label();
            userPasswordLabel = new System.Windows.Forms.Label();
            streetLabel1 = new System.Windows.Forms.Label();
            userLoginLabel = new System.Windows.Forms.Label();
            streetNumerLabel1 = new System.Windows.Forms.Label();
            employeeDescriptionLabel = new System.Windows.Forms.Label();
            postalCodeLabel1 = new System.Windows.Forms.Label();
            phoneNumberLabel1 = new System.Windows.Forms.Label();
            cityIDLabel1 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            medicalSpecializationNameLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetClinic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalSpecializationsBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(14, 302);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(39, 13);
            label13.TabIndex = 27;
            label13.Text = "Hasło:";
            // 
            // userGroupIDLabel
            // 
            userGroupIDLabel.AutoSize = true;
            userGroupIDLabel.Location = new System.Drawing.Point(14, 328);
            userGroupIDLabel.Name = "userGroupIDLabel";
            userGroupIDLabel.Size = new System.Drawing.Size(39, 13);
            userGroupIDLabel.TabIndex = 25;
            userGroupIDLabel.Text = "Grupa:";
            // 
            // firstNameLabel1
            // 
            firstNameLabel1.AutoSize = true;
            firstNameLabel1.Location = new System.Drawing.Point(14, 15);
            firstNameLabel1.Name = "firstNameLabel1";
            firstNameLabel1.Size = new System.Drawing.Size(29, 13);
            firstNameLabel1.TabIndex = 3;
            firstNameLabel1.Text = "Imię:";
            // 
            // lastNameLabel1
            // 
            lastNameLabel1.AutoSize = true;
            lastNameLabel1.Location = new System.Drawing.Point(14, 41);
            lastNameLabel1.Name = "lastNameLabel1";
            lastNameLabel1.Size = new System.Drawing.Size(56, 13);
            lastNameLabel1.TabIndex = 5;
            lastNameLabel1.Text = "Nazwisko:";
            // 
            // userPasswordLabel
            // 
            userPasswordLabel.AutoSize = true;
            userPasswordLabel.Location = new System.Drawing.Point(14, 276);
            userPasswordLabel.Name = "userPasswordLabel";
            userPasswordLabel.Size = new System.Drawing.Size(39, 13);
            userPasswordLabel.TabIndex = 21;
            userPasswordLabel.Text = "Hasło:";
            // 
            // streetLabel1
            // 
            streetLabel1.AutoSize = true;
            streetLabel1.Location = new System.Drawing.Point(14, 67);
            streetLabel1.Name = "streetLabel1";
            streetLabel1.Size = new System.Drawing.Size(34, 13);
            streetLabel1.TabIndex = 7;
            streetLabel1.Text = "Ulica:";
            // 
            // userLoginLabel
            // 
            userLoginLabel.AutoSize = true;
            userLoginLabel.Location = new System.Drawing.Point(14, 250);
            userLoginLabel.Name = "userLoginLabel";
            userLoginLabel.Size = new System.Drawing.Size(36, 13);
            userLoginLabel.TabIndex = 19;
            userLoginLabel.Text = "Login:";
            // 
            // streetNumerLabel1
            // 
            streetNumerLabel1.AutoSize = true;
            streetNumerLabel1.Location = new System.Drawing.Point(14, 93);
            streetNumerLabel1.Name = "streetNumerLabel1";
            streetNumerLabel1.Size = new System.Drawing.Size(41, 13);
            streetNumerLabel1.TabIndex = 9;
            streetNumerLabel1.Text = "Numer:";
            // 
            // employeeDescriptionLabel
            // 
            employeeDescriptionLabel.AutoSize = true;
            employeeDescriptionLabel.Location = new System.Drawing.Point(14, 224);
            employeeDescriptionLabel.Name = "employeeDescriptionLabel";
            employeeDescriptionLabel.Size = new System.Drawing.Size(31, 13);
            employeeDescriptionLabel.TabIndex = 17;
            employeeDescriptionLabel.Text = "Opis:";
            // 
            // postalCodeLabel1
            // 
            postalCodeLabel1.AutoSize = true;
            postalCodeLabel1.Location = new System.Drawing.Point(14, 119);
            postalCodeLabel1.Name = "postalCodeLabel1";
            postalCodeLabel1.Size = new System.Drawing.Size(77, 13);
            postalCodeLabel1.TabIndex = 11;
            postalCodeLabel1.Text = "Kod pocztowy:";
            // 
            // phoneNumberLabel1
            // 
            phoneNumberLabel1.AutoSize = true;
            phoneNumberLabel1.Location = new System.Drawing.Point(14, 198);
            phoneNumberLabel1.Name = "phoneNumberLabel1";
            phoneNumberLabel1.Size = new System.Drawing.Size(82, 13);
            phoneNumberLabel1.TabIndex = 15;
            phoneNumberLabel1.Text = "Numer telefonu:";
            // 
            // cityIDLabel1
            // 
            cityIDLabel1.AutoSize = true;
            cityIDLabel1.Location = new System.Drawing.Point(14, 172);
            cityIDLabel1.Name = "cityIDLabel1";
            cityIDLabel1.Size = new System.Drawing.Size(41, 13);
            cityIDLabel1.TabIndex = 13;
            cityIDLabel1.Text = "Miasto:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(14, 145);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(77, 13);
            label1.TabIndex = 31;
            label1.Text = "Województwo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(14, 355);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(45, 13);
            label2.TabIndex = 33;
            label2.Text = "Zdjęcie:";
            // 
            // medicalSpecializationNameLabel
            // 
            medicalSpecializationNameLabel.AutoSize = true;
            medicalSpecializationNameLabel.Location = new System.Drawing.Point(2, 23);
            medicalSpecializationNameLabel.Name = "medicalSpecializationNameLabel";
            medicalSpecializationNameLabel.Size = new System.Drawing.Size(68, 13);
            medicalSpecializationNameLabel.TabIndex = 38;
            medicalSpecializationNameLabel.Text = "Specjalność:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(2, 50);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(97, 13);
            label3.TabIndex = 41;
            label3.Text = "Nowa specjalność:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(14, 381);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(70, 13);
            label4.TabIndex = 43;
            label4.Text = "Specjalności:";
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Location = new System.Drawing.Point(196, 583);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(136, 23);
            this.buttonAddEmployee.TabIndex = 0;
            this.buttonAddEmployee.Text = "Zapisz";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            // 
            // comboBoxUserGroup
            // 
            this.comboBoxUserGroup.FormattingEnabled = true;
            this.comboBoxUserGroup.Location = new System.Drawing.Point(132, 325);
            this.comboBoxUserGroup.Name = "comboBoxUserGroup";
            this.comboBoxUserGroup.Size = new System.Drawing.Size(200, 21);
            this.comboBoxUserGroup.TabIndex = 30;
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Location = new System.Drawing.Point(132, 169);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(200, 21);
            this.comboBoxCity.TabIndex = 29;
            // 
            // textBoxPasswordConfirm
            // 
            this.textBoxPasswordConfirm.Location = new System.Drawing.Point(132, 299);
            this.textBoxPasswordConfirm.Name = "textBoxPasswordConfirm";
            this.textBoxPasswordConfirm.Size = new System.Drawing.Size(200, 20);
            this.textBoxPasswordConfirm.TabIndex = 28;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(132, 12);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.firstNameTextBox.TabIndex = 4;
            // 
            // userPasswordTextBox
            // 
            this.userPasswordTextBox.Location = new System.Drawing.Point(132, 273);
            this.userPasswordTextBox.Name = "userPasswordTextBox";
            this.userPasswordTextBox.Size = new System.Drawing.Size(200, 20);
            this.userPasswordTextBox.TabIndex = 22;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(132, 38);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // userLoginTextBox
            // 
            this.userLoginTextBox.Location = new System.Drawing.Point(132, 247);
            this.userLoginTextBox.Name = "userLoginTextBox";
            this.userLoginTextBox.Size = new System.Drawing.Size(200, 20);
            this.userLoginTextBox.TabIndex = 20;
            // 
            // streetTextBox
            // 
            this.streetTextBox.Location = new System.Drawing.Point(132, 64);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(200, 20);
            this.streetTextBox.TabIndex = 8;
            // 
            // employeeDescriptionTextBox
            // 
            this.employeeDescriptionTextBox.Location = new System.Drawing.Point(132, 221);
            this.employeeDescriptionTextBox.Name = "employeeDescriptionTextBox";
            this.employeeDescriptionTextBox.Size = new System.Drawing.Size(200, 20);
            this.employeeDescriptionTextBox.TabIndex = 18;
            // 
            // streetNumerTextBox
            // 
            this.streetNumerTextBox.Location = new System.Drawing.Point(132, 90);
            this.streetNumerTextBox.Name = "streetNumerTextBox";
            this.streetNumerTextBox.Size = new System.Drawing.Size(200, 20);
            this.streetNumerTextBox.TabIndex = 10;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(132, 195);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(200, 20);
            this.phoneNumberTextBox.TabIndex = 16;
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.Location = new System.Drawing.Point(132, 116);
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.Size = new System.Drawing.Size(200, 20);
            this.postalCodeTextBox.TabIndex = 12;
            // 
            // messageQueue1
            // 
            this.messageQueue1.MessageReadPropertyFilter.LookupId = true;
            this.messageQueue1.SynchronizingObject = this;
            // 
            // comboBoxVoivodeships
            // 
            this.comboBoxVoivodeships.FormattingEnabled = true;
            this.comboBoxVoivodeships.Location = new System.Drawing.Point(132, 142);
            this.comboBoxVoivodeships.Name = "comboBoxVoivodeships";
            this.comboBoxVoivodeships.Size = new System.Drawing.Size(200, 21);
            this.comboBoxVoivodeships.TabIndex = 32;
            // 
            // textBoxPicture
            // 
            this.textBoxPicture.Location = new System.Drawing.Point(132, 352);
            this.textBoxPicture.Name = "textBoxPicture";
            this.textBoxPicture.Size = new System.Drawing.Size(200, 20);
            this.textBoxPicture.TabIndex = 34;
            // 
            // dataSetClinic
            // 
            this.dataSetClinic.DataSetName = "DataSetClinic";
            this.dataSetClinic.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicalSpecializationsBindingSource
            // 
            this.medicalSpecializationsBindingSource.DataMember = "MedicalSpecializations";
            this.medicalSpecializationsBindingSource.DataSource = this.dataSetClinic;
            // 
            // medicalSpecializationsTableAdapter
            // 
            this.medicalSpecializationsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CitiesTableAdapter = null;
            this.tableAdapterManager.ClinicEmployeeTableAdapter = null;
            this.tableAdapterManager.MedicalExaminationsTableAdapter = null;
            this.tableAdapterManager.MedicalServicesTableAdapter = null;
            this.tableAdapterManager.MedicalSpecialistsTableAdapter = null;
            this.tableAdapterManager.MedicalSpecializationsTableAdapter = this.medicalSpecializationsTableAdapter;
            this.tableAdapterManager.MedicinesTableAdapter = null;
            this.tableAdapterManager.PatientsTableAdapter = null;
            this.tableAdapterManager.PrescribedMedicinesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ClinicProject.DataSetClinicTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserGroupsTableAdapter = null;
            this.tableAdapterManager.VisitsTableAdapter = null;
            this.tableAdapterManager.VoivodeshipsTableAdapter = null;
            // 
            // medicalSpecializationNameTextBox
            // 
            this.medicalSpecializationNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicalSpecializationsBindingSource, "MedicalSpecializationName", true));
            this.medicalSpecializationNameTextBox.Location = new System.Drawing.Point(120, 47);
            this.medicalSpecializationNameTextBox.Name = "medicalSpecializationNameTextBox";
            this.medicalSpecializationNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.medicalSpecializationNameTextBox.TabIndex = 39;
            // 
            // comboBoxmedicalSpecializationName
            // 
            this.comboBoxmedicalSpecializationName.FormattingEnabled = true;
            this.comboBoxmedicalSpecializationName.Location = new System.Drawing.Point(120, 20);
            this.comboBoxmedicalSpecializationName.Name = "comboBoxmedicalSpecializationName";
            this.comboBoxmedicalSpecializationName.Size = new System.Drawing.Size(200, 21);
            this.comboBoxmedicalSpecializationName.TabIndex = 40;
            // 
            // textBoxSpecializations
            // 
            this.textBoxSpecializations.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicalSpecializationsBindingSource, "MedicalSpecializationName", true));
            this.textBoxSpecializations.Enabled = false;
            this.textBoxSpecializations.Location = new System.Drawing.Point(132, 378);
            this.textBoxSpecializations.Multiline = true;
            this.textBoxSpecializations.Name = "textBoxSpecializations";
            this.textBoxSpecializations.Size = new System.Drawing.Size(200, 63);
            this.textBoxSpecializations.TabIndex = 42;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(medicalSpecializationNameLabel);
            this.groupBox1.Controls.Add(this.medicalSpecializationNameTextBox);
            this.groupBox1.Controls.Add(this.comboBoxmedicalSpecializationName);
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 479);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 81);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj specjalność";
            // 
            // EmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 639);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(label4);
            this.Controls.Add(this.textBoxSpecializations);
            this.Controls.Add(this.textBoxPicture);
            this.Controls.Add(label2);
            this.Controls.Add(this.comboBoxVoivodeships);
            this.Controls.Add(label1);
            this.Controls.Add(this.buttonAddEmployee);
            this.Controls.Add(this.comboBoxUserGroup);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.comboBoxCity);
            this.Controls.Add(cityIDLabel1);
            this.Controls.Add(this.textBoxPasswordConfirm);
            this.Controls.Add(phoneNumberLabel1);
            this.Controls.Add(label13);
            this.Controls.Add(this.postalCodeTextBox);
            this.Controls.Add(userGroupIDLabel);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(firstNameLabel1);
            this.Controls.Add(postalCodeLabel1);
            this.Controls.Add(employeeDescriptionLabel);
            this.Controls.Add(lastNameLabel1);
            this.Controls.Add(this.streetNumerTextBox);
            this.Controls.Add(this.userPasswordTextBox);
            this.Controls.Add(this.employeeDescriptionTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(streetNumerLabel1);
            this.Controls.Add(userPasswordLabel);
            this.Controls.Add(userLoginLabel);
            this.Controls.Add(streetLabel1);
            this.Controls.Add(this.streetTextBox);
            this.Controls.Add(this.userLoginTextBox);
            this.Name = "EmployeeManagement";
            this.Text = "Pracownicy";
            this.Load += new System.EventHandler(this.EmployeeManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetClinic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalSpecializationsBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.ComboBox comboBoxUserGroup;
        private System.Windows.Forms.ComboBox comboBoxCity;
        private System.Windows.Forms.TextBox textBoxPasswordConfirm;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox userPasswordTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox userLoginTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.TextBox employeeDescriptionTextBox;
        private System.Windows.Forms.TextBox streetNumerTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox postalCodeTextBox;
        private System.Messaging.MessageQueue messageQueue1;
        private System.Windows.Forms.TextBox textBoxPicture;
        private System.Windows.Forms.ComboBox comboBoxVoivodeships;
        private System.Windows.Forms.BindingSource medicalSpecializationsBindingSource;
        private DataSetClinic dataSetClinic;
        private DataSetClinicTableAdapters.MedicalSpecializationsTableAdapter medicalSpecializationsTableAdapter;
        private DataSetClinicTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox medicalSpecializationNameTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxmedicalSpecializationName;
        private System.Windows.Forms.TextBox textBoxSpecializations;
    }
}