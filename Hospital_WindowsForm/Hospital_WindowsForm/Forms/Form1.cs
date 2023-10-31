using Hospital_WindowsForm.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_WindowsForm
{

    public partial class FormHospital : Form
    {
        public static Hospital fundacionSplai = new Hospital(1);

        public FormHospital()
        {
            InitializeComponent();
            Doctor doctor1 = new Doctor("Juan", "Pérez", "12345678A", 1);
            fundacionSplai.Doctores.Add(doctor1);
            Doctor doctor2 = new Doctor("María", "Gómez", "23456789B", 2);
            fundacionSplai.Doctores.Add(doctor2);
            Doctor doctor3 = new Doctor("Pedro", "López", "34567890C", 3);
            fundacionSplai.Doctores.Add(doctor3);
            Doctor doctor4 = new Doctor("Ana", "Sánchez", "45678901D", 4);
            fundacionSplai.Doctores.Add(doctor4);
            Doctor doctor5 = new Doctor("Luis", "Martínez", "56789012E", 5);
            fundacionSplai.Doctores.Add(doctor5);
            Doctor doctor6 = new Doctor("Laura", "Fernández", "67890123F", 6);
            fundacionSplai.Doctores.Add(doctor6);
            Doctor doctor7 = new Doctor("Carlos", "Rodríguez", "78901234G", 7);
            fundacionSplai.Doctores.Add(doctor7);
            Doctor doctor8 = new Doctor("Marta", "García", "89012345H", 8);
            fundacionSplai.Doctores.Add(doctor8);
            Doctor doctor9 = new Doctor("Eduardo", "Ramírez", "90123456I", 9);
            fundacionSplai.Doctores.Add(doctor9);
            Doctor doctor10 = new Doctor("Sofía", "Torres", "01234567J", 10);
            fundacionSplai.Doctores.Add(doctor10);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormIngresar formIngresar = new FormIngresar();
            formIngresar.ShowDialog();
        }
    }
}
