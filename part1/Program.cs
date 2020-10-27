using System;

namespace part1
{
    class Program
    {
        static void Main(string[] args)
		{
			Pizza p1 = new Pizza("large", 1, 1, 2);

			Pizza p2 = new Pizza(); //should return null since no size 
			p2.setNumCheeseToppings(3);
			p2.setNumHmaToppings(1);

			Pizza p3 = new Pizza("medium");
			p3.setNumPepperoniToppings(4);
			p3.setNumCheeseToppings(1);
			p3.setNumHmaToppings(2);

			Console.Out.WriteLine(p1.getDescription());
			Console.Out.WriteLine(p2.getDescription());
			Console.Out.WriteLine(p3.getDescription());
		}
	}
}
    

