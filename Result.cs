using System;

namespace EMICalc
{
    internal class Result
    {
        public double EMI(double P, double i, double t, double n)
        {
            
            //i = i / 100;
             //emi = (P * Math.Pow(1 + i/n ,t*n));
            //double r = m / 24;
            double emi = (P * Math.Pow((1 + i / n), (t * n)))/24;

            return emi;
        }
        
    }
}
