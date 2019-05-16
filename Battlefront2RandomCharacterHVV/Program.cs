using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battlefront2RandomCharacterHVV
{
    class Program
    {
        public void ChooseRando()
        {
            string[] lightSide = new string[]{"Luke Skywalker", "Han Solo", "Leia Organa", "Chewbacca", "Lando Calrissian", "Rey",
"Yoda", "Finn", "Obi-Wan Kenobi", "Anakin Skywalker"};
            string[] darkSide = new string[] {"Boba Fett", "Bossk", "Darth Vader", "Emperor Palpatine", "Kylo Ren", "Darth Maul", "Iden Versio",
"Captain Phasma", "General Grievous", "Count Dooku" };
            Console.WriteLine("Are you playing on the light side or dark side?");
            string lightOrDark = Console.ReadLine().ToLower();
            if (lightOrDark.Contains("light"))
            {
                Random rand = new Random();
                int lightIndex = rand.Next(lightSide.Length);
                Console.WriteLine( $"Choose {lightSide[lightIndex]}");

            }
            else if (lightOrDark.Contains("dark"))
            {
                Random rand = new Random();
                int darkIndex = rand.Next(darkSide.Length);
                Console.WriteLine($"Choose {darkSide[darkIndex]}");
            }
            else
            {
                Console.WriteLine( "Did you pick a side?");
            }
            Console.WriteLine("Want to try again?");
            string answer = Console.ReadLine().ToLower();
            if (answer.Contains("yes"))
            {
                ChooseRando();
                Console.WriteLine("Want to try again?");
            }
            else
            {
                Environment.Exit(0);
            }
        }





        static void Main(string[] args)
        {

            Program prog = new Program();
            prog.ChooseRando();
            for(int i = 0; i < 1000; i++)
            {
                    prog.ChooseRando();
            }
             
                
            
        }
    }
}
