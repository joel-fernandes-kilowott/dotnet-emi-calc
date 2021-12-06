using System;

namespace EMICalc
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            try
            {
                //Create object
                var Object = new Result();
                double emi;
                
                //Taking user input
                Console.Write("Enter the price of vehicle: ");
                double P = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the rate of interest: ");
                double i = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the loan duration: ");
                double t = Convert.ToDouble(Console.ReadLine());
                Console.Write("Monthly compounding: ");
                double n = Convert.ToDouble(Console.ReadLine());

                //Calling function
                emi = Object.EMI(P, i, t, n);

                //Print Output
                Console.WriteLine($" Monthly EMI =" + emi);
            }

            catch (FormatException e)
            {
                Console.WriteLine("invalid input");
            }
        }
        
    }
}
