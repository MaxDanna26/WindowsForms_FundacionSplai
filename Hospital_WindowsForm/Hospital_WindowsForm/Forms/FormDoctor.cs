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
    }
}
