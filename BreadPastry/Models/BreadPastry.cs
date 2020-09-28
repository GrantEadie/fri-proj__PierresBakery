using System;
using System.Collections.Generic;
using System.Linq;

namespace BreadPastry.Models
{
  public class Bread
  {
    private int _amount;
    public Bread(int inputAmount)
    {
      
      _amount = inputAmount;

    }

    public int TotalBreadPrice()
    {
      int totalCost = 0;
        if (_amount >= 2)
        {
          if (_amount%2 == 1)
          {
            totalCost = ((_amount - 1)/2) * 5;
          }
          else
          {
            totalCost = (_amount/2) * 5;
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

    private int _amount;
    public Pastry(int inputAmount)
    {
      
      _amount = inputAmount;

    }

    public int TotalPastryPrice()
    {
      int totalCost = 0;
        if (_amount >= 3)
        {
          totalCost = ((_amount - (_amount%3))/3 * 5) + (_amount%3 * 2);
        }
        else 
        {
          totalCost = _amount * 2;
        }
      return totalCost;
    }
  

  }
}