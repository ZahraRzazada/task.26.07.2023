using System;
namespace _26._07._2023
{
	public class Plant:Product
	{
        public string Catagory;
        public Plant(string id, double price, int count,string catagory):base(id, price, count)
		{
			Catagory = catagory;
		}
        public void SatishPlant()
        {
            Console.WriteLine($"Id:{Id}, Price:{Price},Count:{Count},Catagory:{Catagory}");
            Console.WriteLine("Satish heyata kecdi");
             Count--;
            Console.WriteLine(Count);
        }
       
    }
}

