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
    public partial class FormIngresar : Form
    {
        public FormIngresar()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string nombre = txtBoxNombre.Text;
            string apellido = txtBoxApellido.Text;
            string dni = txtBoxDni.Text;


            if (rBtnDoctor.Checked)
            {
                FormDoctor formDoctor = new FormDoctor(nombre,apellido,dni);
                formDoctor.ShowDialog();
            }
            else if (rBtnPaciente.Checked)
            {
                FormPaciente formPaciente = new FormPaciente(nombre, apellido, dni);
                formPaciente.ShowDialog();
            }
        }
    }
}
