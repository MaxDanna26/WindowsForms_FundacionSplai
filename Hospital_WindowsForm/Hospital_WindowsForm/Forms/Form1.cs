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

            // Creamos Doctores
            Doctor doctor1 = new Doctor("Juan", "Pérez", "12345678A", 1, "11111");
            fundacionSplai.Doctores.Add(doctor1);
            Doctor doctor2 = new Doctor("María", "Gómez", "23456789B", 2, "22222");
            fundacionSplai.Doctores.Add(doctor2);
            Doctor doctor3 = new Doctor("Pedro", "López", "34567890C", 3, "222331");
            fundacionSplai.Doctores.Add(doctor3);
            Doctor doctor4 = new Doctor("Ana", "Sánchez", "45678901D", 4, "221234");
            fundacionSplai.Doctores.Add(doctor4);
            Doctor doctor5 = new Doctor("Luis", "Martínez", "56789012E", 5, "2121222");
            fundacionSplai.Doctores.Add(doctor5);
            Doctor doctor6 = new Doctor("Laura", "Fernández", "67890123F", 6, "222121");
            fundacionSplai.Doctores.Add(doctor6);
            Doctor doctor7 = new Doctor("Carlos", "Rodríguez", "78901234G", 7, "123446");
            fundacionSplai.Doctores.Add(doctor7);
            Doctor doctor8 = new Doctor("Marta", "García", "89012345H", 8, "1243124");
            fundacionSplai.Doctores.Add(doctor8);
            Doctor doctor9 = new Doctor("Eduardo", "Ramírez", "90123456I", 9, "151351");
            fundacionSplai.Doctores.Add(doctor9);
            Doctor doctor10 = new Doctor("Sofía", "Torres", "01234567J", 10, "12414541");
            fundacionSplai.Doctores.Add(doctor10);

            // Creamos Pacientes
            Paciente paciente1 = new Paciente("Juan", "Pérez", "12345678A", 1);
            Paciente paciente2 = new Paciente("María", "Gómez", "23456789B", 2);
            Paciente paciente3 = new Paciente("Pedro", "López", "34567890C", 3);
            Paciente paciente4 = new Paciente("Ana", "Sánchez", "45678901D", 4);
            Paciente paciente5 = new Paciente("Luis", "Martínez", "56789012E", 5);
            Paciente paciente6 = new Paciente("Laura", "Fernández", "67890123F", 6);
            Paciente paciente7 = new Paciente("Carlos", "Rodríguez", "78901234G", 7);
            Paciente paciente8 = new Paciente("Marta", "García", "89012345H", 8);
            Paciente paciente9 = new Paciente("Eduardo", "Ramírez", "90123456I", 9);
            Paciente paciente10 = new Paciente("Sofía", "Torres", "01234567J", 10);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormIngresar formIngresar = new FormIngresar();
            formIngresar.ShowDialog();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            FormVerDatos formDatos = new FormVerDatos();
            formDatos.ShowDialog();
        }
    }

}
