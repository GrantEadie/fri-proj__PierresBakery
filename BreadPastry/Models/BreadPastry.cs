using System;
using System.Collections.Generic;
using System.Linq;

namespace BreadPastry.Models
{
  public class Bread
  {
    public int Amount { get; set; }
    public Bread(int inputAmount)
    {
      
      Amount = inputAmount;

    }

    public int TotalBreadPrice()
    {
      int totalCost = 0;
        if (Amount >= 3)
        {
          if (Amount%3 == 1)
          {
            totalCost = ((Amount - 1)/2) * 5;
          }
          else
          {
            totalCost = (Amount/2) * 5;
          }
        }
        else 
        {
          totalCost = 5;
        }
      return totalCost;
    }
    
  }
  public class Pastry
  {

    public int Amount { get; set; }
    public Pastry(int inputAmount)
    {
      
      Amount = inputAmount;

    }

    public int TotalPastryPrice()
    {
      int totalCost = 0;
        if (Amount >= 3)
        {
          totalCost = ((Amount - (Amount%3))/3 * 5) + (Amount%3 * 2);
        }
        else 
        {
          totalCost = Amount * 2;
        }
      return totalCost;
    }
  

  }
}