using System;
using System.Collections.Generic;

namespace SuperFurr
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            string movement="", sending="";
            Animal go;
            int lust, kust,dogc;
            bool b=false,l=false;
            Special q;
            FrickyTime fricky = new FrickyTime(new List<string> { "Mouth", "Tits", "Armpits", "Hands", "Deep cumass", "Middle cumass", "Bred til preg", "Middle outass", "Pussy", "Shallow cumass", "Just the tip", "Shallow outass", "Pussylips", "Round the dounut", "Calfpits", "Feet" },"They choosed to ");
            List<string> mySecrectLove = new List<string> { "Dog", "Wolf", "Dragon", "Horse", "Cow", "Elephant" };
            List<double> countFuckyoua = new List<double> { 0.05, 0.05, 1, 1 };
            //corrup,reation,want,fert
            go = new Animal(mySecrectLove, countFuckyoua);
            q = new Special(ConsoleColor.Red);
            Console.WriteLine("Wel cum to SuperFur, Wasd to move, Q for special");
            Console.WriteLine("you are a girl in this game enter the way you want to go or to do special");
            while (b == false)
            {
                movement = Console.ReadLine().ToLower().Trim();
                if (movement == "w" || movement == "a" || movement == "s" || movement == "d" || movement == "q")
                    if (movement != "q")
                        lust = go.Witch;
                    else
                    {
                        q.SayQ();
                        Console.WriteLine("enter a number from 0 to 5");
                    }
                sending = movement;
                movement = Console.ReadLine().ToLower().Trim();
                b = int.TryParse(movement, out kust);
            }
            if (b == true)
            {
                int.TryParse(movement, out kust);
                if(kust>=6)
                    while (kust >= 6)
                {
                    Console.Clear();
                    Console.WriteLine("enter a number from 0 to 5");
                }
                else
                {
                    go.Frecky(sending, kust);
                    Console.WriteLine("A " + go.TheAnimal + " heard you say <3 and came straight to you");
                    Console.Write("Pick one 0 let him choose, 0 ");
                    Console.Write(fricky.Holes[0]+", 1 ");
                    Console.Write(fricky.Holes[1] + ", 2 ");
                    Console.WriteLine($"Armpits,  3 Hands, 4 {fricky.Holes[6]}, 5 {fricky.Holes[7]}, 6 {fricky.Holes[8]}, 7 {fricky.Holes[9]}, 8 {fricky.Holes[10]}, 9 {fricky.Holes[11]}, 10 {fricky.Holes[12]}, 11 {fricky.Holes[13]}, 12 {fricky.Holes[14]}, 13 {fricky.Holes[15]}, 14 Calfpits, 15 Feet");
                }
                movement = Console.ReadLine().Trim().ToLower();
                int.TryParse(movement, out dogc);
                if (dogc >= 16)
                    dogc = 0;
                else if (dogc <= -1)
                    dogc = 0;
                else dogc = dogc;
                fricky.YouChoose(dogc);
                if(dogc==6||dogc==8)
                    l=fricky.GotPreg(go.Gos[3],1,l,q.DogcToBool(dogc));
                if (l == true)
                    Console.WriteLine("Your pregnant");
            }
            
        }
     }
 }

