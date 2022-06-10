using System;
 
 
class Program
{
    public static void Main (string[] args)
    {
        numbercheck(502, 50);
    }
    static void numbercheck(int var1, int var2)
    {
      if (var1 == var2)
      {
        Console.WriteLine("Both numbers are equal");
      }
      if (var1 > var2)
      {
        Console.WriteLine("Var1 is greater than var2.");
      }
      if (var2 > var1)
      {
        Console.WriteLine("Var2 is greater than var1.");
      }
    }
}
