using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekla.Structures.Model;
using Tekla.Structures.Geometry3d;

namespace HelloWorld
{
    class PlateDetail
    {
        public void ConPlate(
            ContourPoint pointPlate1, 
            ContourPoint pointPlate2, 
            ContourPoint pointPlate3, 
            ContourPoint pointPlate4
            )
        {
            ContourPlate plate = new ContourPlate();

            //ContourPoint pointPlate1 = new ContourPoint(new Point(), null);
            //ContourPoint pointPlate2 = new ContourPoint(new Point(), null);
            //ContourPoint pointPlate3 = new ContourPoint(new Point(), null);
            //ContourPoint pointPlate4 = new ContourPoint(new Point(), null);

            plate.AddContourPoint(pointPlate1);
            plate.AddContourPoint(pointPlate2);
            plate.AddContourPoint(pointPlate3);
            plate.AddContourPoint(pointPlate4);

            plate.Profile.ProfileString = "PL6";
            plate.Material.MaterialString = "250";
            plate.Class = "4";
            plate.Position.Depth = Position.DepthEnum.FRONT;
            bool result = false;
            result = plate.Insert();

        }
    }
}
