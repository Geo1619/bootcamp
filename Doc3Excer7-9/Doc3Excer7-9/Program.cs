using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace Doc3Excer7_9
{
    class Program
    {
        //7.a
        //Δ = β² -4αγ , αχ² + β χ + γ = 0
        static double Diak(double a, double b, double c)
        {
            return Math.Pow(b, 2) - 4 * a * c;
        }
        //7.b
        static double Diakrin()
        {
            Console.WriteLine("Give first coefficient number:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Give second coefficient number:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Give third coefficient number:");
            double c = Convert.ToDouble(Console.ReadLine());

            return Math.Pow(b, 2) - 4 * a * c;
        }
        //8
        static void Rizes(double a, double b, double c)
        {
            //double D = Diak(a, b, c);
            double D = Diakrin();
            if (D >= 0 && a != 0)
            {
                Console.WriteLine($"R1 = {(-b + Math.Sqrt(D)) / (2 * a)}");
                Console.WriteLine($"R2 = {(-b - Math.Sqrt(D)) / (2 * a)}");
            }
            else if (a == 0)
                Console.WriteLine($"R = {-c / b}");
            else
                Console.WriteLine($"There are no real Roots for this equation");

            DateTime dateData = DateTime.UtcNow.Date;
            string date = Convert.ToString(dateData);
            Console.WriteLine(date);
        }
        //9.a
        static void FullDate()
        {
            Console.WriteLine("Please state the following:");
            Console.WriteLine("\nYear:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nMonth:");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nDay:");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nHour:");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nMinute:");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nSecond:");
            int sec = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nThank you.");
            DateTime userDate = new DateTime(y, m, d, h, min, sec);

            //Για να εντοπίσει το CultureInfo πρέπει να προσθέσω το System.Globalization

            Console.WriteLine($"Your selected date is {userDate.ToString("F", CultureInfo.CreateSpecificCulture("el-GR"))}");
        }
        //9.b
        static string WholeDate(int y, int m, int d, int h, int min, int sec)
        {
            DateTime myDate = new DateTime(y, m, d, h, min, sec);
            return $"Your selected date is " +
                $"{myDate.ToString("F", CultureInfo.CreateSpecificCulture("el-GR"))}";
        }

        static void Main(string[] args)
        {
            Console.WriteLine("______7.a______");
            Console.WriteLine(Diak(3, 6, 9));
            Console.WriteLine("______7.b______");
            Console.WriteLine(Diakrin());
            Console.WriteLine("______8______");
            Rizes(-3, -1, 9);
            Console.WriteLine("______9.a______");
            FullDate();
            Console.WriteLine("______9.b______");
            Console.WriteLine(WholeDate(2011, 8, 14, 22, 30, 37));

        }
    }
}
