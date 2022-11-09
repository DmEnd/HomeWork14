using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork14
{
    abstract class Animal
    {
        abstract public string Name { get; set; }
        public Animal()
        {
            Name = "Животное";
        }
        abstract public void Say();
        public void ShowInfo()
        {
            Console.Write("{0} ",Name);
            Say();
        }

    }
    class Cat : Animal
    {
        private string name;
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public override void Say()
        {
            Console.WriteLine("Мяу");
        }
    }
    class Dog : Animal
    {
        private string name;
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public override void Say()
        {
            Console.WriteLine("Гав");
        }
    }
}
