using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class ClassB
    {
        public bool IsPrime(int n)
        {


            if (n < 2)
            {
                return false;
            }

            for (int i = 2; i < n; ++i)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;

        }
    }

}