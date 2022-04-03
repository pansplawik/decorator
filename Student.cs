using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wzorce
{
    class Student:Direction,TypeOfStudent
    {
        string name;
        string surname;
        int NumberTerm;

        public Student(string name, string surname, int numberTerm, string nameDirection, string nameUniveristy, string cityOrRegion) :base(nameDirection,nameUniveristy, cityOrRegion)
        {
            this.name = name;
            this.surname = surname;
            NumberTerm = numberTerm;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int NumberTerm1 { get => NumberTerm; set => NumberTerm = value; }
        public void Beer()
        {
            Random random = new Random();
            Random r = new Random();
            string beer = Enum.GetName(typeof(Beer), random.Next(4));
            Console.WriteLine($"What! {r.Next(10)} for {beer} is perfect prize! ");
        }
        public void DiscountStudents()
        {
            Console.WriteLine("Do you have any discount for Student");
        }
        public void Introduce()
        {
            Console.WriteLine($"My name {name}, surname {surname}. I'm student {NumberTerm} term {NameDirection} in {NameUniveristy}");
        }
    }
    enum Beer
    {
        Tyskie=1,
        Warka,
        Żywiec,
        Namysłów
    }
    interface TypeOfStudent
    {
        public void DiscountStudents()
        {
        }   
        public void Beer()
        {
        }
        public void Introduce()
        {

        }

    }
}
