using System;
using System.Collections.Generic;
using System.Text;


namespace RAbsalyamov.SoftwareDevelop.Domain.Workers
{
    public class Manager : Staff
    {
        

        public Manager(string name, decimal basicSalary, string dateEmployment) : base(name, basicSalary, dateEmployment)
        {

            var parsedDate = DateTime.Parse(dateEmployment);
            
            DateTime now = DateTime.Today;
            int yearsWorks = now.Year - parsedDate.Year;
            if (parsedDate > now.AddYears(-yearsWorks)) yearsWorks--;

            decimal premiumYears = 0.05M;
            decimal maxSumPremium = basicSalary * 0.4M;
            decimal premium = yearsWorks * (Decimal.Multiply(basicSalary, premiumYears));
            decimal salary;
            if (premium <= maxSumPremium) salary = basicSalary + premium;
            else salary = basicSalary + maxSumPremium;
            
            Console.WriteLine($"Manager {name}, date employment {dateEmployment}, work in company {yearsWorks} years, has salary {salary}");
        }
    }
}
