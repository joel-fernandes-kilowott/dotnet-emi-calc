using System;

namespace EMICalc
{
    internal class Result
    {
        public double EMI(double P, double i, double t, double n)
        {
            //Equation for EMI calculation
            double emi = (P * Math.Pow((1 + i / n), (t * n)))/24;

            return emi;
        }
        
    }
}
