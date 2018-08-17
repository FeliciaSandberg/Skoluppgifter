using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkpoint_2__Egen_övning_
{
    class Program
    {
        static void Main(string[] args)
        {
            var PetList = new List<Pet>();
            // fråga användaren om en sträng
            Console.WriteLine("Skriv en lista enligt nedan");
            Console.WriteLine("Petname (number)y gender / petname (number)y gender");
            //användarens sträng
            string Pets = "Cat 12y female / Dog 3y male / Bird 45y Female / Fish 1y Female"; //Console.ReadLine();

            //splitta strängen på "/" samt trimma
            var SplitPets = Pets.Trim().Split('/');


            //lägg in i en foreach loop och splitta igen på " "
            //lägg till varje element i PetList

            foreach (var pet in SplitPets)
            {
                var Pet = new Pet();
                var SplitPetsNew = pet.Trim().Split(' ');

                string NameOfPet = SplitPetsNew[0];
                string AgeOfPet = SplitPetsNew[1].Replace("y", "");
                string GenderOfPet = SplitPetsNew[2];

                Pet.Name = NameOfPet;
                Pet.Age = int.Parse(AgeOfPet);
                Pet.Gender = (Gender)Enum.Parse(typeof(Gender), GenderOfPet, true);

                PetList.Add(Pet);

            }
            Console.WriteLine();


            //skriv ut djurets namn och ålder
            int i = 1;
            foreach (var Pet in PetList)
            {
                
                Console.WriteLine($"* Namn på djur {i}: {Pet.Name}");
                i++;
            }

            //skriver ut vilket djur som är äldst 
            var OldestPet = new Pet
            {
                Name = PetList[0].Name,
                Age = PetList[0].Age,
                Gender = PetList[0].Gender
            };
     
            foreach (var Pet in PetList)
            {
                if (Pet.Age > OldestPet.Age)
                {
                    OldestPet.Age = Pet.Age;
                    OldestPet.Name = Pet.Name;
                    OldestPet.Gender = Pet.Gender;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Det äldsta djuret är {OldestPet.Name} som är {OldestPet.Age} år gammal");
            Console.WriteLine();

            //skriver ut vilket djur som är yngst 
            var YoungestPet = PetList.OrderBy(x => x.Age).First();
            Console.WriteLine($"Det yngsta djuret är {YoungestPet.Name} som är {YoungestPet.Age} år gammal");
            Console.WriteLine();


            //skriver ut sorterad lista i alfabetisk ordning sorterad efter namn
            int j = 1;
            foreach (var pet in PetList.OrderBy(x=> x.Name))
            {
                Console.WriteLine($"* Namn på djur {j}: {pet.Name.ToUpper()}");
                j++;
            }

            Console.ReadKey();
        }
    }
}
