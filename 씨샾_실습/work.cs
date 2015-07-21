using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication12
{
    class work
    {
        private static work instance;
        private int num;
       
        public static work getinstance()
        {
            if (instance == null)
                instance = new work();
            return instance;
        }
        public int number()
        {
            return num;
        }
    }
}
