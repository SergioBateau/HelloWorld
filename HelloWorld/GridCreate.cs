using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekla.Structures.Model;
using Tekla.Structures.Geometry3d;

namespace HelloWorld
{
    class GridCreate
    {
        public void GridCreating()
        {
            Grid grid = new Grid();

            grid.IsMagnetic = false;   
            grid.CoordinateX = "0.00 14*3000.00";
            grid.CoordinateY = "0.00 3*4000.00";
            grid.LabelX = "A B C D E F G H I J K L M N O";
            grid.LabelY = "1 2 3 4";
            

            bool Result = false;
            Result = grid.Insert();
        }

    }
}
