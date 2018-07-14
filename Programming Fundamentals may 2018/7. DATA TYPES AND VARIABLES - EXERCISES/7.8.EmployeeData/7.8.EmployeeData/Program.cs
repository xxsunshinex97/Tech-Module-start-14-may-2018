using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._8.EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            ulong id = ulong.Parse(Console.ReadLine());
            ulong employeeNum = ulong.Parse(Console.ReadLine());

            Console.WriteLine($"First name: {firstName}\nLast name: {secondName}\nAge: {age}\nGender: {gender}\nPersonal ID: {id}\nUnique Employee number: {employeeNum}");
        }
    }
}
