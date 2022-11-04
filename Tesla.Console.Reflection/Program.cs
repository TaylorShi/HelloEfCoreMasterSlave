using System;
using Tesla.Referral.Domain.Aggregates;

namespace Tesla.Console.Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var referralCode = new ReferralCode("taylorshi", "x99999");
            var objectProperties = referralCode.GetType().GetProperties();
            foreach (var property in objectProperties)
            {
                System.Console.WriteLine($"Property Name:{property.Name}, Property Value:{property.GetValue(referralCode, null)}");
            }
            System.Console.ReadKey();
        }
    }
}
