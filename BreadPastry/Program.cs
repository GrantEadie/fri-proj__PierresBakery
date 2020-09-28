using System;
using System.Collections.Generic;
using BreadPastry.Models;


namespace BreadPastry
{
  public class Program 
  {
    public static void Main()
    {
      Console.WriteLine(@"
      Welcome to Pierre's Bakery! Family owned and all organic.

      Bread is $5, or buy two and get one free!
      A Pastry is $2, unless you want three and you'll get em for $5! (what a deal)

      ");

      Console.WriteLine("How many loaves of bread would you like?");
      int loafInput = int.Parse(Console.ReadLine());
      Console.WriteLine("And how many pastries would you like?");
      int pastryInput = int.Parse(Console.ReadLine());

      Bread breadTotal = new Bread(loafInput);
      Pastry pastryTotal = new Pastry(pastryInput);

      int finalTotal = breadTotal.TotalBreadPrice() + pastryTotal.TotalPastryPrice();

      Console.WriteLine("Your total will be: $" + finalTotal + ".00");

    }
  }
}