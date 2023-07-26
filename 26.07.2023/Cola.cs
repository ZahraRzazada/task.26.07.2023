using System;
namespace _26._07._2023
{
	public class Cola:Product
	{
        public double Litr;
        public Cola(string id, double price, int count,double litr):base( id,  price, count)
		{
			Litr = litr;
		}
		public void SatishCola()
		{
			Console.WriteLine($"Id:{Id}, Price:{Price},Count:{Count},Litr{Litr}");
            Console.WriteLine("Satish heyata kecdi");
			Count--;
			Console.WriteLine(Count);
        }
	}
}

