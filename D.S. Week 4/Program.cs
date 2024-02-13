using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D.S.Week_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Please select an option:");
            Console.WriteLine("a for Doctor - Sick Appointment");
            Console.WriteLine("b for Doctor - Check-up");

            char choice = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (choice)
            {
                case 'a':
                    SickAppointment();
                    break;
                case 'b':
                    CheckUp();
                    break;
                default:
                    Console.WriteLine("Invalid!");
                    break;
            }
        }

        static void SickAppointment()
        {
            Console.WriteLine("Is the patient a child or an adult? (Enter 'child' or 'adult')");
            string patientType = Console.ReadLine();

            double baseCharge;
            if (patientType == "child")
                baseCharge = 50;
            else if (patientType == "adult")
                baseCharge = 75;
            else
            {
                Console.WriteLine("Invalid!");
                return;
            }

            Console.WriteLine("Were labs done? (Enter 'yes' or 'no')");
            string labsDone = Console.ReadLine();

            double additionalCharge = 0;
            if (labsDone == "yes")
                additionalCharge = 25;

            double totalCharge = baseCharge + additionalCharge;

            Console.WriteLine($"Total charge for the appointment: {totalCharge:C}");
            Console.ReadKey();
        }

        static void CheckUp()
        {
            Console.WriteLine("Is the patient a child or an adult? (Enter 'child' or 'adult')");
            string patientType = Console.ReadLine();

            double charge;
            if (patientType == "child")
                charge = 75;
            else if (patientType == "adult")
                charge = 100;
            else
            {
                Console.WriteLine("Please select an option");
                return;
            }

            Console.WriteLine($"The charge for the check-up: {charge:C}");
            Console.ReadKey();
      }  }
    }
