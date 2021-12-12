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
        int coordX = 0;
        int coordY = 0;
        int coordZ = 0;
        public void DataVar(int x, int y, int z)
        {
            this.coordX = x;
            this.coordY = y;
            this.coordZ = z;
        }
    }
}
