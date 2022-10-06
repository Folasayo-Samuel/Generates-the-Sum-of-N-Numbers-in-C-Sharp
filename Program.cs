using System;

namespace GenerateTheSumOfNNunbers
{
	public class Program
	{
		public static void Main(string[]args)
		{
			int number, sum = 0;

			Console.Write("Enter a Number: ");
			number = Convert.ToInt32(Console.ReadLine());
			
			if(number < 0)
				Console.Write("Please Enter Positive Number");
			else
				while(number>0)
				{
					sum += number;
					number -= 1;
				}
			Console.WriteLine("The sum is "+sum);

            Console.ReadKey();
        }
	}
}