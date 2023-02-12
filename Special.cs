using System;
using System.Collections.Generic;
using System.Text;

namespace SuperFurr
{
    class Special
    {
        private ConsoleColor _color;
        private string _q="<3";
        public void SayQ()
        {
            Console.Write("you say ");
            Console.ForegroundColor = Color;
            Console.WriteLine(Q);
            Console.ForegroundColor= ConsoleColor.Yellow;
        }
        public string Q
        { get { return _q; } }
        public ConsoleColor Color
            { get { return _color; } }
        public Special(ConsoleColor color)
        {
            _color = color;            
        }
        public bool DogcToBool(int d)
        {
            int c = 6;
            bool b;
            b = (d == c);
            return b;
        }
    }
}
