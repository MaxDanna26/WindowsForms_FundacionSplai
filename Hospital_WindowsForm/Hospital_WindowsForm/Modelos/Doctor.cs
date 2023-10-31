using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_WindowsForm
{
    public class Doctor : Personas
    {
        private int idDoctor;
        private List<Paciente> pacientes;

        public Doctor(string nombre,string apellido,string dni,int idDoctor) : base(nombre,apellido,dni)
        {
            this.idDoctor = idDoctor;
            pacientes = new List<Paciente>();
        }

        public override string GetName
        {
            get => $"{nombre},{apellido} con el ID {idDoctor} ";
        }

        public int GetIdDoctor
        {
            get => idDoctor;
        }


    }
}
