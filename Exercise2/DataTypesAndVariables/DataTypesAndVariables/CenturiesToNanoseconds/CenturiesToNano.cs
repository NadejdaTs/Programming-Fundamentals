using System;
using System.Numerics;

namespace CenturiesToNano
{
    class CenturiesToNano
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            BigInteger hours = days * 24;
            BigInteger minutes = hours * 60;
            BigInteger seconds = minutes * 60;
            BigInteger milliseconds = seconds * 1000;
            BigInteger microseconds = milliseconds * 1000;
            BigInteger nanoseconds = microseconds * 1000;

            Console.Write("{0} centuries = {1} years = {2} days = {3} hours = ", centuries, years, days, hours);
            Console.Write("{0} minutes = {1} seconds = {2} milliseconds = {3} ", minutes, seconds, milliseconds, microseconds);
            Console.WriteLine("microseconds = {0} nanoseconds", nanoseconds);
        }
    }
}
