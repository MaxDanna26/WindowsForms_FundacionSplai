using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Piloto
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void butChangeName_Click(object sender, EventArgs e)
        {
            string titulo = "El titulo es " + texTitle.Text;
            string location = "La locacion es " + texLocation.Text;
            string tipo = "El tipo es " + comboBoxType.Text;
            string creticidad = "La creticidad es " + comboBoxCreticity.Text;
            string ambiente = "El ambiente es ";
            if (checkBox1.Checked)
                ambiente += checkBox1.Text;
            else if (checkBox2.Checked)
                ambiente += checkBox2.Text;
            else if(checkBox3.Checked)
                ambiente += checkBox3.Text;

            string descripcion = "La descipcion es " + TexDescription.Text;
            string fecha = "La fecha marcada es: " + date.Text;
            string horas = "La cantidad de horas es: " + numericDuration;
            string estado = "El estado es: " + comboBoxStatus.Text;
            string porcentaje = "El porcentaje es: " + comboBoxPercent.Text;
            string email = checkBoxEmail.Checked ? "Email marcado" : "Email no marcado";


            MessageBox.Show(titulo + Environment.NewLine + location + Environment.NewLine + tipo + Environment.NewLine +
            creticidad + Environment.NewLine + ambiente + Environment.NewLine + descripcion + Environment.NewLine +
            fecha + Environment.NewLine + horas + Environment.NewLine + estado + Environment.NewLine +
            porcentaje + Environment.NewLine + email);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
