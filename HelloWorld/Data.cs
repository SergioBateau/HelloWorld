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
        public int x;
        public int y;
        public int z;
        public void DataVar(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;

        }
    }


}
