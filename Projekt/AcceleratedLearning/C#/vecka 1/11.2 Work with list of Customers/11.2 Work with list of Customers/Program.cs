using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _11._2_Work_with_list_of_Customers
{
    class Program
    {
        static void Main(string[] args)
        {
            var ListOfPeople = new List<Person>();
            var allPeople = File.ReadAllLines("TextFile1.txt");

            foreach (var Line in allPeople)
            {
                string[] SplittedLine = Line.Split(',');
                var id = SplittedLine[0];
                var firstname = SplittedLine[1];
                var lastname = SplittedLine[2];
                var email = SplittedLine[3];
                var gender = SplittedLine[4];
                var age = SplittedLine[5];

                var p = new Person();
                p.ID = int.Parse(id);
                p.FirstName = firstname;
                p.LastName = lastname;
                p.Email = email;
                p.Gender = gender;
                p.Age = int.Parse(age);

                ListOfPeople.Add(p);
                
            }

            Header("sortera efter ålder");
            foreach (var person in ListOfPeople.OrderBy(x => x.Age))
            {
                WriteInfoAboutPeople(person);
            }

            Header("sortera efter förnamn");
            foreach (var person in ListOfPeople.OrderBy(x => x.FirstName)) 
            {
                WriteInfoAboutPeople(person);
            }

            Header("sortera efter män äldre än 35");
            foreach (var person in ListOfPeople
                .Where(x => x.Gender == "Male" && x.Age > 35)
                .OrderBy(x => x.Age))
            {
                WriteInfoAboutPeople(person);
            }

            //List<int> x1 = ListOfPeople.Select(x => x.Age).ToList();

            //List<string> x2 = ListOfPeople.Select(x => x.FirstName).ToList();

            //List<Person> x3 = ListOfPeople.Select(x => new Person { FirstName="Boris" }).ToList();

            List<Person> x4 = ListOfPeople.Select(x => new Person{FirstName = x.FirstName.ToUpper(), Age = x.Age + 1000, Gender = x.Gender}).ToList();

            Header("Manipulated:");
            foreach (var person in x4)
            {
                WriteInfoAboutPeople(person);
            }

            Console.ReadKey();
        }

        private static void WriteInfoAboutPeople(Person person)
        {
            Console.WriteLine($" {person.FirstName.PadRight(10)}  {person.Age.ToString().PadRight(10)} {person.Gender}");
        }

        private static void Header(string v)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n {v.ToUpper()} \n");
            Console.ResetColor();
        }

        
    }
}
