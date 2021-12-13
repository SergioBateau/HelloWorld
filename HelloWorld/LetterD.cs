using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekla.Structures.Model;
using Tekla.Structures.Geometry3d;

namespace HelloWorld
{
    class LetterD
    {
        public void LetterDCreate()
        {
            Data data = new Data();
            data.DataVar(36000, 8000, 5000);
            var x = data.x;
            var y = data.y;
            var z = data.z;

            //first column
            VerticalColumn beamD1 = new VerticalColumn();

            var firstPointD1 = new Point(x, 0, 0);
            var secondPointD1 = new Point(x, 0, z);

            beamD1.Column(firstPointD1, secondPointD1);

            //bottom beam
            HorizontalBeam beamD2 = new HorizontalBeam();

            var firstPointD2 = new Point(x, 0, 0);
            var secondPointD2 = new Point(x + 1500, 0, 0);

            beamD2.HorBeam(firstPointD2, secondPointD2, Position.DepthEnum.FRONT);

            //top beam
            HorizontalBeam beamD3 = new HorizontalBeam();

            var firstPointD3 = new Point(x, 0, z);
            var secondPointD3 = new Point(x + 1500, 0, z);

            beamD3.HorBeam(firstPointD3, secondPointD3, Position.DepthEnum.BEHIND);

            //slope beam
            HorizontalBeam beamD4 = new HorizontalBeam();

            var firstPointD4 = new Point(x + 1500, 0, z);
            var secondPointD4 = new Point(x + x / 12, 0, z - 1000);

            beamD4.HorBeam(firstPointD4, secondPointD4, Position.DepthEnum.BEHIND);

            //slope beam
            HorizontalBeam beamD5 = new HorizontalBeam();

            var firstPointD5 = new Point(x + 1500, 0, 0);
            var secondPointD5 = new Point(x + x / 12, 0, z - 4000);

            beamD5.HorBeam(firstPointD5, secondPointD5, Position.DepthEnum.BEHIND);

            //second column
            VerticalColumn beamD6 = new VerticalColumn();

            var firstPointD6 = new Point(x + x / 12, 0, z - 4000);
            var secondPointD6 = new Point(x + x / 12, 0, z - 1000);

            beamD6.Column(firstPointD6, secondPointD6);
        }
    }
}
