using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Kocka
{
    internal class RazredKocka
    {
        private int _stranica;

        public int Stranica
        {
            get { return _stranica; }
            set 
            {
                if (value < 0) throw new ArgumentOutOfRangeException(nameof(value), "Dolžine ne more biti negativna!");
                else if (value.Equals(0)) throw new ArgumentException("Kocka ne obstaja!");
                else _stranica = value;
            }
        }

        public RazredKocka()
        { // konstruktor brez parametra
            Stranica = 1;
        }
        public RazredKocka(int stranica) 
        { // konstruktor
            _stranica = stranica;  
        }

        public int Povrsina()
        { return _stranica * 6; }
        public int Volumen()
        { 
            return (int)Math.Pow(_stranica, 3);
        }
        public override string ToString()
        {
            return "Kocka ima stranico velikosti" + _stranica;
        }
    }
}
