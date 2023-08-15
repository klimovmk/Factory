using FactoryHeadFirst.Ingredients.Base;
using System.Collections;

namespace FactoryHeadFirst.Pizzas
{
	public abstract class Pizza
	{
		public string Name { get; protected set; }

		public Dough Dough { get; protected set; }

		public Sauce Sauce { get; protected set; }

		public Veggies[] Veggies { get; protected set; }

		public Cheese Cheese { get; protected set; }

		public Pepperoni Pepperoni { get; protected set; }

		public Clams Clams { get; protected set; }


		public void Bake()
		{
			Console.WriteLine($"{nameof(Bake)} - {this.GetType().Name}");
		}

		public void Box()
		{
			Console.WriteLine($"{nameof(Box)} - {this.GetType().Name}");
		}

		public virtual void Cut()
		{
			Console.WriteLine($"{nameof(Cut)} - {this.GetType().Name}");
		}

		public abstract void Prepair();

	
	}
}
