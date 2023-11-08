﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionBBDD
{
    class Employee
    {
        private int employee_id;
        private string first_name;
        private string last_name;
        private string email;
        private string phone_number;
        private DateTime hire_date;
        private int job_id;
        private decimal salary;
        private int? manager_id;
        private int? department_id;

        public override string ToString()
        {
            return $"    {employee_id}    -   {first_name}    -    {last_name}    -    {email}   - {phone_number} - " +
                   $"   {hire_date}    -    {job_id}    -    {salary}    -    {salary} - " +
                   $"   {manager_id}    -    {department_id}";
        }

        public int Employee_id
        {
            get => employee_id;  set => employee_id = value;
        }

        public string First_name
        {
           get => first_name; set => first_name = value;
        }

        public string Last_name
        {
            get => last_name; set => last_name = value;
        }

        public string Email
        {
            get => email; set => email = value;
        }

        public string PhoneNumber
        {
            get => phone_number; set => phone_number = value;
        }

        public DateTime Hire_date
        {
            get => hire_date; set => hire_date = value;
        }

        public int Job_id
        {
            get => job_id; set => job_id = value;
        }

        public decimal Salary
        {
            get => salary; set => salary = value;
        }

        public int? Manager
        {
            get => manager_id; set => manager_id = value;
        }

        public int? Department_id
        {
            get => department_id; set => department_id = value;
        }
        public Employee() { }

        public Employee(int employee_id, string first_name, string last_name, string email,
            string phone_number, DateTime hire_date, int job_id, decimal salary, int? manager_id, int? department_id)
        {
            this.employee_id = employee_id;
            this.first_name = first_name;
            this.last_name = last_name;
            this.email = email;
            this.phone_number = phone_number;
            this.hire_date = hire_date;
            this.job_id = job_id;
            this.salary = salary;
            this.manager_id = manager_id;
            this.department_id = department_id;
        }
    }
}
