using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsConectados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if(dateTimePicker1.Value == null)
            {

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                dateTimePicker1.Enabled = false;
            }
            else dateTimePicker1.Enabled = true;
        }

        private void btnFecha_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked) { MessageBox.Show("La fecha esta desactiva!"); }
            else MessageBox.Show(dateTimePicker1.Value.ToString());
        }

        private void textBoxPaises_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxPaises_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPaises.SelectedItem != null)
                textBoxPaises.Text = listBoxPaises.SelectedItem.ToString();
                else textBoxPaises.Text = "No ha seleccionado ningun pais.";


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            bool EsHombre = false;

            if (rBtnHombre.Checked)
            {
                EsHombre = true;
                textBoxSexo.Text = EsHombre.ToString();
            }
                
            else
            {
                EsHombre = false;
                textBoxSexo.Text = EsHombre.ToString();
            }


        }

        private void DeleteFecha_CheckedChanged(object sender, EventArgs e)
        {
            if(DeleteFecha.Checked) dateTimePicker1.Visible = false;
            else dateTimePicker1.Visible = true;
        }
    }   
}
