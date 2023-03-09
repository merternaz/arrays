using System;
using System.Collections.Generic;

namespace arraysPr
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            int[] sayilar={3,9,15,10,6,12,21,25,11};

            Console.WriteLine("***array****");
            foreach(var i in sayilar){
                Console.WriteLine(i);
            }


            Console.WriteLine("***sorted array****");
            Array.Sort(sayilar);
            foreach(var i in sayilar){
                Console.WriteLine(i);
            }

             Console.WriteLine("***reverse sorted array****");
             Array.Sort(sayilar);
            Array.Reverse(sayilar);
            foreach(var i in sayilar){
                Console.WriteLine(i);
            }


            Console.WriteLine("***Clear 3,3 array****");
             Array.Clear(sayilar,3,3);
            
            foreach(var i in sayilar){
                Console.WriteLine(i);
            }

            Console.WriteLine("***IndexOf--elemanını indexini verir****");
             Console.WriteLine(Array.IndexOf(sayilar,21));

             Console.WriteLine("***Resize****");
             Array.Resize(ref sayilar,4);
             foreach(var i in sayilar){
                Console.WriteLine(i);
            }
        }
    }
}