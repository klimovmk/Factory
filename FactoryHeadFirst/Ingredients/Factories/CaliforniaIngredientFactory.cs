using FactoryHeadFirst.Ingredients.Base;
using FactoryHeadFirst.Ingredients.Impl.Chicago.Vegetables;
using FactoryHeadFirst.Ingredients.Impl.Chicago;
using FactoryHeadFirst.Ingredients.Impl.NY.Vegetables;
using FactoryHeadFirst.Ingredients.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryHeadFirst.Ingredients.Factories
{
	public class CaliforniaIngredientFactory : IPizzaIngredientFactory
	{
		public Cheese CreateCheese()
		{
			return new MozzarellaCheese();
		}

		public Clams CreateClams()
		{
			return new FrozenClams();
		}

		public Dough CreateDough()
		{
			return new ThickCrustDough();
		}

		public Pepperoni CreatePepperoni()
		{
			return new SlicedPepperoni();
		}

		public Sauce CreateSauce()
		{
			return new PlumTomatoSauce();
		}

		public Veggies[] CreateVeggies()
		{
			return new Veggies[]
			{
				new BlackOlives(),
				new Spinach(),
				new Oninon(),
			};
		}
	}
}
