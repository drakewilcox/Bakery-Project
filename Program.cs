using System; 
using System.Collections.Generic; 
using Bakery.Models; 

namespace CustomerOrder
{
  public class Program
  {
    public static Bread countryBread = new Bread("Country Bread", 5.00m, 0, 5.00m);
    public static Bread walnutBread = new Bread("Walnut Bread", 6.50m, 0, 6.50m);
    public static Bread frenchRye = new Bread("French Rye", 7.00m, 0, 7.00m);
    public static Bread ciabatta = new Bread("Ciabatta", 7.50m, 0, 7.50m);
    
    public static List<Bread> Breads = new List<Bread>() { countryBread, walnutBread, frenchRye, ciabatta };

    public static Pastry almondCroissant = new Pastry("Almond Croissant", 2.00m, 0, 2.00m);
    public static Pastry rhubarbTart = new Pastry("Rhubarb Tart", 3.50m, 0, 3.50m);
    public static Pastry eclair = new Pastry("Eclair", 4.50m, 0, 4.50m);
    public static Pastry baklava = new Pastry("Baklava", 2.50m, 0, 4.50m);

    public static List<Pastry> Pastries = new List<Pastry>() { almondCroissant, rhubarbTart, eclair, baklava };

    public static void Main()
    {
      string[] breads = { "Country Bread", "Walnut Bread", "French Rye", "Ciabatta" };
      decimal[] breadPrices = { 5.00m , 6.50m, 7.00m, 7.50m };
      string[] pastries = { "Almond Croissant", "Rhubarb Tart", "Eclair", "Baklava" };
      decimal[] pastryPrices = { 2.00m , 3.50m, 4.50m, 2.50m };
      
      Console.WriteLine("Welcome to Pierre's Bakery! [Press ENTER]");
      Console.ReadLine();
      Console.WriteLine("{0,21}\n", "PIERRE'S BAKERY");
      Console.WriteLine("{0,21}\n", "TODAY'S DEALS:");
      Console.WriteLine("BREADS: BUY 2 GET ONE FREE!");
      Console.WriteLine("PASTRIES: BUY 2 GET ONE 1/2 PRICE");
      Console.WriteLine("");
      Console.WriteLine("{0,15}\n", "MENU");
      Console.WriteLine("--------------------------");
      Console.WriteLine("");
      Console.WriteLine("{0,-20} {1,5}\n", "BREADS", "PRICE");
      for (int ctr = 0; ctr < breads.Length; ctr++)
        Console.WriteLine("{0,-20} {1,5:N1}", breads[ctr], ("$" + breadPrices[ctr]));
      Console.WriteLine("");
      Console.WriteLine("--------------------------");
      Console.WriteLine("");
      Console.WriteLine("{0,-20} {1,5}\n", "PASTRIES", "PRICE");
      for (int ctr = 0; ctr < pastries.Length; ctr++)
        Console.WriteLine("{0,-20} {1,5:N1}", pastries[ctr], ("$" + pastryPrices[ctr]));
      Console.WriteLine("");
      OrderType();
    }
    public static void OrderType()
    {
    Console.WriteLine("Would you like to add a Bread OR Pastry to your cart? [Type Bread or Pastry]");
    string orderType = Console.ReadLine();
      if(orderType == "Bread")
      {
        BreadOrder();
      }
      else if (orderType == "Pastry")
      {
        PastryOrder();
      }
      else
      {
        Console.WriteLine("Please Re-Enter your selection!");
        OrderType();
      }
    }
    public static void BreadOrder()
    {
      Console.WriteLine("What Type of Bread would you like to Order?");
      string breadOrderType = Console.ReadLine();
      int doesNotMatchCount = 0;
      foreach (Bread goodEat in Breads)
      {
        if (goodEat.BreadType == breadOrderType)
        {
          Console.WriteLine("How Many of the " + breadOrderType + " would you like to order?");
          int breadOrderAmount = int.Parse(Console.ReadLine());
          goodEat.BreadMod(breadOrderAmount);
          goodEat.AddList(goodEat.BreadType, goodEat.Price, goodEat.BreadCount, goodEat.SetPrice);
          Console.WriteLine(goodEat.BreadCount + " of the " + goodEat.BreadType + " have been added to your order.");
          AddOrView();
        }
        else if (goodEat.BreadType != breadOrderType)
        {
          doesNotMatchCount += 1;
          if(doesNotMatchCount == 4)
          {
            Console.WriteLine("Please Re-Enter Selection");
            BreadOrder();
          }
        }
      }
    }

    public static void AddOrView()
    {
      Console.WriteLine("Would You like to add a new bread to your order or view your order? [ADD or VIEW]");
      string addOrView = Console.ReadLine().ToLower();
      if (addOrView == "add")
      OrderType();
      else if (addOrView == "view")
      ViewOrder();
      else
      AddOrView();
    }

    public static void PastryOrder()
    {
      Console.WriteLine("What Type of Pastry would you like to Order?");
      string pastryOrderType = Console.ReadLine();
      
      foreach (Pastry goodEat in Pastries)
      {
        if (goodEat.PastryType == pastryOrderType)
        {
          Console.WriteLine("How Many of the " + pastryOrderType + " would you like to order?");
          int pastryOrderAmount = int.Parse(Console.ReadLine());
          goodEat.PastryMod(pastryOrderAmount);
          Console.WriteLine("--------------------------");
          Console.WriteLine("Bread Type: " + goodEat.PastryType);
          Console.WriteLine("Price for Each: $" + goodEat.SetPrice);
          Console.WriteLine("Amount: " + goodEat.PastryCount);
          Console.WriteLine("");
          Console.WriteLine("YOUR TOTAL = $" + goodEat.PastryPrice);
          OrderType();
        }
        else
        {
          Console.WriteLine("Please Re-Enter your Selection");
          PastryOrder();
        }
      }
    }

    public static void ViewOrder()
    {
      decimal finalPrice = 0;
      Console.WriteLine("--------------------------");
      Console.WriteLine("YOUR ORDER: ");
      Console.WriteLine();
      Console.WriteLine("BREADS:");

      List<Bread> finalOrder = Bread.GetAll();

      foreach (Bread thisBread in finalOrder)
      {
        finalPrice = thisBread.Price + finalPrice;
        Console.WriteLine();
        Console.WriteLine("TYPE: " + thisBread.BreadType);
        Console.WriteLine("AMOUNT: " + thisBread.BreadCount);
        Console.WriteLine("PRICE: " + thisBread.Price);
      }
      Console.WriteLine();
      Console.WriteLine("TOTAL PRICE: " + finalPrice);
      Console.WriteLine("Thank You!");
      Console.WriteLine();
    }
  }
}