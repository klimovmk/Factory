﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryHeadFirst.Pizzas;

namespace FactoryHeadFirst.Stores
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(string type)
        {
            var pizza = CreatePizza(type);

            pizza.Prepair();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;

        }

        protected abstract Pizza CreatePizza(string type);
    }
}
