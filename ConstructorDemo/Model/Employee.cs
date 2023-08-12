﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo.Model
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public static int CountEmployees { get; set; }
        public Employee(int id, string name, string email) 
        {
            Id = id;
            Name = name;
            Email = email;
            CountEmployees += 1;
            Stakeholder.CountStakeholders++;
        }
    }
}
