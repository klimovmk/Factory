using FactoryHeadFirst.Ingredients.Factories;
using FactoryHeadFirst.Pizzas;
using FactoryHeadFirst.Pizzas.Chicago;
using FactoryHeadFirst.Pizzas.Chicago;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryHeadFirst.Stores
{
	public class ChicagoPizzaStore : PizzaStore
	{
		protected override Pizza CreatePizza(string type)
		{
			IPizzaIngredientFactory pizzaIngredientFactory = new ChicagoIngredientFactory();
			switch (type)
			{
				case "Cheese":
					return new ChicagoStyleCheesePizza(pizzaIngredientFactory);
				case "Clam":
					return new ChicagoStyleClamPizza(pizzaIngredientFactory);
				case "Pepperoni":
					return new ChicagoStylePepperoniPizza(pizzaIngredientFactory);
				case "Veggie":
					return new ChicagoStyleVeggiePizza(pizzaIngredientFactory);
				default:
					throw new ArgumentException($"Don't exist pizza with type - {type}");
			}
		}
	}
}
