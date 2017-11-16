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
    public partial class PatientManagement : Form
    {
        public PatientManagement()
        {
            InitializeComponent();
        }

        private void patientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetClinic);

        }

        private void PatientManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetClinic.Patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this.dataSetClinic.Patients);

        }
    }
}
