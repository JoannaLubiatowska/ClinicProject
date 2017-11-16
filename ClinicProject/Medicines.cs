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
    public partial class Medicines : Form
    {
        public Medicines()
        {
            InitializeComponent();
        }

        private void medicinesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.medicinesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetClinic);

        }

        private void Medicines_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetClinic.PrescribedMedicines' table. You can move, or remove it, as needed.
            this.prescribedMedicinesTableAdapter.Fill(this.dataSetClinic.PrescribedMedicines);
            // TODO: This line of code loads data into the 'dataSetClinic.Medicines_view' table. You can move, or remove it, as needed.
            this.medicines_viewTableAdapter.Fill(this.dataSetClinic.Medicines_view);
            // TODO: This line of code loads data into the 'dataSetClinic.Medicines' table. You can move, or remove it, as needed.
            this.medicinesTableAdapter.Fill(this.dataSetClinic.Medicines);

        }

        private void buttonSaveMedicines_Click(object sender, EventArgs e)
        {

        }

        private void buttonGenetatePrescription_Click(object sender, EventArgs e)
        {

        }
    }
}
