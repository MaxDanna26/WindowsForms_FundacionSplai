using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_WindowsForm
{
    public class Personas
    {
       public string dni;
       public string nombre;
       public string apellido;

        public virtual string Descripcion
        {
            get => $"La persona {nombre},{apellido} tiene el dni {dni}.";
        }

        public Personas(string nombre, string apellido, string dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        public virtual string GetNameDni
        {
            get => $"{nombre},{apellido} con DNI {dni} ";
        }

        public virtual string GetName
        {
            get => $"{nombre},{apellido}";
        }

        public virtual string GetDni
        {
            get => dni;
        }

    }
}
