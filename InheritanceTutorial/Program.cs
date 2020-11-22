using System;

namespace InheritanceTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog
            {
                AnimalType = "Domestic"
            };
            Console.WriteLine("Dog is " + dog.ReturnType());
            Console.WriteLine("Dog makes sound " + dog.GetAnimalSound());

            Lion lion = new Lion();
            lion.AnimalType = "Wild";
            Console.WriteLine("Lion is " + lion.ReturnType());
            Console.WriteLine("Lion makes sound " + lion.GetAnimalSound());
        }
    }
}
