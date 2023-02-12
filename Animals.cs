using System;
using System.Collections.Generic;
using System.Text;

namespace SuperFurr
{
    class Animal
    {
        private List<string>_fucks;
        private List<double>_gos;
        private Random _ani= new Random();
        private int _witch;
        public Animal(List<string>fucks,List<double>gos)
        {
            _fucks = fucks;
            _gos =gos;
            _witch = _ani.Next(_fucks.Count);
        }
        public List<string> Fucks
        { get { return _fucks; } }
        public List<double> Gos
            { get { return _gos; } }
        public int Witch
            { get { return _witch; } }
        public void Frecky(string sent,int get)
        {
            if (sent == "q")
                if (get < 6)
                    _witch = get;
                else _witch = Witch;
            else
                _witch=_ani.Next(_fucks.Count);
        }
        public string TheAnimal 
        { get { return Fucks[Witch]; } }
    }
}
