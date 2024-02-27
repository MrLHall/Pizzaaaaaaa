using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaaaaaaa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool valid = false;
            bool Duplicate = false;
            string[] Toppings = {"cheese", "ham","mushrooms","chicken","pepperoni","pineapple","pepper","onion","sausage"};
            Console.WriteLine("How many toppings would you like? ");
            int TopppingNum = Convert.ToInt16(Console.ReadLine());
            string[] ChoiceToppings = new string[TopppingNum];
            Console.WriteLine( "Your topping options are");
            for (int l = 0; l < Toppings.Length; l++)
            {
                Console.WriteLine(Toppings[l]);
            }
            for (int i = 0; i < TopppingNum; i++)
            {
                Console.Write($"What would you like for topping number {i+1}? >>>");
                string temp = Console.ReadLine().ToLower();
                valid = false;
                Duplicate = false;
                for (int j = 0; j < Toppings.Length; j++)
                {
                    if (temp == Toppings[j])
                    { 
                        for (int k = 0; k < ChoiceToppings.Length; k++)
                        {
                            if (temp == ChoiceToppings[k])
                            {
                                Console.WriteLine("you already have this topping");
                                Duplicate = true;
                            }
                        }
                        ChoiceToppings[i] = temp;
                        valid = true;
                    }
                }
                if (valid == false)
                {
                   Console.WriteLine("topping unavalible");
                   i--;
                }
                if (Duplicate == true)
                {
                   i--;
                }
            }
            Console.Write("What size pizza would you like? \n 1 for small \n 2 for medium \n 3 for large \n>>>>");
            int Size = Convert.ToInt16(Console.ReadLine());
            double cost = TopppingNum*0.75;
            if (Size == 1)
            {
                cost +=2.5;
            }
            else if (Size == 2)
            {
                cost +=4.5;
            }
            else if (Size == 3)
            {
                cost +=7.5;
            }
            Console.WriteLine($"The cost of your pizza is £{cost}");
        }
    }
}
