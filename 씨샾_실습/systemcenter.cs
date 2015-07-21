using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication12
{
    class systemcenter
    {
        private static systemcenter instance;
        public int waitnumber =0; //i
        public int m1num=0; //j
        public int m2num=0; //z
        public static systemcenter getinstance()
        {
            if (instance == null)
                instance = new systemcenter();
            return instance;
        }
    }
}
