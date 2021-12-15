using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekla.Structures.Model;
using Tekla.Structures.Geometry3d;

namespace HelloWorld
{
    class LetterL
    {
        public void LetterFirstLCreate()
        {
            Data data = new Data();
            data.DataVar(3000, 4000, 5000);
            var x = data.x;
            var y = data.y;
            var z = data.z;

            // first column
            VerticalColumn beamL1 = new VerticalColumn();

            var firstPointL1 = new Point(x * 4, y * 2, 0);
            var secondPointL1 = new Point(x * 4, y * 2, z);

            beamL1.Column(firstPointL1, secondPointL1);

            //bottom beam
            HorizontalBeam beamL2 = new HorizontalBeam();

            var firstPointL2 = new Point(x * 4, y * 2, 0);
            var secondPointL2 = new Point(x * 5, y * 2, 0);

            beamL2.HorBeam(firstPointL2, secondPointL2, Position.DepthEnum.FRONT);
        }

        public void LetterSecondLCreate()
        {
            Data data = new Data();
            data.DataVar(3000, 4000, 5000);
            var x = data.x;
            var y = data.y;
            var z = data.z;

            // first column
            VerticalColumn beamL1 = new VerticalColumn();

            var firstPointL1 = new Point(x * 6, y * 2, 0);
            var secondPointL1 = new Point(x * 6, y * 2, z);

            beamL1.Column(firstPointL1, secondPointL1);

            //bottom beam
            HorizontalBeam beamL2 = new HorizontalBeam();

            var firstPointL2 = new Point(x * 6, y * 2, 0);
            var secondPointL2 = new Point(x * 7, y * 2, 0);

            beamL2.HorBeam(firstPointL2, secondPointL2, Position.DepthEnum.FRONT);
        }

        public void LetterThirdLCreate()
        {
            Data data = new Data();
            data.DataVar(3000, 4000, 5000);
            var x = data.x;
            var y = data.y;
            var z = data.z;

            // first column
            VerticalColumn beamL1 = new VerticalColumn();

            var firstPointL1 = new Point(x * 10, 0, 0);
            var secondPointL1 = new Point(x * 10, 0, z);

            beamL1.Column(firstPointL1, secondPointL1);

            //bottom beam
            HorizontalBeam beamL2 = new HorizontalBeam();

            var firstPointL2 = new Point(x * 10, 0, 0);
            var secondPointL2 = new Point(x * 11, 0, 0);

            beamL2.HorBeam(firstPointL2, secondPointL2, Position.DepthEnum.FRONT);
        }
    }
}
