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
      decimal[] prices = { 5.00m , 6.50m, 7.00m, 7.50m };



      Console.WriteLine("Welcome to Pierre's Bakery! [Press ENTER to Continue]");
      Console.ReadLine();
      // string menu = "MENU";
      // Console.SetCursorPosition((Console.WindowWidth - menu.Length) / 2, Console.CursorTop);
      Console.WriteLine("{0,15}\n", "MENU");
      Console.WriteLine("--------------------------");
      Console.WriteLine("");
      Console.WriteLine("{0,-20} {1,5}\n", "BREAD", "PRICE");
      for (int ctr = 0; ctr < breads.Length; ctr++)
        Console.WriteLine("{0,-20} {1,5:N1}", breads[ctr], ("$" + prices[ctr]));
      Console.WriteLine("test");
    }
  }
}