using System; 
using System.Collections.Generic; 
// using Bakery.Models; 

namespace CustomerOrder
{
  public class Program
  {
    public static void Main()
    {
      string[] breads = { "Country Bread", "Walnut Bread", "French Rye", "Ciabatta" };
      decimal[] breadPrices = { 5.00m , 6.50m, 7.00m, 7.50m };

      string[] pastries = { "Almond Croissant", "Rhubarb Tart", "Eclair", "Baklava"   };
      decimal[] pastryPrices = { 4.00m , 3.50m, 4.50m, 2.50m };

    

      Bread countryBread = new Bread("Country Bread", 5.00m);
      Bread walnutBread = new Bread("Walnut Bread", 6.50m);
      Bread frenchRye = new Bread("French Rye", 7.00m);
      Bread Ciabatta = new Bread("Ciabata", 7.50m);
      
      Pastry almondCroissant = ("Almond Croissant", 4.00m);
      Pastry rhubarbTart = ("Rhubarb Tart", 3.50m);
      Pastry eclair = ("Eclair", 4.50m);
      Pastry baklava = ("Baklava", 2.50m);


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

      Console.WriteLine()
    }
  }
}