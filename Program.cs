using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orokles
{
    class Program
    {
        static void Teszt1()
        {
            Terkep terkep = new Terkep(80, 25);
            TerkepRajzolo rajzolo = new TerkepRajzolo(terkep);
            rajzolo.Kirajzol();
        }

        static void Main(string[] args)
        {
            Teszt1();
        }
    }
}
