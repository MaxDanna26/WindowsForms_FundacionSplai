using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_WindowsForm.Forms
{
    public partial class FormVerDatos : Form
    {
        public FormVerDatos()
        {
            InitializeComponent();


        }

        private void btnVerDatos_Click(object sender, EventArgs e)
        {
            if (comboBoxListar.Text == "Listar Doctores")
            {
                // For each para recorrer los doctores

                foreach (Doctor doctor in FormHospital.fundacionSplai.Doctores)
                {
                    listBoxListar.Items.Add(doctor);
                }

            }
            else if(comboBoxListar.Text == "Listar Pacientes")
            {
                // For each para recorrer los doctores

                foreach (Paciente paciente in FormHospital.fundacionSplai.Pacientes)
                {
                    listBoxListar.Items.Add(paciente);
                }

            }
        }
    }
}
