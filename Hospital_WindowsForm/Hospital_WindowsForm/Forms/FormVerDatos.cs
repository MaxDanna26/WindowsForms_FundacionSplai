using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            string selectedOption = comboBoxListar.SelectedItem.ToString();
            if (selectedOption == null) MessageBox.Show("No ha seleccion una opcion valida!");

            DeleteData(listBoxListar,selectedOption);
            RefreshData(listBoxListar, selectedOption);
        }

        private void comboBoxListar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = comboBoxListar.SelectedItem.ToString();

            RefreshData(listBoxListar, selectedOption);

        }

        private void FormVerDatos_Load(object sender, EventArgs e)
        {
            comboBoxListar.SelectedItem = "Listar Personas";
        }

        public static void DeleteData(ListBox listBoxListar,string selectedOption)
        {
            if (listBoxListar.SelectedItem == null)
            {
                MessageBox.Show("No ha seleccionado ninguna persona!");
            }
            else if (selectedOption == "Listar Doctores")
            {
                Doctor doctor = listBoxListar.SelectedItem as Doctor;
                FormHospital.fundacionSplai.Doctores.Remove(doctor);

                MessageBox.Show("Doctor eliminado con exito!");
            }
            else if (selectedOption == "Listar Pacientes")
            {
                Paciente paciente = listBoxListar.SelectedItem as Paciente;
                FormHospital.fundacionSplai.Pacientes.Remove(paciente);

                MessageBox.Show("Paciente eliminado con exito!");
            }
            else if (selectedOption == "Listar Personas")
            {
                if (listBoxListar.SelectedItem is Paciente)
                {
                    Paciente paciente = listBoxListar.SelectedItem as Paciente;
                    FormHospital.fundacionSplai.Pacientes.Remove(paciente);

                    MessageBox.Show("Paciente eliminado con exito!");
                }
                else
                {
                    Doctor doctor = listBoxListar.SelectedItem as Doctor;
                    FormHospital.fundacionSplai.Doctores.Remove(doctor);

                    MessageBox.Show("Doctor eliminado con exito!");
                }
            }
        }

        public static void RefreshData(ListBox listBoxListar,string selectedOption)
        {
            // Depende de la opcion el listbox muestra la info
            if (selectedOption == "Listar Doctores")
            {
                listBoxListar.Items.Clear();

                foreach (Doctor doctor in FormHospital.fundacionSplai.Doctores)
                {
                    listBoxListar.Items.Add(doctor);
                }
            }
            else if (selectedOption == "Listar Pacientes")
            {
                listBoxListar.Items.Clear();

                foreach (Paciente paciente in FormHospital.fundacionSplai.Pacientes)
                {
                    listBoxListar.Items.Add(paciente);
                }
            }
            else if (selectedOption == "Listar Personas")
            {
                listBoxListar.Items.Clear();
                foreach (Paciente paciente in FormHospital.fundacionSplai.Pacientes)
                {
                    listBoxListar.Items.Add(paciente);
                }
                foreach (Doctor doctor in FormHospital.fundacionSplai.Doctores)
                {
                    listBoxListar.Items.Add(doctor);
                }
            }
        }
    }


}
