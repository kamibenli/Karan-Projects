using System;

public class Find_Pi_to_the_Nth_Digit
{
    public static void Main(string[] args)
    {
		double pi = Math.PI;
		Console.WriteLine(pi);
		
		Console.WriteLine("Which digit of Pi you want to see?");
		int nthDigit = int.Parse(Console.ReadLine());
		
		double piPowered = pi*Math.Pow(10,nthDigit);
		
		int integerResult = (int)piPowered;
		
		Console.Write("The desired digit of Pi is:");
		Console.WriteLine(integerResult%10);
		
		
	
		
		
		
    }
}
