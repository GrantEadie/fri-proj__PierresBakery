using System;
using System.Collections.Generic;
using System.Linq;

namespace BreadPastry.Models
{
  public class Bread
  {
    public int BreadPrices{ get; set; }

    public Bread (int prices)
    {
      BreadPrices = prices;
    }
    
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