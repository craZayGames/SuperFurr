using System;
using System.Collections.Generic;
using System.Text;

namespace SuperFurr
{
    class FrickyTime
    {
        private List<string>_holes=new List<string>();
        private string _addAfter;
        private Random _choises=new Random();
        private int _theyChoose;
        public FrickyTime(List<string> holes, string addAfter)
        {
            int bill;
            _addAfter = addAfter;
            _holes = holes;
            bill = _holes.IndexOf("Armpits");
            _holes[bill] = _holes[bill].Replace("Armpits", "Left Armpit");
            _holes.Insert(bill + 1, "Right Armpit");
            bill = _holes.IndexOf("Hands");
            _holes[bill] = _holes[bill].Replace("Hands", "Left Hand");
            _holes.Insert(bill + 1, "Right Hand");
            bill = _holes.IndexOf("Calfpits");
            _holes[bill] = _holes[bill].Replace("Calfpits", "Left Calfpit");
            _holes.Insert(bill + 1, "Right Calfpit");            
        }
        public int TheyChoose
        { get { return _theyChoose; } }
        public void YouChoose(int hole)
        {
            if (hole > 0 && hole < Holes.Count)
            {
                _theyChoose = hole;
                Console.Write(_addAfter.Replace("They", "You"));
            }
            else
            {
                _theyChoose = _choises.Next(Holes.Count);
                Console.Write(TheyChoose);
            }
            if (hole > 0 && hole < 17)
            {
                if (hole == 2)
                    hole = hole + _choises.Next(2);
                else hole = hole + 1;
                if (hole == 4)
                    hole = hole + _choises.Next(2);
                else hole = hole + 1;
            }
            else if (hole == 17)
                hole = hole + _choises.Next(2);
            else
                hole = hole + 1;
            Console.WriteLine(Holes[hole]);
        }
        public List<string> Holes
            { get { return _holes; } }
        public bool GotPreg(double fert,double you,bool already,bool BTPorP)
        {
            double d;
            bool b = false,m=true;
            if (already == false)
                if (BTPorP == true)
                    if (fert == you)
                        m= true;
                    else 
                    {
                        while (b == false)
                        { 
                            d = fert / you;
                            if (d < 0)
                                d *= -1;
                            else if (d > 0.05)
                            { m= true; b = true; }
                            else { m= false;b = true; }                            
                        }
                    }
                else
            {
                    b = true;
                    d = fert / you;
                    while(b==true)
                    {
                        if(d<0)
                            d*= -1;
                        else if(d>0.69)
                        { m= true;b = false; }
                        else { m= false;b = false; }
                    }
            }
            else m= false;
            return m;
        }
    }
    
}
