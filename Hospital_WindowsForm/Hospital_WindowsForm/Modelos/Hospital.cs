using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_WindowsForm
{
    public class Hospital
    {
        private int numHospital;
        private List<Doctor> doctores;
        private List<Paciente> pacientes;

        public List<Doctor> Doctores { get => doctores; set => doctores = value; }
        public List<Paciente> Pacientes { get => pacientes; set => pacientes = value; }
        public Hospital(int numHospital)
        {
            this.numHospital = numHospital;
            doctores = new List<Doctor>();
            pacientes = new List<Paciente>();
        }
        //public static void DarAltaMedico()
        //{
        //    Console.WriteLine("DAR DE ALTA UN MEDICO");
        //    Console.WriteLine("----------------------------------------");
        //    Console.WriteLine("Que nombre tiene su doctor? ");
        //    string nombre = Console.ReadLine();

        //    Console.WriteLine("Que apellido tiene su doctor? ");
        //    string apellido = Console.ReadLine();

        //    Console.WriteLine("Que dni tiene su doctor? ");
        //    int dni = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Que numero de matricula tiene su doctor? ");
        //    int idDoctor = int.Parse(Console.ReadLine());

        //    Doctor doctor = new Doctor(nombre, apellido, dni, idDoctor);
        //    doctores.Add(doctor);
        //}

        //public static void DarAltaPaciente()
        //{
        //    Console.WriteLine("DAR DE ALTA UN PACIENTE");
        //    Console.WriteLine("----------------------------------------");
        //    Console.WriteLine("Que nombre tiene su paciente? ");
        //    string nombre = Console.ReadLine();

        //    Console.WriteLine("Que apellido tiene su paciente? ");
        //    string apellido = Console.ReadLine();

        //    Console.WriteLine("Que dni tiene su paciente? ");
        //    int dni = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Que numero de ID tiene el doctor de su paciente? ");
        //    ListarMedicos();
        //    int idDoctor = int.Parse(Console.ReadLine());

        //    Paciente paciente = new Paciente(nombre, apellido, dni, idDoctor);
        //    pacientes.Add(paciente);

        //    foreach (Doctor doctor in doctores)
        //    {
        //        int idDoctorado = doctor.GetIdDoctor;

        //        if (idDoctorado == idDoctor)
        //        {
        //            string nombreDoctor = doctor.GetName;
        //            doctor.pacientes.Add(paciente);
        //            Console.WriteLine($"El paciente ha sido asignado al doctor {nombreDoctor}");
        //        }
        //    }

        //}

        //public static void ListarMedicos()
        //{
        //    Console.WriteLine();
        //    foreach (Doctor doctor in doctores)
        //    {
        //        string listadoDoctores = doctor.GetName;
        //        Console.WriteLine(listadoDoctores);
        //    }
        //}

        //public static void ListarPacientes()
        //{
        //    Console.WriteLine("LISTAR PACIENTES");
        //    Console.WriteLine("----------------------------------------");
        //    Console.WriteLine("Que id tiene el doctor que desea listar?");
        //    ListarMedicos();

        //    int idDoctorListar = int.Parse(Console.ReadLine());

        //    foreach (Doctor doctor in doctores)
        //    {
        //        int idDoctor = doctor.GetIdDoctor;
        //        if (idDoctorListar == idDoctor)
        //        {
        //            foreach (Paciente paciente in doctor.pacientes)
        //            {
        //                string pacienteListar = paciente.GetNameDni;
        //                Console.WriteLine(pacienteListar);
        //            }
        //        }

        //    }
        //}

        //public static void EliminarPaciente()
        //{
        //    Console.WriteLine("ELIMINAR PACIENTES");
        //    Console.WriteLine("---------------------------------------------");
        //    Console.WriteLine("Que dni tiene el paciente que desea eliminar?");
        //    int dniPaciente = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Que id tiene el doctor del paciente que desea eliminar?");
        //    ListarMedicos();
        //    int idDoctor = int.Parse(Console.ReadLine());

        //    foreach (Doctor doctor in doctores)
        //    {
        //        int getIdDoctor = doctor.GetIdDoctor;
        //        if (idDoctor == getIdDoctor)
        //        {
        //            foreach (Paciente paciente in doctor.pacientes)
        //            {
        //                int dniLista = paciente.GetDni;
        //                if (dniLista == dniPaciente)
        //                {
        //                    doctor.pacientes.Remove(paciente);
        //                    Console.WriteLine("El paciente ha sido eliminado exitosamente!");
        //                }
        //            }

        //        }
        //    }
        //}

        //public static void ListarPersonas()
        //{
        //    Console.WriteLine("LISTAR PERSONAS");
        //    Console.WriteLine("---------------------------------------------");
        //    foreach (Doctor doctor in doctores)
        //    {
        //        string descripcion = doctor.Descripcion;
        //        Console.WriteLine(descripcion);
        //    }

        //    foreach (Paciente paciente in pacientes)
        //    {
        //        string descripcion = paciente.Descripcion;
        //        Console.WriteLine(descripcion);
        //    }
        //}




    }
}
