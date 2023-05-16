using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bmi_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a height");
            double height = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your weight");
            double weight = float.Parse(Console.ReadLine());

            double bmi = weight / Math.Pow(height, 2);

            bmi = Math.Round(bmi, 1);

            Console.Write("BMI: " + bmi);

            if (bmi < 18)
                Console.WriteLine(" Underweight");
            else if (bmi < 25.0)
                Console.WriteLine(" Normal");
            else if (bmi < 30.0)
                Console.WriteLine(" Overweight");
            else
                Console.WriteLine(" Obese");

        }
    }
}
