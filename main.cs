using System;

class Program {
  public static void Main (string[] args) {
    //prompts user input of salesperson's initial or Z
    Console.WriteLine ("Enter salesperson's initial");
    Console.WriteLine("Enter Z to quit");
    //converts user input to uppercase
    var initial = Console.ReadLine().ToUpper();

    int? grandTotal = 0;
    int? dSaleTotal = 0;
    int? eSaleTotal = 0;
    int? fSaleTotal = 0;
    
  do
  {
    switch(initial)
      {
      case "D":
        //prompts user for sale amount, converts to an int, adds it to the grand and local total, and prompts user for next salesperson's initial
        Console.WriteLine("Enter sale amount for D:");
        var dSaleAmountInput = Console.ReadLine();
        int? dSaleAmount = IsInputNumber.GetInt(dSaleAmountInput);

        //if input was not a number sets it to 0
        if(dSaleAmount == null)
          dSaleAmount = 0;
        
        dSaleTotal += dSaleAmount;
        grandTotal += dSaleAmount;

        //prompt for salesperson's initial
        Console.WriteLine("Enter salesperson's initial");
        initial = Console.ReadLine().ToUpper();
        break;
        
      case "E":
        Console.WriteLine("Enter sale amount for E:");
        var eSaleAmountInput = Console.ReadLine();
        int? eSaleAmount = IsInputNumber.GetInt(eSaleAmountInput);

        if(eSaleAmount == null)
        eSaleAmount = 0;
        
        eSaleTotal += eSaleAmount;
        grandTotal += eSaleAmount;

        Console.WriteLine("Enter salesperson's initial");
        initial = Console.ReadLine().ToUpper();
        break;
        
      case "F":
        Console.WriteLine("Enter sale amount for F:");
        var fSaleAmountInput = Console.ReadLine();
        int? fSaleAmount = IsInputNumber.GetInt(fSaleAmountInput);

        if(fSaleAmount == null)
        fSaleAmount = 0;
        
        fSaleTotal += fSaleAmount;
        grandTotal += fSaleAmount;

        Console.WriteLine("Enter salesperson's initial");
        initial = Console.ReadLine().ToUpper();
        break;
        
      default:
        Console.WriteLine("Invalid salesperson selected, input again");
        initial = Console.ReadLine().ToUpper();
        break;
      }
    }while(initial != "Z");

    //prints the each person's total, the grand total, and the person with the highest total
    Console.WriteLine("D's total: " + dSaleTotal);
    Console.WriteLine("E's total: " + eSaleTotal);
    Console.WriteLine("F's total: " + fSaleTotal);

    Console.WriteLine("Grand total: " + grandTotal);

   int highest = Math.Max(dSaleTotal ?? 0, Math.Max(eSaleTotal ?? 0, fSaleTotal ?? 0));
    if(highest == dSaleTotal)
      Console.WriteLine("Highest salesperson: D");
    else if(highest == eSaleTotal)
      Console.WriteLine("Highest salesperson: E");
    else
      Console.WriteLine("Highest salesperson: F");
  }
}