using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    class Program
    {
        static void Main(string[] args)
        {

            Cat cat = new Cat();
            Dog dog = new Dog();
            cat.Say();
            cat.ShowInfo();
            dog.Say();
            dog.ShowInfo();

            Console.ReadKey();


        }
        abstract class Animal

        {
            public abstract string Name { get;}

            public abstract void Say();
            
            public void ShowInfo()
            {
                string say = Say();
                Console.WriteLine("{0} {1}", Name, say);
            }
        }
        class Cat : Animal
        {

            public override string Name => "Кошка";

            public override void Say()
            {
                Console.WriteLine("Мяу");
            }
        }

        class Dog : Animal
        {

            public override string Name => "Собака";

            public override void Say()
            {
                Console.WriteLine("Гав");
            }
        }

    }
       
}
