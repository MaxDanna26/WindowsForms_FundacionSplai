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
    public partial class FormEditDoctor : Form
    {
        Doctor doctorAeditar;
        public FormEditDoctor(Doctor doctorAeditar)
        {
            InitializeComponent();
            this.doctorAeditar = doctorAeditar;
            txtBoxNombre.Text = doctorAeditar.nombre.ToString();
            txtBoxApellido.Text = doctorAeditar.apellido.ToString();
            txtBoxDni.Text = doctorAeditar.dni.ToString();
            txtBoxMatricula.Text = doctorAeditar.Matricula.ToString();
        }

        private void btnCrearDoctor_Click(object sender, EventArgs e)
        {
            string nombre = txtBoxNombre.Text;
            string apellido = txtBoxApellido.Text;
            string dni = txtBoxDni.Text;
            string matricula = txtBoxMatricula.Text;

            doctorAeditar.nombre = nombre;
            doctorAeditar.apellido = apellido;
            doctorAeditar.dni = dni;
            doctorAeditar.Matricula = matricula;

            MessageBox.Show("Doctor modificado correctamente!");
            this.Close();
           
        }
    }
}
