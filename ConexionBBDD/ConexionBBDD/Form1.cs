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
            OpenConection();
            List<Jobs> items = SelectJobs();

            foreach (Jobs job in items)
            {
                listBoxJobs.Items.Add(job);
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

       private List<Jobs> SelectJobs()
        {
            OpenConection();
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
            connection.Close();

            return jobs;


        }

       private void SelectedJob()
        {
            if(listBoxJobs.SelectedItems.Count > 0)
            {
                Jobs job = listBoxJobs.SelectedItem as Jobs;
                txtNombre.Text = job.JobTitle;
                txtMin.Text = Convert.ToString(job.Min_salary);
                txtMax.Text = Convert.ToString(job.Max_salary);
            }
        } 

       private void EditJobs(Jobs jobToEdit)
        {
            OpenConection();
            if (jobToEdit == null)
            {
                MessageBox.Show("No ha seleccionado ningun Job!");
            }
            else
            {
                string query = "UPDATE JOBS SET job_title = @NewJobTitle," +
                               "min_salary = @NewMinSalary," +
                               "max_salary = @NewMaxSalary " +
                               "WHERE job_id = @JobId";

                SqlCommand command = new SqlCommand(query, connection);

                string txtMinSalary = txtMin.Text;
                string txtMaxSalary = txtMax.Text;

                decimal? min_salary = 0;
                decimal? max_salary = 0;

                if (!string.IsNullOrEmpty(txtMinSalary))
                {
                    min_salary = decimal.Parse(txtMin.Text);
                }
                else
                {
                    min_salary = null;
                }

                if (!string.IsNullOrEmpty(txtMaxSalary))
                {
                    max_salary = decimal.Parse(txtMax.Text);
                }
                else
                {
                    max_salary = null;
                }

                command.Parameters.AddWithValue("@NewJobTitle", txtNombre.Text);
                command.Parameters.AddWithValue("@NewMinSalary", (min_salary != null) ? (object)min_salary : DBNull.Value);
                command.Parameters.AddWithValue("@NewMaxSalary", (max_salary != null) ? (object)max_salary : DBNull.Value);
                command.Parameters.AddWithValue("@JobId", jobToEdit.Job_Id);

                int affected = command.ExecuteNonQuery();

                if (affected == 0) MessageBox.Show("No se ha modificado nada!");
                else MessageBox.Show("Se ha editado correctamente!");
            }
            connection.Close();
        }

        private void InsertJob(Jobs jobs)
        {
            OpenConection();
            string query = $"INSERT INTO JOBS(job_title,min_salary,max_salary) " +
                           $"VALUES (@JobTitle,@MinSalary,@MaxSalary); " +
                           $"SELECT Scope_Identity()";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@JobTitle", jobs.JobTitle);

            
            if(jobs.Min_salary == null)
                command.Parameters.AddWithValue("@MinSalary", DBNull.Value);
            else 
                command.Parameters.AddWithValue("@MinSalary", jobs.Min_salary);

            if (jobs.Min_salary == null)
                command.Parameters.AddWithValue("@MaxSalary", DBNull.Value);
            else 
                command.Parameters.AddWithValue("@MaxSalary", jobs.Max_salary);

            int id = Convert.ToInt32(command.ExecuteScalar());

            jobs.Job_Id = id;
            connection.Close();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            OpenConection();
            int job_id = 0;
            string nombre = txtNombre.Text;

            decimal? min_salary = 0;
            decimal? max_salary = 0;

            if (txtMin.Text == null || txtMin.Text == "") 
                min_salary = null;
            else
                min_salary = decimal.Parse(txtMin.Text);

            if (txtMax.Text == null || txtMax.Text == "")
                max_salary = null;
            else
                max_salary = decimal.Parse(txtMax.Text);

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("No ha ingresado el nombre del job!");
            }
            else
            {
                Jobs jobs = new Jobs(job_id, nombre, min_salary, max_salary);
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
            connection.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            OpenConection();
            Jobs jobToDelete = listBoxJobs.SelectedItem as Jobs;

            if(jobToDelete == null)
            {
                MessageBox.Show("No has seleccionado ningun job!");
            }
            else
            {
                int IdToDelete = jobToDelete.Job_Id;

                string query = "DELETE FROM JOBS WHERE job_id = @IdToDelete";
                SqlCommand command = new SqlCommand(query, connection);

                // Agregar el parámetro
                command.Parameters.AddWithValue("@IdToDelete", IdToDelete);

                // Ejecutar la consulta
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Se ha eliminado el trabajo con ID " + IdToDelete);
                }
                else
                {
                    MessageBox.Show("No se encontró ningún trabajo con ID " + IdToDelete);
                }
            }
            connection.Close();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            OpenConection();
            listBoxJobs.Items.Clear();
            List<Jobs> items = SelectJobs();

            foreach (Jobs job in items)
            {
                listBoxJobs.Items.Add(job);
            }
            connection.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            OpenConection();
            string nombre = txtNombre.Text;

            decimal? min_salary = 0;
            decimal? max_salary = 0;

            if (txtMin.Text == null || txtMin.Text == "")
                min_salary = null;
            else
                min_salary = decimal.Parse(txtMin.Text);

            if (txtMax.Text == null || txtMax.Text == "")
                max_salary = null;
            else
                max_salary = decimal.Parse(txtMax.Text);

            Jobs jobToEdit = listBoxJobs.SelectedItem as Jobs;

            EditJobs(jobToEdit);
            connection.Close();
        }

        private void listBoxJobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedJob();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            FormEmployees formEmployees = new FormEmployees();
            formEmployees.ShowDialog(); 
        }
    }
}
