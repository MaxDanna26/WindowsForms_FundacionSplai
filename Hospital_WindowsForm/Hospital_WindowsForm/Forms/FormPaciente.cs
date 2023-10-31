using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_WindowsForm.Forms
{
    public partial class FormPaciente : Form
    {
        public FormPaciente(string nombre,string apellido,string dni)
        {
            InitializeComponent();
            txtBoxNombre.Text = nombre;
            txtBoxApellido.Text = apellido;
            txtBoxDni.Text = dni;

            // For each para recorrer los doctores

            foreach (Doctor doctor in FormHospital.fundacionSplai.Doctores)
            {
                string listadoDoctores = doctor.GetName;
                listBoxDoctores.Items.Add(listadoDoctores);
            }
        }

        private void FormPaciente_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearDoctor_Click(object sender, EventArgs e)
        {
            //string nombre = txtBoxNombre.Text;
            //string apellido =   txtBoxApellido.Text;
            //string dni = txtBoxDni.Text;



            //Paciente paciente = new Paciente(nombre,apellido,dni,idDoctor);
        }
    }
}
