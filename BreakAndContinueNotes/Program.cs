using System.ComponentModel;
using System.Text.Json;
					
public class Program
{
	public static void Main()
	{
       //expression-bodied methods through Lambda

       //simple method one liner to replace
       // static int add(int x, int y)


        static int Add(int x, int y) => x + y;
        static bool IsEven(int x) => x % 2 == 0;  
        static string FullName(string first, string last) => first + "" + last;
        static void Printnumber(int number) => Console.WriteLine(number);

        static double CalculateTotal() => UtahSalesTax() * CalculateShoppingCartSubTotal();

        static double UtahSalesTax() => 8.0;
        static double CalculateShoppingCartSubTotal();
        {
            //template
            //this is our code that is generally longer
            //so long
            //this 
            //code
            // is
        }


        //usually our expression bodied methods are short methods combining the work
        //  of longer bodied methods together, but short hand on short hand is acceptable it just doesnt usualyl happen
        //not incredibly 1000% vital but other people use it and you should be use to it

    }
}
