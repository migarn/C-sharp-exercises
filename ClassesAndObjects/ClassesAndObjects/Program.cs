﻿using System;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal { Name = "Mruczek", Age = 5, Species = "kot" };
            Console.WriteLine(cat.ToString());
            cat.Move();

            Fish fish = new Fish { Name = "Rybka", Age = 6, Species = "szczupak" };
            Console.WriteLine(fish.ToString());
            fish.Move();

            Dog dog = new Dog { Name = "Rex", Age = 8, Species = "pies" };
            Console.WriteLine(dog.ToString());
            dog.Move();

            Animal anotherFish = new Fish { Name = "Rybeńka", Age = 7, Species = "węgorz" };
            Console.WriteLine(anotherFish.ToString());
            anotherFish.Move();
        }
    }

    class Animal
    { 
        public string Name { get; set; }
        public int Age { get; set; }
        public string Species { get; set; }

        public virtual void Move()
        {
            Console.WriteLine(Name + " porusza się.");
        }

        public new string ToString()
        {
            return "To zwierzę to " + Species + ", ma " + Age + " lat i ma na imię " + Name + ".";
        }
    }

    class Fish : Animal
    {
        public override void Move()
        {
            Console.WriteLine(Name + " pływa.");
        }
    }

    class Dog : Animal
    {
        public override void Move()
        {
            Console.WriteLine(Name + " biega.");
        }
    }


}
