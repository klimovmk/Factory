using FactoryHeadFirst.Ingredients.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryHeadFirst.Pizzas.California
{
	public class CaliforniaStyleCheesePizza : Pizza
	{
		private readonly IPizzaIngredientFactory _pizzaIngredientFactory;

		public CaliforniaStyleCheesePizza(IPizzaIngredientFactory pizzaIngredientFactory)
		{

			Name = " California Style Deep Dish Cheese Pizza";
			_pizzaIngredientFactory = pizzaIngredientFactory;
		}

		public override void Cut()
		{
			Console.WriteLine("Cutting the pizza into square slices");
		}

		public override void Prepair()
		{
			Console.WriteLine("Preparing " + Name);
			Dough = _pizzaIngredientFactory.CreateDough();
			Sauce = _pizzaIngredientFactory.CreateSauce();
			Cheese = _pizzaIngredientFactory.CreateCheese();
		}
	}
}
