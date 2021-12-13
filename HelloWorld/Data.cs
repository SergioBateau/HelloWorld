using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekla.Structures.Model;
using Tekla.Structures.Geometry3d;

namespace HelloWorld
{
    class Data
    {
        public int x = 3000;
        public int y = 4000;
        public int z = 5000;
        public void DataVar(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;

        }
    }


}
