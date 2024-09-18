using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Assignment1
{
    class Pet
    {
        private string name;
        private int age;
        private bool isFemale;

        public void Start()
        {
            Console.WriteLine();
            Console.WriteLine("Hello and Welcome!");
            Console.WriteLine();

            SavePetInfo();
            ShowPetInfo();
        }

        private void SavePetInfo()
        {
            Console.WriteLine("What's the name of your pet?");
            name = Console.ReadLine();

            Console.WriteLine("What is " + name + "'s age?");
            string textValue = Console.ReadLine();
            age = int.Parse(textValue);


            Console.WriteLine("Are you pet a female (y/n?)");
            string stringGender = Console.ReadLine();

            char response = stringGender[0];
            if ((response == 'y') || (response == 'Y'))
                isFemale = true;
            else
                isFemale = false;
            

        }

        private void ShowPetInfo()
        {
            Console.WriteLine();
            Console.WriteLine("------------------");
            Console.WriteLine();

            string textOut = "Name: " + name + " Age: " + age;
            Console.WriteLine(textOut);



            if (isFemale == true)
                Console.WriteLine(name + " is such a wonderful girl");
            else
                Console.WriteLine(name + " is such a wonderful boy");


            Console.WriteLine();
            Console.WriteLine("------------------");
            Console.WriteLine();

        }
    }
}
