using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekla.Structures.Model;
using Tekla.Structures.Geometry3d;


namespace HelloWorld
{
    class ExclamationPoint
    {
        public void ExclamationPointCreate()
        {
            Data data = new Data();
            data.DataVar(3000, 4000, 5000);
            var x = data.x;
            var y = data.y;
            var z = data.z;

            //first
            PlateDetail plate1 = new PlateDetail();

            var pointPlate1 = new ContourPoint(new Point(0, 0, 0),null);
            var pointPlate2 = new ContourPoint(new Point(500, 0, 0), null);
            var pointPlate3 = new ContourPoint(new Point(500, 500, 0), null);
            var pointPlate4 = new ContourPoint(new Point(0, 500, 0), null);

            plate1.ConPlate(pointPlate1, pointPlate2, pointPlate3, pointPlate4);
        }
    }
}
