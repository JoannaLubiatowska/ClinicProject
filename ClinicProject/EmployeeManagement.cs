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
    public partial class EmployeeManagement : Form
    {
        public EmployeeManagement()
        {
            InitializeComponent();
        }

        private void medicalSpecializationsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.medicalSpecializationsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetClinic);

        }

        private void EmployeeManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetClinic.MedicalSpecializations' table. You can move, or remove it, as needed.
            this.medicalSpecializationsTableAdapter.Fill(this.dataSetClinic.MedicalSpecializations);

        }
    }
}
