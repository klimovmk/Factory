using FactoryHeadFirst.Ingredients.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryHeadFirst.Pizzas.California
{
	public class CaliforniaStylePepperoniPizza : Pizza
	{
		private readonly IPizzaIngredientFactory _pizzaIngredientFactory;

		public CaliforniaStylePepperoniPizza(IPizzaIngredientFactory pizzaIngredientFactory)
		{
			Name = "California Style Pepperoni Pizza";
			_pizzaIngredientFactory = pizzaIngredientFactory;
		}

		public override void Prepair()
		{
			Console.WriteLine("Preparing " + Name);
			Dough = _pizzaIngredientFactory.CreateDough();
			Sauce = _pizzaIngredientFactory.CreateSauce();
			Cheese = _pizzaIngredientFactory.CreateCheese();
			Pepperoni = _pizzaIngredientFactory.CreatePepperoni();
		}
	}
}
