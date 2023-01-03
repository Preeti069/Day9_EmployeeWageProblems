using EmployeeWages;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilder dmart = new EmpWageBuilder("Dmart", 10, 4, 20);
            dmart.WagesMonth();

            Console.WriteLine(dmart.tostring());

            EmpWageBuilder reliance = new EmpWageBuilder("Reliance", 10, 4, 20);
            reliance.WagesMonth();

            Console.WriteLine(reliance.tostring());
        }
    }
}
