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
                Console.WriteLine(Toppings[l].ToUpper());
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
                   Console.WriteLine("duplicate topping");
                   i--;
                }
               
            }

        }
    }
}
