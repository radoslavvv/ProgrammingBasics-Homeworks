using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

class Dog
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int NumberOfLegs { get; set; }

    public void ProduceSound()
    {
        Console.WriteLine($"I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.");
    }
}
class Cat
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int IQ { get; set; }

    public void ProduceSound()
    {
        Console.WriteLine($"I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.");
    }
}
class Snake
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int CrueltyCoeff { get; set; }

    public void ProduceSound()
    {
        Console.WriteLine($"I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.");
    }
}

class Program
{
    static void Main()
    {
        string command = Console.ReadLine();

        List<Dog> dogs = new List<Dog>();
        List<Cat> cats = new List<Cat>();
        List<Snake> snakes = new List<Snake>();

        while (command != "I'm your Huckleberry")
        {
            List<string> tokens = command.Split().ToList();
            if (tokens[0] == "talk")
            {
                string name = tokens[1];
                if (dogs.Any(d => d.Name == name))
                {
                   dogs.Single(d=>d.Name == name).ProduceSound();
                }
                else if (cats.Any(c => c.Name == name))
                {
                    cats.Single(c=>c.Name == name).ProduceSound();
                }
                else if (snakes.Any(s => s.Name == name))
                {
                    snakes.Single(s=>s.Name == name).ProduceSound();
                }
            }
            else
            {
                string type = tokens[0];
                string name = tokens[1];
                int age = int.Parse(tokens[2]);
                int specialty = int.Parse(tokens[3]);

                if (type == "Dog")
                {
                    Dog currentDog = new Dog()
                    {
                        Name = name,
                        Age = age,
                        NumberOfLegs = specialty
                    };
                    dogs.Add(currentDog);
                }
                else if (type == "Cat")
                {
                    Cat currentCat = new Cat()
                    {
                        Name = name,
                        Age = age,
                        IQ = specialty
                    };

                    cats.Add(currentCat);
                }
                else if (type == "Snake")
                {
                    Snake currentSnake = new Snake()
                    {
                        Name = name,
                        Age = age,
                        CrueltyCoeff = specialty
                    };

                    snakes.Add(currentSnake);
                }
            }

            command = Console.ReadLine();
        }

        foreach (var currentDog in dogs)
        {
            Console.WriteLine($"Dog: {currentDog.Name}, Age: {currentDog.Age}, Number Of Legs: {currentDog.NumberOfLegs}");
        }

        foreach (var currentCat in cats)
        {

            Console.WriteLine($"Cat: {currentCat.Name}, Age: {currentCat.Age}, IQ: {currentCat.IQ}");
        }

        foreach (var currentSnake in snakes)
        {
            Console.WriteLine($"Snake: {currentSnake.Name}, Age: {currentSnake.Age}, Cruelty: {currentSnake.CrueltyCoeff}");
        }
    }
}

