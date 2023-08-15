using FactoryHeadFirst.Ingredients.Base;
using FactoryHeadFirst.Ingredients.Impl;
using FactoryHeadFirst.Ingredients.Impl.NY;
using FactoryHeadFirst.Ingredients.Impl.NY.Vegetables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryHeadFirst.Ingredients.Factories
{
	public class NyPizzaIngredientFactory : IPizzaIngredientFactory
	{
		public Cheese CreateCheese()
		{
			return new ReggianoCheese();
		}

		public Clams CreateClams()
		{
			return new FreshClams();
		}

		public Dough CreateDough()
		{
			return new ThinCrustDough();
		}

		public Pepperoni CreatePepperoni()
		{
			return new SlicedPepperoni();
		}

		public Sauce CreateSauce()
		{
			return new MarinaraSauce();
		}

		public Veggies[] CreateVeggies()
		{
			return new Veggies[] { new Mashroom(), new Oninon(), new RedPepper(), new Garlic() };
		}
	}
}
