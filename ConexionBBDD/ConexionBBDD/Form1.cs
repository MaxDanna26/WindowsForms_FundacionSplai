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
    public partial class Form1 : Form
    {
        SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
        }

       private List<Jobs> SelectJobs()
        {
            List<Jobs> jobs = new List<Jobs>();

            string query = "SELECT * FROM JOBS";
            SqlCommand command = new SqlCommand(query,connection);
            
            // Es lo que nos va a permitir leer de a varios
            SqlDataReader records = command.ExecuteReader();

            // Mientras haya datos por leer haz esto
            while (records.Read())
            {
                int job_id = records.GetInt32(records.GetOrdinal("job_id"));

                string job_title = records.GetString(records.GetOrdinal("job_title"));

                decimal? min_salary = records.IsDBNull(records.GetOrdinal("min_salary"))
                    ? null : (decimal?)records.GetDecimal(records.GetOrdinal("min_salary"));

                decimal? max_salary = records.IsDBNull(records.GetOrdinal("max_salary"))
                    ? null : (decimal?)records.GetDecimal(records.GetOrdinal("max_salary"));

                // Creamos el job y lo agregamos a la lista para luego recorrerla

                Jobs job = new Jobs(job_id,job_title,min_salary,max_salary);

                jobs.Add(job);
            }

            records.Close();

            return jobs;

        }


        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(
                    @"Data source = 79.143.90.12,54321;
                    Initial Catalog=DannaEmployees;
                    Persist Security Info=true;
                    User Id = sa;
                    Password = 123456789;") ;

                
                connection.Open();
                MessageBox.Show("Se ha conectado!");
                btnClose.Enabled = true;
                btnOpen.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar conectarse a la BBDD!" + ex.Message);
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Close();
                MessageBox.Show("Se ha cerrado!");
                btnOpen.Enabled = true;
                btnClose.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar conectarse a la BBDD!" + ex.Message);
            }


        }

        private void InsertJob(Jobs jobs)
        {
            string query = $"INSERT INTO JOBS(job_title,min_salary,max_salary) " +
                           $"VALUES ('{jobs.JobTitle}','{jobs.Min_salary}','{jobs.Max_salary}'); " +
                           $"SELECT Scope_Identity()";
            SqlCommand command = new SqlCommand(query, connection);

            //command.ExecuteScalar();

            int id = Convert.ToInt32(command.ExecuteScalar());

            jobs.Job_Id = id;


            Console.WriteLine("Data stored property.");
            MessageBox.Show("El id de la fila insetada es: " + jobs.Job_Id);
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            int job_id = 0;
            int.TryParse(textBox1.Text,out job_id);
            string nombre = txtNombre.Text;
            decimal minSalary = 0;
            decimal.TryParse(txtMin.Text,out minSalary);
            decimal maxSalary = 0;
            decimal.TryParse(txtMax.Text, out maxSalary);

            Jobs jobs = new Jobs(job_id,nombre,minSalary,maxSalary);


            try
            {
                InsertJob(jobs);
                MessageBox.Show("Job insertado con exito!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectarse! " + ex.Message);
                throw;
            }

        }


    }
}
