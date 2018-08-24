using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._2_Custom_interfaces
{
    class Pet
    {
        public string Name { get; set; }
    }

    class Cat : Pet, IFriendly
    {
        public void Greet()
        {
            Console.WriteLine($"The cat {Name} says meow");
        }
      
        public void ThanksForDinner(string meal)
        {
            Console.WriteLine($"The cat {Name} thank you for the {meal}");
        }

        public Cat(string n)
        {
            Name = n;
        }

        public void DoNiceThings(IFriendly Cat)
        {
            Greet();
            ThanksForDinner();
        }
    }

    class Dog : Pet, IFriendly, IAggressive
    {
        public int Bite()
        {
           
        }

        public void Greet()
        {
            Console.WriteLine($"The dog {Name} says woof");
        }

        public void ShowTeeth()
        {
            Console.WriteLine($"The dog {Name} show his teeth");
            Console.WriteLine($"The dog {Name} bit you!");
        }

        public void ThanksForDinner(string meal)
        {
            Console.WriteLine($"The dog {Name} thank you for the {meal}");
        }

        public Dog(string n)
        {
            Name = n;
        }

        

        public void DoMeanThings(IAggressive Dog)
        {
            ShowTeeth();
            Bite();

        }

    }

    /// Interface

    public interface IFriendly
    {
        void Greet();
        void ThanksForDinner(string meal);
    }

    public interface IAggressive
    {
        int Bite();
        void ShowTeeth();
    }


}
