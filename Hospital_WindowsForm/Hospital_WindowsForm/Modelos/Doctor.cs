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
        private string matricula;
        public string Matricula
        {
            get => matricula; set => matricula = value; 
        }

        public int IdDoctor
        {
            get => idDoctor;
        }        
        
        private List<Paciente> pacientes;

        public Doctor(string nombre,string apellido,string dni,int idDoctor,string matricula) : base(nombre,apellido,dni)
        {
            this.idDoctor = idDoctor;
            this.matricula = matricula;
            pacientes = new List<Paciente>();
        }

        public override string ToString()
        {
            return $"{nombre},{apellido} de id {idDoctor}";
        }



    }
}
