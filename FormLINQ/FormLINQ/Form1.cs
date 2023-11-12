using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormLINQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CargarComboBox();
            CargarData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dannaEmployeesDataSet.employees' Puede moverla o quitarla según sea necesario.
            this.employeesTableAdapter.Fill(this.dannaEmployeesDataSet.employees);
            // TODO: esta línea de código carga datos en la tabla 'dannaEmployeesDataSet.locations' Puede moverla o quitarla según sea necesario.
            this.locationsTableAdapter.Fill(this.dannaEmployeesDataSet.locations);

        }

        private IQueryable<employees> CrearData()
        {
            LinqToSqlDataContext dc = new LinqToSqlDataContext();
            var data = from emp in dc.employees
                       select emp;

            dataGridView1.DataSource = data.ToList();

            return data;
        }

        private IQueryable<employees> CargarData()
        {
            LinqToSqlDataContext dc = new LinqToSqlDataContext();

            IQueryable<employees> data = CrearData();

            dataGridView1.DataSource = data.ToList();

            return data;
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            string opcion = textBoxNombre.Text;

            IQueryable<employees> data = CrearData();
            data = data.Where(emp => emp.first_name.Contains(opcion));

            dataGridView1.DataSource = data.ToList();

        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {
            string opcion = textBoxApellido.Text;

            IQueryable<employees> data = CrearData();
            data = data.Where(emp => emp.last_name.Contains(opcion));

            dataGridView1.DataSource = data.ToList();
        }

        private void CargarComboBox()
        {
            LinqToSqlDataContext dc = new LinqToSqlDataContext();
            var dataCity = from city in dc.locations
                           select city.city;

            comboBoxCiudad.DataSource = dataCity.ToList();

        }

        private void comboBoxCiudad_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            string opcion = comboBoxCiudad.SelectedItem.ToString();

            if (opcion != null || opcion != "")
            {
                // la data es un innerJoin de las tablas hasta llegar a city

                LinqToSqlDataContext dc = new LinqToSqlDataContext();

                var data = from emp in dc.employees
                           join department in dc.departments on emp.department_id equals department.department_id
                           join location in dc.locations on department.location_id equals location.location_id
                           where location.city == opcion
                           select emp;

                dataGridView1.DataSource = data.ToList();
            }
        }
    }
}
