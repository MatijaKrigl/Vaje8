using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NALOGE8
{
    internal class Ulomek
    {
        // podatki
        private int _stevec;
        private int _imenovalec;

        
        public int Stevec
        { // lastnosti
            get { return _stevec; }
            set
            {
                _stevec = value / SKd;
                _imenovalec = _imenovalec / SKd}
        }
        public int Imenovalec
        {
            get { return _imenovalec; }
            set { if (value == 0) throw new DivideByZeroException(); }
        }



        static void Main(string[] args)
        {

        }
    }
}
