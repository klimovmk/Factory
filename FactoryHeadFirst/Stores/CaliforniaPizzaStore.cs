using FactoryHeadFirst.Ingredients.Factories;
using FactoryHeadFirst.Pizzas;
using FactoryHeadFirst.Pizzas.California;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryHeadFirst.Stores
{
	public class CaliforniaPizzaStore : PizzaStore
	{
		protected override Pizza CreatePizza(string type)
		{
			IPizzaIngredientFactory pizzaIngredientFactory = new CaliforniaIngredientFactory();
			switch (type)
			{
				case "Cheese":
					return new CaliforniaStyleCheesePizza(pizzaIngredientFactory);
				case "Clam":
					return new CaliforniaStyleClamPizza(pizzaIngredientFactory);
				case "Pepperoni":
					return new CaliforniaStylePepperoniPizza(pizzaIngredientFactory);
				case "Veggie":
					return new CaliforniaStyleVeggiePizza(pizzaIngredientFactory);
				default:
					throw new ArgumentException($"Don't exist pizza with type - {type}");
			}
			
		}


	}

}
