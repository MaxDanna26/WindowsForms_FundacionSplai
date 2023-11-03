using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablasJobs
{
    class Jobs
    {
        private int job_id;
        private string job_title;
        private decimal min_salary;
        private decimal max_salary;

        public string toString()
        {
            return $"{job_id} - {job_title} - {min_salary} - {max_salary}";
        }


    }
}
