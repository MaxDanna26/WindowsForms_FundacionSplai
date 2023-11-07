using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsWithORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProbar_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();

            var data = from emp in dc.employees
                       where emp.employee_id == 103
                       select emp.first_name;

            string name = data.FirstOrDefault();

            //var data2 = from emp in dc.employees
            //            select emp;

            var data2 = from emp in dc.employees
                        join j in dc.jobs
                        on emp.job_id equals j.job_id
                        where emp.employee_id == 103
                        select new {emp.first_name,emp.last_name,j.job_title};

            var dataIBIS = from emp in dc.employees
                           where emp.employee_id == 103
                           select emp;
            employees miEmp = dataIBIS.FirstOrDefault();
            miEmp.salary = 3400;
            miEmp.first_name = "*" + miEmp.first_name;


            listBoxEmployees.Items.Clear();

            foreach (var emp in data2 )
            {
                listBoxEmployees.Items.Add( emp );
            }
        }
    }

    public partial class employees
    {
        public override string ToString()
        {
            return first_name + " " + last_name;
        }
    }
}
