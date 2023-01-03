using EmployeeWages;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComputeEmployeeWage computeEmpWage = new ComputeEmployeeWage();
            computeEmpWage.WagesMonth("dmart", 20, 3, 10);
            computeEmpWage.WagesMonth("Reliance", 10, 4, 20);
        }
    }
}
