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
    public partial class FormDoctor : Form
    {
        public FormDoctor(string nombre,string apellido,string dni)
        {
            InitializeComponent();
            txtBoxNombre.Text = nombre;
            txtBoxApellido.Text = apellido;
            txtBoxDni.Text = dni;
        }

        private void btnCrearDoctor_Click(object sender, EventArgs e)
        {
            string nombre = txtBoxNombre.Text;
            string apellido = txtBoxApellido.Text;
            string dni = txtBoxDni.Text;
            string matricula = textBox1.Text;
            if(matricula == "")
            {
                MessageBox.Show("No ha ingresado ninguna matricula!");
            }
            else
            {
                Doctor ultimoDoctor = FormHospital.fundacionSplai.Doctores.FindLast(p => true);

                int idUltimoDoctor = 0;

                if (ultimoDoctor != null)
                {
                    idUltimoDoctor = ultimoDoctor.IdDoctor;
                }

                try
                {
                    Doctor newDoctor = new Doctor(nombre, apellido, dni, (idUltimoDoctor + 1), matricula);
                    FormHospital.fundacionSplai.Doctores.Add(newDoctor);
                    MessageBox.Show("Doctor Creado Correctamente!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al crear el doctor: " + ex.Message);
                    throw;
                }
            }



        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
