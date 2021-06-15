using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalregister
{
    public class Person
    {
        String perName;
        String perEfter;
        float perSalary;

        public Person()
        {
            perName = " ";
            perEfter = " ";
            perSalary = 0;
        }
        public void addPerson()
        {
            Console.WriteLine("Namn: ");
            perName = Console.ReadLine();
            if (perName == " ");
            {
                Console.WriteLine("Du måste ange ett namn!");
                Console.WriteLine("Namn: ");
                perName = Console.ReadLine();
            }
            Console.WriteLine("Efternamn: ");
            perEfter = Console.ReadLine();
            if (perEfter == " ");
            {
                Console.WriteLine("Du måste ange ett efternamn!");
                Console.WriteLine("Efternamn: ");
                perEfter = Console.ReadLine();
            }

            Console.WriteLine("Lön: ");

            //perSalary = Console.ReadLine();
            perSalary = Single.Parse(Console.ReadLine()); // Fick googla
            if (perSalary == 0); //Jag vet inte hur kan jag kontrollera att inmatningen är inte tomt
            {
                Console.WriteLine("Du måste ange ett lön!");
                Console.WriteLine("Lön: ");
                perSalary = Single.Parse(Console.ReadLine());
            }            
        }
        public void printData()
        {
            Console.Clear();
            Console.WriteLine(perName + "\n");
            Console.WriteLine(perEfter + "\n");
            Console.WriteLine(perSalary + "\n");
        }

    }
}
