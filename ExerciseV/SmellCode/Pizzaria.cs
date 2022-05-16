using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseV.SmellCode
{
    internal class Pizzaria
    {
        private Pizza pizza;
        public void CriarPizza(string tipo)
        {
            if (tipo.Equals("mussarela"))
            {
                pizza = new PizzaMussarela();
            }
            else if (tipo.Equals("calabresa"))
            {
                pizza = new PizzaCalabresa();
            }
        }
    }
}
