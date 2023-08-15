using FactoryHeadFirst.Ingredients.Base;

namespace FactoryHeadFirst.Ingredients.Factories
{
    public interface IPizzaIngredientFactory
	{
		Dough CreateDough();

		Sauce CreateSauce();

		Cheese CreateCheese();

		Veggies[] CreateVeggies();

		Pepperoni CreatePepperoni();

		Clams CreateClams();
	}
}
