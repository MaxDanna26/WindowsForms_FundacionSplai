using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_WindowsForm
{

    public class Paciente : Personas
    {
        private int idDoctor;

        public int IdDoctor
        {
            get => idDoctor;
        }
        public string CitaPaciente
        {
            get => $"El paciente tiene cita con el Doctor {idDoctor}.";
        }


        public Paciente(string nombre, string apellido, string dni,int idDoctor) : base(nombre,apellido,dni)
        {
            this.idDoctor = idDoctor;
        }

        public override string ToString()
        {
            return $"{nombre},{apellido} de DNI {dni}";
        }


    }
}
