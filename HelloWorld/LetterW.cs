using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekla.Structures.Model;
using Tekla.Structures.Geometry3d;

namespace HelloWorld
{
    class LetterW
    {
        public void LetterWCreate()
        {
            Data data = new Data();
            data.DataVar(3000, 4000, 5000);
            var x = data.x;
            var y = data.y;
            var z = data.z;

            //first column
            VerticalColumn beamW1 = new VerticalColumn();

            var firstPointW1 = new Point(x * 4, 0, 1000);
            var secondPointW1 = new Point(x * 4, 0, z);

            beamW1.Column(firstPointW1, secondPointW1);

            //second column
            VerticalColumn beamW2 = new VerticalColumn();

            var firstPointW2 = new Point(x * 4 + 305, 0, 0);
            var secondPointW2 = new Point(x * 4 + 305, 0, 1000);

            beamW2.Column(firstPointW2, secondPointW2);

            //third column
            VerticalColumn beamW3 = new VerticalColumn();

            var firstPointW3 = new Point(x * 5, 0, 1000);
            var secondPointW3 = new Point(x * 5, 0, z);

            beamW3.Column(firstPointW3, secondPointW3);

            //fourth column
            VerticalColumn beamW4 = new VerticalColumn();

            var firstPointW4 = new Point(x * 5 - 305, 0, 0);
            var secondPointW4 = new Point(x * 5 - 305, 0, 1000);

            beamW4.Column(firstPointW4, secondPointW4);

            //first beam
            HorizontalBeam beamW5 = new HorizontalBeam();

            var firstPointW5 = new Point(x * 4 + 305, 0, 1000);
            var secondPointW5 = new Point(x * 4 + x / 2, 0, z / 2);

            beamW5.HorBeam(firstPointW5, secondPointW5, Position.DepthEnum.BEHIND);

            //second beam
            HorizontalBeam beamW6 = new HorizontalBeam();

            var firstPointW6 = new Point(x * 5 - 305, 0, 1000);
            var secondPointW6 = new Point(x * 5 - x / 2, 0, z / 2);

            beamW6.HorBeam(firstPointW6, secondPointW6, Position.DepthEnum.BEHIND);
        }
    }
}
