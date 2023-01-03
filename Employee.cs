﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    public class Employee
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public void WagesMonth()
        {
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;

            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(3);

                switch (empCheck)
                {
                    case IS_FULL_TIME: empHrs = 8; break;
                    case IS_PART_TIME: empHrs = 4; break;

                    default: empHrs = 0; break;

                }

                empWage = empHrs * EMP_RATE_PER_HOUR;
                Console.WriteLine(": " + empWage);
                totalEmpWage += empWage;
            }
            Console.WriteLine("total employee wage: " + totalEmpWage);
        }
    }
}
