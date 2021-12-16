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
        public void ExclamationPoint1Create()
        {
            Data data = new Data();
            data.DataVar(308, 305, 500);
            var x = data.x;
            var y = data.y;
            var z = data.z;

            //first profile
            PlateDetail plate1 = new PlateDetail();

            var pointPlate1 = new ContourPoint(new Point(0 - (x / 2), 0 - (y / 2), 0),null);
            var pointPlate2 = new ContourPoint(new Point(x / 2, 0 - (y / 2), 0), null);
            var pointPlate3 = new ContourPoint(new Point(x / 2, 0 - (y / 2), z), null);
            var pointPlate4 = new ContourPoint(new Point(0 - (x / 2), 0 - (y / 2), z), null);

            plate1.ConPlate(
                pointPlate1, 
                pointPlate2, 
                pointPlate3, 
                pointPlate4, 
                Position.DepthEnum.FRONT);

            //second plate
            PlateDetail plate2 = new PlateDetail();

            var pointPlate5 = new ContourPoint(new Point(x / 2, y / 2, 0), null);
            var pointPlate6 = new ContourPoint(new Point(x / 2, y / 2, z), null);
            var pointPlate7 = new ContourPoint(new Point(0 - (x / 2), y / 2, z), null);
            var pointPlate8 = new ContourPoint(new Point(0 - (x / 2), y / 2, 0), null);

            plate2.ConPlate(
                pointPlate5, 
                pointPlate6, 
                pointPlate7, 
                pointPlate8, 
                Position.DepthEnum.BEHIND);

            //third plate
            PlateDetail plate3 = new PlateDetail();

            var pointPlate9 = new ContourPoint(new Point(0, 0 - (y / 2), 0), null);
            var pointPlate10 = new ContourPoint(new Point(0, 0 - (y / 2), z), null);
            var pointPlate11 = new ContourPoint(new Point(0, y / 2, z), null);
            var pointPlate12 = new ContourPoint(new Point(0, y / 2, 0), null);

            plate3.ConPlate(
                pointPlate9,
                pointPlate10,
                pointPlate11,
                pointPlate12,
                Position.DepthEnum.MIDDLE);
        }

        public void ExclamationPoint2Create()
        {
            Data data = new Data();
            data.DataVar(308, 305, 5000);
            var x = data.x;
            var y = data.y;
            var z = data.z;

            //first profile
            PlateDetail plate1 = new PlateDetail();

            var pointPlate1 = new ContourPoint(new Point(0 - (x / 2), 0 - (y / 2), z-4000), null);
            var pointPlate2 = new ContourPoint(new Point(x / 2, 0 - (y / 2), z - 4000), null);
            var pointPlate3 = new ContourPoint(new Point(x / 2, 0 - (y / 2), z), null);
            var pointPlate4 = new ContourPoint(new Point(0 - (x / 2), 0 - (y / 2), z), null);

            plate1.ConPlate(
                pointPlate1,
                pointPlate2,
                pointPlate3,
                pointPlate4,
                Position.DepthEnum.FRONT);

            //second plate
            PlateDetail plate2 = new PlateDetail();

            var pointPlate5 = new ContourPoint(new Point(x / 2, y / 2, z - 4000), null);
            var pointPlate6 = new ContourPoint(new Point(x / 2, y / 2, z), null);
            var pointPlate7 = new ContourPoint(new Point(0 - (x / 2), y / 2, z), null);
            var pointPlate8 = new ContourPoint(new Point(0 - (x / 2), y / 2, z - 4000), null);

            plate2.ConPlate(
                pointPlate5,
                pointPlate6,
                pointPlate7,
                pointPlate8,
                Position.DepthEnum.BEHIND);

            //third plate
            PlateDetail plate3 = new PlateDetail();

            var pointPlate9 = new ContourPoint(new Point(0, 0 - (y / 2), z - 4000), null);
            var pointPlate10 = new ContourPoint(new Point(0, 0 - (y / 2), z), null);
            var pointPlate11 = new ContourPoint(new Point(0, y / 2, z), null);
            var pointPlate12 = new ContourPoint(new Point(0, y / 2, z - 4000), null);

            plate3.ConPlate(
                pointPlate9,
                pointPlate10,
                pointPlate11,
                pointPlate12,
                Position.DepthEnum.MIDDLE);
        }
    }
}
