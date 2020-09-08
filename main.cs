using System;
class MainClass {
  public static void Main (string[] args) {
  Console.WriteLine("Enter the name of item:");
   string name = Console.ReadLine();
  Console.WriteLine("Enter the quantity:");
   int item1 = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Enter the price:");
   double price1 = Convert.ToDouble(Console.ReadLine());
  Console.WriteLine("Total price of " + name + " = $ " + item1* price1);
  
  
  
  
  
  
 
 }
}