using System;
 namespace Project1
{
    class ParentClass
    {
        static void Main (string[] args)
        {
            //We are calling the parent classes and assigning them onto an object
            Animal myAnimal = new Animal();
            Animal myPig = new Pig();
            Animal myDog = new Dog();

            //we are calling the child classes throught the objects we created (in this case there are no parameters in the child classes)
            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();
        }

        //Parent class
        class Animal
        {
            //Child class
            public virtual void animalSound()
            {
               Console.WriteLine("Animal makes sound");
            }
        }
        //Overriding the child class
        class Dog : Animal
        {
            public override void animalSound()
            {
                Console.WriteLine("Dog makes sound");
            }
        }
        //Also overriding child class
        class Pig: Animal
        {
            public override void animalSound()
            {
                 Console.WriteLine("Pig makes sound");
            }
        }


    }
}