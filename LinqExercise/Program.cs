using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers

            int sum = numbers.Sum();
            Console.WriteLine(sum);

            //TODO: Print the Average of numbers
            double avg = numbers.Average();
            Console.WriteLine(avg);

            //TODO: Order numbers in ascending order and print to the console

            numbers.OrderBy(number => number)
                   .ToList()
                   .ForEach(number => Console.WriteLine(number));

            //TODO: Order numbers in decsending order adn print to the console

            numbers.OrderByDescending(number => number)
                   .ToList()
                   .ForEach(number => Console.WriteLine(number));

            //TODO: Print to the console only the numbers greater than 6

            numbers.Where(number => number > 6)
                   .ToList()
                   .ForEach(number => Console.WriteLine(number));

            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**

            numbers.OrderBy(number => number)
                   .Take(4)
                   .ToList()
                   .ForEach(number => Console.WriteLine(number));

            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order

            numbers[4] = 30;
            numbers.OrderByDescending(number => number)
                   .ToList()
                   .ForEach(number => Console.WriteLine(number));

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();
            // Leave alone!

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in acesnding order by FirstName.

            employees.Where(employee => employee.FirstName[0] == 'C' || employee.FirstName[0] == 'S')
                   .OrderBy(employee => employee)
                   .ToList()
                   .ForEach(employee => Console.WriteLine(employee.FullName));

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.

            employees.Where(employee => employee.Age >= 26)
                   .OrderBy(employee => employee.Age)
                   .OrderBy(employee => employee.FirstName)
                   .ToList()
                   .ForEach(employee => Console.WriteLine(employee.FullName));

            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience
            //if their YOE is less than or equal to 10 AND Age is greater than 35

            employees.Where(employee => employee.YearsOfExperience <= 10 && employee.Age > 35)
                     .ToList()
                     .Sum(employee);


            //TODO: Add an employee to the end of the list without using employees.Add()

            employees.Append(new Employee("Danny", "Pellatt", 30, 2))
                     .ToList()
                     .ForEach(employee => Console.WriteLine(employee.FullName));



            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
