using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekla.Structures.Model;
using Tekla.Structures.Geometry3d;

namespace HelloWorld
{
    class LetterO
    {
        public void LetterFirstOCreate()
        {
            Data data = new Data();
            data.DataVar(3000, 4000, 5000);
            var x = data.x;
            var y = data.y;
            var z = data.z;

            // first column
            VerticalColumn beamO1 = new VerticalColumn();

            var firstPointO1 = new Point(x * 8, y * 2, 0);
            var secondPointO1 = new Point(x * 8, y * 2, z);

            beamO1.Column(firstPointO1, secondPointO1);

            //bottom beam
            HorizontalBeam beamO2 = new HorizontalBeam();

            var firstPointO2 = new Point(x * 8, y * 2, 0);
            var secondPointO2 = new Point(x * 9, y * 2, 0);

            beamO2.HorBeam(firstPointO2, secondPointO2, Position.DepthEnum.FRONT);

            // second column
            VerticalColumn beamO3 = new VerticalColumn();

            var firstPointO3 = new Point(x * 9, y * 2, 0);
            var secondPointO3 = new Point(x * 9, y * 2, z);

            beamO3.Column(firstPointO3, secondPointO3);

            // top beam
            HorizontalBeam beamO4 = new HorizontalBeam();

            var firstPointO4 = new Point(x * 8, y * 2, z);
            var secondPointO4 = new Point(x * 9, y * 2, z);

            beamO4.HorBeam(firstPointO4, secondPointO4, Position.DepthEnum.BEHIND);
        }

        public void LetterSecondOCreate()
        {
            Data data = new Data();
            data.DataVar(3000, 4000, 5000);
            var x = data.x;
            var y = data.y;
            var z = data.z;

            // first column
            VerticalColumn beamO1 = new VerticalColumn();

            var firstPointO1 = new Point(x * 6, 0, 0);
            var secondPointO1 = new Point(x * 6, 0, z);

            beamO1.Column(firstPointO1, secondPointO1);

            //bottom beam
            HorizontalBeam beamO2 = new HorizontalBeam();

            var firstPointO2 = new Point(x * 6, 0, 0);
            var secondPointO2 = new Point(x * 7, 0, 0);

            beamO2.HorBeam(firstPointO2, secondPointO2, Position.DepthEnum.FRONT);

            // second column
            VerticalColumn beamO3 = new VerticalColumn();

            var firstPointO3 = new Point(x * 7, 0, 0);
            var secondPointO3 = new Point(x * 7, 0, z);

            beamO3.Column(firstPointO3, secondPointO3);

            // top beam
            HorizontalBeam beamO4 = new HorizontalBeam();

            var firstPointO4 = new Point(x * 6, 0, z);
            var secondPointO4 = new Point(x * 7, 0, z);

            beamO4.HorBeam(firstPointO4, secondPointO4, Position.DepthEnum.BEHIND);
        }
    }
}
