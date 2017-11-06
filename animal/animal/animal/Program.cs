using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal
{
    class Programm
    {

        static void Main(string[] args)
        {
            Animal animal = new Animal(true, 4, true, "any");
            Console.WriteLine("Animal food {0}", animal.foodType);
            Console.WriteLine("Animal makes sound: {0}", animal.makesSound());

            Dog dog = new Dog("Max", true, 4, true, "meat");

            dog.setLiveStatus(false);
            Console.WriteLine("Dog with the name {0}, {1}", dog.getName(), dog.makesSound());
            dog.setLiveStatus(true);
            Console.WriteLine("Dog with the name {0}, {1} ", dog.getName(), dog.makesSound());

            Cat cat = new Cat("Kity", true, 4, true, "meat");

            cat.setLiveStatus(false);
            Console.WriteLine("Cat with the name {0}, {1}",cat.getName(), cat.makesSound());
            cat.setLiveStatus(true);
            Console.WriteLine("Cat with the name {0}, {1} ", cat.getName(), cat.makesSound());

            Console.ReadKey();

        }


    }
}
