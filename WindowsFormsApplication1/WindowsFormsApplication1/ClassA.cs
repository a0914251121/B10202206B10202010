using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class ClassA
    {
        public int GetNumber()
        {
            Random a = new Random();
            int x;
            x = a.Next(1, 100);
            return x;



        }
    }
}