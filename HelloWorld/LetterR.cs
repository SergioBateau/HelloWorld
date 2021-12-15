using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekla.Structures.Model;
using Tekla.Structures.Geometry3d;

namespace HelloWorld
{
    class LetterR
    {
        public void LetterRCreate()
        {
            Data data = new Data();
            data.DataVar(3000, 4000, 5000);
            var x = data.x;
            var y = data.y;
            var z = data.z;

            //first column
            VerticalColumn beamR1 = new VerticalColumn();

            var firstPointR1 = new Point(x * 8, 0, 0);
            var secondPointR1 = new Point(x * 8, 0, z);

            beamR1.Column(firstPointR1, secondPointR1);

            //top beam
            HorizontalBeam beamR2 = new HorizontalBeam();

            var firstPointR2 = new Point(x * 8, 0, z);
            var secondPointR2 = new Point(x * 9, 0, z);

            beamR2.HorBeam(firstPointR2, secondPointR2, Position.DepthEnum.BEHIND);

            //middle beam
            HorizontalBeam beamR3 = new HorizontalBeam();

            var firstPointR3 = new Point(x * 8, 0, z / 2);
            var secondPointR3 = new Point(x * 9, 0, z / 2);

            beamR3.HorBeam(firstPointR3, secondPointR3, Position.DepthEnum.BEHIND);

            //second column
            VerticalColumn beamR4 = new VerticalColumn();

            var firstPointR4 = new Point(x * 9, 0, 2000);
            var secondPointR4 = new Point(x * 9, 0, z);

            beamR4.Column(firstPointR4, secondPointR4);

            //slope beam
            HorizontalBeam beamR5 = new HorizontalBeam();

            var firstPointR5 = new Point(x * 8, 0, z / 2);
            var secondPointR5 = new Point(x * 9, 0, 0);

            beamR5.HorBeam(firstPointR5, secondPointR5, Position.DepthEnum.FRONT);
        }

    }
}
