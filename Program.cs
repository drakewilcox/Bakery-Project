using System; 
using System.Collections.Generic; 
using Bakery.Models; 

namespace CustomerOrder
{
  public class Program
  {
      public static Bread countryBread = new Bread("Country Bread", 5.00m, 1);
      public static Bread walnutBread = new Bread("Walnut Bread", 6.50m, 1);
      public static Bread frenchRye = new Bread("French Rye", 7.00m, 1);
      public static Bread ciabatta = new Bread("Ciabata", 7.50m, 1);
      
      List<Bread> Breads = new List<Bread>() { countryBread, walnutBread, frenchRye, ciabatta };

      public static Pastry almondCroissant = new Pastry("Almond Croissant", 4.00m, 1);
      public static Pastry rhubarbTart = new Pastry("Rhubarb Tart", 3.50m, 1);
      public static Pastry eclair = new Pastry("Eclair", 4.50m, 1);
      public static Pastry baklava = new Pastry("Baklava", 2.50m, 1);

      List<Pastry> Pastries = new List<Pastry>() { almondCroissant, rhubarbTart, eclair, baklava };

    public static void Main()
    {
      string[] breads = { "Country Bread", "Walnut Bread", "French Rye", "Ciabatta" };
      decimal[] breadPrices = { 5.00m , 6.50m, 7.00m, 7.50m };

      string[] pastries = { "Almond Croissant", "Rhubarb Tart", "Eclair", "Baklava" };
      decimal[] pastryPrices = { 2.00m , 3.50m, 4.50m, 2.50m };


      Console.WriteLine("Welcome to Pierre's Bakery! [Press ENTER]");
       
      Console.ReadLine();
      Console.WriteLine("{0,21}\n", "PIERRE'S BAKERY");
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
      Console.WriteLine("Would you like to order add a Bread OR Pastry to your cart? [Type Bread or Pastry]");
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
            Console.WriteLine(countryBread.BreadType);
        Console.WriteLine("BreadOrder Successful");
       
      }

      public static void PastryOrder()
      {
        Console.WriteLine("PastryOrder Successful");
      }
      

    
  }
}