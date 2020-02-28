using System;

namespace Bakery.Models {

  public class Bread
  {
    public string BreadType { get; set; }
    public int Price { get; set; }
  
    public Bread (string breadType, decimal price)
    {
      BreadType = breadType;
      Price = price;
    }
  }





  public class Pastry
  {
    public string PastryType { get; set; }
    public decimal PastryPrice { get; set; }
    public int PastryCount { get; set; }

    public Pastry(string pastryType, decimal pastryPrice, int pastryCount)
    {
      PastryType = pastryType;
      PastryPrice = pastryPrice;
      PastryCount = pastryCount;
    }
  }
}