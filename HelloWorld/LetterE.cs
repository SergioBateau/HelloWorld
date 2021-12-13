using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekla.Structures.Model;
using Tekla.Structures.Geometry3d;

namespace HelloWorld
{
    class LetterE
    {
        public void LetterECreate()
        {
            Data data = new Data();
            data.DataVar(6000, 8000, 5000);
            var x = data.x;
            var y = data.y;
            var z = data.z;

            //first column
            VerticalColumn beamE1 = new VerticalColumn();

            var firstPointE1 = new Point(x, y, 0);
            var secondPointE1 = new Point(x, y, z);

            beamE1.Column(firstPointE1, secondPointE1);

            //bottom beam
            HorizontalBeam beamE2 = new HorizontalBeam();

            var firstPointE2 = new Point(x, y, 0);
            var secondPointE2 = new Point(x + x/2, y, 0);

            beamE2.HorBeam(firstPointE2, secondPointE2, Position.DepthEnum.FRONT);

            //middle beam
            HorizontalBeam beamE3 = new HorizontalBeam();

            var firstPointE3 = new Point(x, y, z / 2);
            var secondPointE3 = new Point(x + x / 2, y, z / 2);

            beamE2.HorBeam(firstPointE3, secondPointE3, Position.DepthEnum.BEHIND);

            //top beam
            HorizontalBeam beamE4 = new HorizontalBeam();

            var firstPointE4 = new Point(x, y, z);
            var secondPointE4 = new Point(x + x / 2, y, z);

            beamE2.HorBeam(firstPointE4, secondPointE4, Position.DepthEnum.BEHIND);
        }
    }
}
