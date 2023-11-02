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
    public partial class FormEditarPaciente : Form
    {
        Paciente pacienteAeditar;
        public FormEditarPaciente(Paciente pacienteAeditar)
        {
            InitializeComponent();
            this.pacienteAeditar = pacienteAeditar;
            txtBoxNombre.Text = pacienteAeditar.nombre.ToString();
            txtBoxApellido.Text = pacienteAeditar.apellido.ToString();
            txtBoxDni.Text = pacienteAeditar.dni.ToString();

            foreach (Doctor doctor in FormHospital.fundacionSplai.Doctores)
            {
                listBoxDoctores.Items.Add(doctor);
            }


        }


        private void btnEditarDoctor_Click(object sender, EventArgs e)
        {
            string nombre = txtBoxNombre.Text;
            string apellido = txtBoxApellido.Text;
            string dni = txtBoxDni.Text;
            Doctor doctorSeleccionado = listBoxDoctores.SelectedItem as Doctor;

            int idDoctor = 0;

            if (doctorSeleccionado == null)
            {
                MessageBox.Show("No ha seleccionado ningun doctor!");
            }
            else
            {
                idDoctor = doctorSeleccionado.IdDoctor;

                pacienteAeditar.nombre = nombre;
                pacienteAeditar.apellido = apellido;
                pacienteAeditar.dni = dni;
                pacienteAeditar.IdDoctor = idDoctor;

                MessageBox.Show("Paciente modificado correctamente!");
                this.Close();
            }
    }
    }
}
