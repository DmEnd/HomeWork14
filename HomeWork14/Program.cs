using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork14
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Cat cat= new Cat();
            cat.ShowInfo();

            cat.Name = "Мурка";
            cat.ShowInfo();
            cat.Say();


            Dog dog = new Dog();
            dog.ShowInfo();

            dog.Name = "Шарик";
            dog.ShowInfo();
            dog.Say();
            Console.ReadKey();
        }
    }
}
