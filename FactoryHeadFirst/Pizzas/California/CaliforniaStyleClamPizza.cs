using FactoryHeadFirst.Ingredients.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryHeadFirst.Pizzas.California
{
	public class CaliforniaStyleClamPizza : Pizza
	{
		private readonly IPizzaIngredientFactory _pizzaIngredientFactory;

		public CaliforniaStyleClamPizza(IPizzaIngredientFactory pizzaIngredientFactory)
		{

			Name = "California Style clams Pizza";
			_pizzaIngredientFactory = pizzaIngredientFactory;
		}


		public override void Prepair()
		{
			Console.WriteLine("Preparing " + Name);
			Dough = _pizzaIngredientFactory.CreateDough();
			Sauce = _pizzaIngredientFactory.CreateSauce();
			Cheese = _pizzaIngredientFactory.CreateCheese();
			Clams = _pizzaIngredientFactory.CreateClams();
		}
	}
}
