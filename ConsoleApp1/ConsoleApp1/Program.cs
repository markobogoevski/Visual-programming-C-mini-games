using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Pizza
    {
        public string pizzaName;
        public string ingredients;
        public int discount;
        public int price;

        public Pizza()
        {
        }

        public Pizza(string pizzaName, string ingredients, int discount, int price)
        {
            this.pizzaName = pizzaName;
            this.ingredients = ingredients;
            this.discount = discount;
            this.price = price;
        }

       

        public bool sameWith(Pizza otherPizza)
        {
            return ingredients == otherPizza.ingredients;
        }

        public override bool Equals(object obj)
        {
            var pizza = obj as Pizza;
            return pizza != null &&
                   ingredients == pizza.ingredients;
        }

        public override int GetHashCode()
        {
            return -1519974369 + EqualityComparer<string>.Default.GetHashCode(ingredients);
        }

        public override string ToString()
        {
            return String.Format("{0} - {1}, {2} ", pizzaName, ingredients, price);
        }

        public double discountPrice()
        {
            return price * (discount / 100.0);
        }
    }

    class PizzaRestaurant
    {
        public string name;
        ArrayList pizzaList;

        public PizzaRestaurant(string name)
        {
            this.name = name;
            pizzaList = new ArrayList();
        }

        public bool addPizza(Pizza p)
        {
            if (!pizzaList.Contains(p))
            {
                pizzaList.Add(p);
                return true;
            }
            return false;
        }

        public void promotionPizzas()
        {
            ArrayList promotionList = new ArrayList();
            foreach(Pizza pizza in pizzaList)
            {
                if (pizza.discount > 0)
                    promotionList.Add(pizza);
            }
            StringBuilder stringBuilder = new StringBuilder();
            foreach (Pizza pizza in promotionList)
                stringBuilder.Append(pizza).Append(pizza.discountPrice()).Append("\n");

            Console.WriteLine(stringBuilder.ToString());
        }


    }
    class Program
    { 
        static void Main(string[] args)
        {
            

        }
    }
}
