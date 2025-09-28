﻿namespace EmployeeAPI.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }  // Primary Key
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public decimal Salary { get; set; }
        public int DepartmentId { get; set; } // Foreign Key
    }
}
