using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekla.Structures.Model;
using Tekla.Structures.Geometry3d;

namespace HelloWorld
{
    class VerticalColumn
    {
        public void Column(Point firstPoint, Point secondPoint)
        {
            Beam beam = new Beam();
            beam.StartPoint = firstPoint;
            beam.EndPoint = secondPoint;
            beam.Profile.ProfileString = "UC310*97";
            beam.Material.MaterialString = "300PLUS";
            beam.Class = "2";
            beam.Position.Depth = Position.DepthEnum.MIDDLE;
            bool result = false;
            result = beam.Insert();
        }

    }
}
