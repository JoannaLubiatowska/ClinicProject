using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicProject
{
    public partial class MainClinicWindow : Form
    {
        public MainClinicWindow()
        {
            InitializeComponent();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {

        }

        private void patientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetClinic);

        }

        private void patientsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.patientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetClinic);

        }

        private void MainClinicWindow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetClinic.View_Patient' table. You can move, or remove it, as needed.
            this.view_PatientTableAdapter.Fill(this.dataSetClinic.View_Patient);
            // TODO: This line of code loads data into the 'dataSetClinic.Visits' table. You can move, or remove it, as needed.
            this.visitsTableAdapter.Fill(this.dataSetClinic.Visits);
            // TODO: This line of code loads data into the 'dataSetClinic.MedicalExaminations' table. You can move, or remove it, as needed.
            this.medicalExaminationsTableAdapter.Fill(this.dataSetClinic.MedicalExaminations);
            // TODO: This line of code loads data into the 'dataSetClinic.ClinicEmployee' table. You can move, or remove it, as needed.
            this.clinicEmployeeTableAdapter.Fill(this.dataSetClinic.ClinicEmployee);
            // TODO: This line of code loads data into the 'dataSetClinic.Medicines' table. You can move, or remove it, as needed.
            this.medicinesTableAdapter.Fill(this.dataSetClinic.Medicines);
            // TODO: This line of code loads data into the 'dataSetClinic.Patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this.dataSetClinic.Patients);

        }
    }
}
