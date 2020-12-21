using System;
using System.Collections.Generic;
using System.Text;

namespace RAbsalyamov.SoftwareDevelop.Domain.Workers
{
    public class Staff: Worker
    {
         
        public decimal BasicSalary { get; }

        public string DateEmployment { get; }

        public Staff(string name, decimal basicSalary, string dateEmployment): base(name)
        {
            BasicSalary = basicSalary;
            DateEmployment = dateEmployment;
        }
        
    }
}
