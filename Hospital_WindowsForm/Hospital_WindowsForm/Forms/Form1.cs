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

            // Creamos Pacientes
            Paciente paciente1 = new Paciente("Juan", "Pérez", "12345678A", 1);
            fundacionSplai.Pacientes.Add(paciente1);
            Paciente paciente2 = new Paciente("María", "Gómez", "23456789B", 2);
            fundacionSplai.Pacientes.Add(paciente2);
            Paciente paciente3 = new Paciente("Pedro", "López", "34567890C", 3);
            fundacionSplai.Pacientes.Add(paciente3);
            Paciente paciente4 = new Paciente("Ana", "Sánchez", "45678901D", 4);
            fundacionSplai.Pacientes.Add(paciente4);
            Paciente paciente5 = new Paciente("Luis", "Martínez", "56789012E", 5);
            fundacionSplai.Pacientes.Add(paciente5);
            Paciente paciente6 = new Paciente("Laura", "Fernández", "67890123F", 6);
            fundacionSplai.Pacientes.Add(paciente6);
            Paciente paciente7 = new Paciente("Carlos", "Rodríguez", "78901234G", 7);
            fundacionSplai.Pacientes.Add(paciente7);
            Paciente paciente8 = new Paciente("Marta", "García", "89012345H", 8);
            fundacionSplai.Pacientes.Add(paciente8);
            Paciente paciente9 = new Paciente("Eduardo", "Ramírez", "90123456I", 9);
            fundacionSplai.Pacientes.Add(paciente9);
            Paciente paciente10 = new Paciente("Sofía", "Torres", "01234567J", 10);
            fundacionSplai.Pacientes.Add(paciente10);

            // Creamos Doctores
            Doctor doctor1 = new Doctor("Dr. Alicia Smith", "Cardióloga", "12345678A", 1, "CARD123");
            fundacionSplai.Doctores.Add(doctor1);
            Doctor doctor2 = new Doctor("Dr. Carlos Rodriguez", "Pediatra", "23456789B", 2, "PEDI456");
            fundacionSplai.Doctores.Add(doctor2);
            Doctor doctor3 = new Doctor("Dr. Laura Fernández", "Dermatóloga", "34567890C", 3, "DERM789");
            fundacionSplai.Doctores.Add(doctor3);
            Doctor doctor4 = new Doctor("Dr. Miguel Ángel González", "Cirujano", "45678901D", 4, "CIRU890");
            fundacionSplai.Doctores.Add(doctor4);
            Doctor doctor5 = new Doctor("Dr. Patricia Smith", "Neuróloga", "56789012E", 5, "NEURO567");
            fundacionSplai.Doctores.Add(doctor5);
            Doctor doctor6 = new Doctor("Dr. Maria García", "Oftalmólogo", "67890123F", 6, "OFTAL123");
            fundacionSplai.Doctores.Add(doctor6);
            Doctor doctor7 = new Doctor("Dr. Juan López", "Psiquiatra", "78901234G", 7, "PSIQ789");
            fundacionSplai.Doctores.Add(doctor7);
            Doctor doctor8 = new Doctor("Dr. Rosa Martínez", "Ginecóloga", "89012345H", 8, "GINE890");
            fundacionSplai.Doctores.Add(doctor8);
            Doctor doctor9 = new Doctor("Dr. Pablo Ramírez", "Ortopeda", "90123456I", 9, "ORTO901");
            fundacionSplai.Doctores.Add(doctor9);
            Doctor doctor10 = new Doctor("Dr. Carla Torres", "Radiólogo", "01234567J", 10, "RADIO012");
            fundacionSplai.Doctores.Add(doctor10);

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
