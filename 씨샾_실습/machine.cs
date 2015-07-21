using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication12
{
    class machine
    {
        systemcenter Center = systemcenter.getinstance();
        private static machine instance;
        public static machine getinstance()
        {
            if (instance == null)
                instance = new machine();
            return instance;
        }

        public int sum(int j)
        {
           return j += 1;
        }
    }
}
