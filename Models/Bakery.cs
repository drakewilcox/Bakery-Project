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

    private static List<Bread> _breadChosen = new List<Bread>{};

    public static List<Bread> GetAll()
    {
      return _breadChosen;
    }
    
    public void AddList(string newBreadType, decimal newPrice, int newBreadCount, decimal newSetPrice)
    {
      Bread breadOrdered = new Bread(newBreadType, newPrice, newBreadCount, newSetPrice);
      _breadChosen.Add(breadOrdered);
    }

    public void BreadMod(int breadOrderAmount)
    {
        BreadCount = BreadCount + breadOrderAmount;
        Price = (SetPrice * BreadCount) - (SetPrice * (BreadCount / 3));
    }
  }

  public class Pastry
  {
    public string PastryType { get; set; }
    public decimal PastryPrice { get; set; }
    public int PastryCount { get; set; }
    public decimal SetPrice { get; set; }

    public Pastry(string pastryType, decimal pastryPrice, int pastryCount, decimal setPrice)
    {
      PastryType = pastryType;
      PastryPrice = pastryPrice;
      PastryCount = pastryCount;
      SetPrice = setPrice;
    }

    private static List<Pastry> _pastryChosen = new List<Pastry>{};

    public static List<Pastry> GetAll()
    {
      return _pastryChosen;
    }

    public void AddList(string newPastryType, decimal newPastryPrice, int newPastryCount, decimal newSetPrice)
    {
      Pastry pastryOrdered = new Pastry(newPastryType, newPastryPrice, newPastryCount, newSetPrice);
      _pastryChosen.Add(pastryOrdered);
    }


    public void PastryMod(int pastryOrderAmount)
    {
        PastryCount = PastryCount + pastryOrderAmount;
        PastryPrice = ((SetPrice * PastryCount) - ((SetPrice / 2) * (PastryCount / 3)));
    }
  }
}