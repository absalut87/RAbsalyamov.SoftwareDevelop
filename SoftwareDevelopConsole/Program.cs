using RAbsalyamov.SoftwareDevelop.Domain;
using RAbsalyamov.SoftwareDevelop.Domain.Workers;
using RAbsalyamov.SoftwareDevelop.Persistance;
using System;

namespace RAbsalyamov.SoftwareDevelopConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            Manager manager = new Manager("Absalyamov Roman Faritovich", 35000, "12.01.1999");

            Employee employee = new Employee("Ivanov Ivan Ivanovich", 25000, "05.09.2005");

            Salesman salesman = new Salesman("Myasnikov Vasiliy Aleksandrovich", 45000, "20.11.1988");
        }
    }
}
