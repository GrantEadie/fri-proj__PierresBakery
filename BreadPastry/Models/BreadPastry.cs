using System;
using System.Collections.Generic;
using System.Linq;

namespace BreadPastry.Models
{
  public class Bread
  {
    public int BreadPrices{ get; set; }

    private static List<Bread> _order = new List<Bread> 

    public Bread (int prices)
    {
      BreadPrices = prices;
      _order.Add(this);
    }

    public static 
    
  }
  public class Pastry
  {

    public int PastryPrices{ get; set; }

    public Pastry (int prices)
    {
      PastryPrices = prices;
    }

  }
}