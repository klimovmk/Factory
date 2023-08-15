using FactoryHeadFirst.Pizzas;
using FactoryHeadFirst.Stores;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
	internal class Program
	{
		static void Main(string[] args)
		{
			PizzaStore californiaStore = new CaliforniaPizzaStore();
			PizzaStore chicagoStore = new ChicagoPizzaStore();

			Pizza pizza = californiaStore.OrderPizza("Cheese");

			Console.WriteLine($"Ethan ordered -  {pizza.Name}");

			Pizza pizza2 = chicagoStore.OrderPizza("Cheese");

			Console.WriteLine($"Joel orederd - {pizza2.Name}");

		}
	}
}