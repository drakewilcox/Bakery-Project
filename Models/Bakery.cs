using System;
using System.Collections.Generic;

namespace Bakery.Models {

  public class Bread
  {
    public string BreadType { get; set; }
    public decimal Price { get; set; }
    public int BreadCount { get; set; }
    public decimal SetPrice { get; set; }
  
    public Bread (string breadType, decimal price, int breadCount, decimal setPrice)
    {
      BreadType = breadType;
      Price = price;
      BreadCount = breadCount;
      SetPrice = setPrice;
    }
    public void BreadMod(int breadOrderAmount)
    {
      if((BreadCount / 3) == 0)
      {
        BreadCount = breadOrderAmount;
        Price = (Price * breadOrderAmount) - (SetPrice * (breadOrderAmount / 3));
      }
      else {
        BreadCount = breadOrderAmount;
        Price = Price * breadOrderAmount;

      }
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