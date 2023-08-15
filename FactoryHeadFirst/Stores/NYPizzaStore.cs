using FactoryHeadFirst.Ingredients.Factories;
using FactoryHeadFirst.Pizzas;
using FactoryHeadFirst.Pizzas.NY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryHeadFirst.Stores
{
	public class NYPizzaStore : PizzaStore
	{
		protected override Pizza CreatePizza(string type)
		{
			IPizzaIngredientFactory pizzaIngredientFactory = new NyPizzaIngredientFactory();
			switch (type)
			{
				case "Cheese":
					return new NYStyleCheesePizza(pizzaIngredientFactory);
				case "Clam":
					return new NYStyleClamPizza(pizzaIngredientFactory);
				case "Pepperoni":
					return new NYStylePepperoniPizza(pizzaIngredientFactory);
				case "Veggie":
					return new NYStyleVeggiePizza(pizzaIngredientFactory);
				default:
					throw new ArgumentException($"Don't exist pizza with type - {type}");
			}
		}
	}
}
