using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TablasJobs;

namespace ConexionBBDD
{
    public partial class FormEmployees : Form
    {
        SqlConnection connection;
        public FormEmployees()
        {
            InitializeComponent();
            List<Employee> Lista = SelectEmployees();

            foreach (Employee E in Lista)
            {
                listBox1.Items.Add(E);

            }
        }

        public void OpenConection()
        {
            try
            {
                connection = new SqlConnection(
                    @"Data source = 79.143.90.12,54321;
                    Initial Catalog=DannaEmployees;
                    Persist Security Info=true;
                    User Id = sa;
                    Password = 123456789;");


                connection.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar conectarse a la BBDD!" + ex.Message);
            }
        }

        private List<Employee> SelectEmployees()
        {
            OpenConection();
            
            List<Employee> employee = new List<Employee>();

            string query = "SELECT * FROM EMPLOYEES";
            SqlCommand command = new SqlCommand(query, connection);

            // Es lo que nos va a permitir leer de a varios
            SqlDataReader records = command.ExecuteReader();

            // Mientras haya datos por leer haz esto
            while (records.Read())
            {
                int employee_id = records.GetInt32(records.GetOrdinal("employee_id"));

                string first_name = records.IsDBNull(records.GetOrdinal("first_name"))
                    ? null : records.GetString(records.GetOrdinal("first_name"));

                string last_name = records.GetString(records.GetOrdinal("last_name"));

                string email = records.GetString(records.GetOrdinal("email"));

                string phone_number = records.IsDBNull(records.GetOrdinal("phone_number"))
                    ? null : records.GetString(records.GetOrdinal("phone_number"));

                DateTime hire_date = records.GetDateTime(records.GetOrdinal("hire_date"));

                int job_id = records.GetInt32(records.GetOrdinal("job_id"));

                decimal salary = records.GetDecimal(records.GetOrdinal("salary"));

                int? manager_id = records.IsDBNull(records.GetOrdinal("manager_id"))
                    ? null : (int?)records.GetInt32(records.GetOrdinal("manager_id"));

                int? department_id = records.IsDBNull(records.GetOrdinal("department_id"))
                    ? null : (int?)records.GetInt32(records.GetOrdinal("department_id"));

                // Creamos el job y lo agregamos a la lista para luego recorrerla

                Employee newEmployee = new Employee(employee_id,first_name,last_name,email,phone_number,
                    hire_date,job_id,salary,manager_id,department_id);

                employee.Add(newEmployee);
            }

            records.Close();
            connection.Close();

            return employee;
        }

        private void rBtnCiudad_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnCiudad.Checked)
            {
                txtBoxCiudad.Enabled = true;
            }

            if (rBtnNombre.Checked)
            {
                txtBoxCiudad.Enabled = false;
            }

            if (rBtnApellido.Checked)
            {
                txtBoxCiudad.Enabled = false;
            }

        }

        private void rBtnNombre_CheckedChanged(object sender, EventArgs e)
        {
            if(rBtnNombre.Checked)
            {
                txtBoxNombre.Enabled = true;
            }

            if(rBtnApellido.Checked)
            {
                txtBoxNombre.Enabled = false;
            }

            if(rBtnCiudad.Checked)
            {
                txtBoxApellido.Enabled = false;  
            }
        }

        private void rBtnApellido_CheckedChanged(object sender, EventArgs e)
        {
            if(rBtnApellido.Checked) 
            { 
                txtBoxApellido.Enabled = true;
            }

            if (rBtnNombre.Checked)
            {
                txtBoxApellido.Enabled = false;
            }

            if (rBtnCiudad.Checked)
            {
                txtBoxApellido.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rBtnApellido.Checked)
            {
                string apellido = txtBoxApellido.Text;
            }
            else if (rBtnCiudad.Checked)
            {
                string ciudad = txtBoxCiudad.Text;
            }
            else if(rBtnNombre.Checked)
            {
                string nombre = txtBoxNombre.Text;
            }
            else
            {
                MessageBox.Show("No ha seleccionado ningun parametro!");
            }


        }
    }

    
}
