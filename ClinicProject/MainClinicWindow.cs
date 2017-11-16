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
            // TODO: This line of code loads data into the 'dataSetClinic.MedicalSpecializations' table. You can move, or remove it, as needed.
            this.medicalSpecializationsTableAdapter.Fill(this.dataSetClinic.MedicalSpecializations);
            // TODO: This line of code loads data into the 'dataSetClinic.MedicalServices' table. You can move, or remove it, as needed.
            this.medicalServicesTableAdapter.Fill(this.dataSetClinic.MedicalServices);
            // TODO: This line of code loads data into the 'dataSetClinic.Employee_view' table. You can move, or remove it, as needed.
            this.employee_viewTableAdapter.Fill(this.dataSetClinic.Employee_view);
            // TODO: This line of code loads data into the 'dataSetClinic.Patients_view' table. You can move, or remove it, as needed.
            this.patients_viewTableAdapter.Fill(this.dataSetClinic.Patients_view);
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

        private void buttonMedicines_Click(object sender, EventArgs e)
        {
            if (openNextWindow("Medicines"))
            {
                Medicines medicinesWindow = new Medicines();
                medicinesWindow.Show();
            }
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            if (openNextWindow("EmployeeManagement"))
            {
                EmployeeManagement employeeWindow = new EmployeeManagement();
                employeeWindow.Show();
            }
        }

        private void buttonAddPatient_Click(object sender, EventArgs e)
        {
            if (openNextWindow("PatientManagement"))
            {
                PatientManagement patientWindow = new PatientManagement();
                patientWindow.Show();
            }
        }

        private void buttonEditPatient_Click(object sender, EventArgs e)
        {
            if (openNextWindow("PatientManagement"))
            {
                PatientManagement patientWindow = new PatientManagement();
                patientWindow.Show();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }

        private void buttonSaveVisit_Click(object sender, EventArgs e)
        {

        }

        private void buttonSaveSchedule_Click(object sender, EventArgs e)
        {

        }

        private void buttonSaveExamination_Click(object sender, EventArgs e)
        {

        }

        private void buttonEditEmployee_Click(object sender, EventArgs e)
        {
            if (openNextWindow("EmployeeManagement"))
            {
                EmployeeManagement employeeWindow = new EmployeeManagement();
                employeeWindow.Show();
            }
        }

        private void buttonAddService_Click(object sender, EventArgs e)
        {

        }

        private void buttonEditService_Click(object sender, EventArgs e)
        {

        }
        private Boolean openNextWindow(string windowName)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == windowName)
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
