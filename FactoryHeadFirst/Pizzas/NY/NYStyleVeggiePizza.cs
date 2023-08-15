using FactoryHeadFirst.Ingredients.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryHeadFirst.Pizzas.NY
{
	public class NYStyleVeggiePizza : Pizza
	{
		private readonly IPizzaIngredientFactory _pizzaIngredientFactory;

		public NYStyleVeggiePizza(IPizzaIngredientFactory pizzaIngredientFactory)
		{
			Name = "Ny Style Veggie Pizza";
			_pizzaIngredientFactory = pizzaIngredientFactory;
		}

		public override void Prepair()
		{
			Console.WriteLine("Preparing " + Name);
			Dough = _pizzaIngredientFactory.CreateDough();
			Sauce = _pizzaIngredientFactory.CreateSauce();
			Cheese = _pizzaIngredientFactory.CreateCheese();
			Veggies = _pizzaIngredientFactory.CreateVeggies();
		}
	}
}
