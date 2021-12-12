using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekla.Structures.Model;
using Tekla.Structures.Geometry3d;

namespace HelloWorld
{
    class HorizontalBeam
    {
        public void HorBeam(Point firstPoint, Point secondPoint, Position.DepthEnum dep)
        {
            Beam beam = new Beam();
            beam.StartPoint = firstPoint;
            beam.EndPoint = secondPoint;
            beam.Profile.ProfileString = "UB360*51";
            beam.Material.MaterialString = "300PLUS";
            beam.Class = "1";
            beam.Position.Depth = dep;
            bool result = false;
            result = beam.Insert();
        }
    }
}
