using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekla.Structures.Model;
using Tekla.Structures.Geometry3d;

namespace HelloWorld
{
    class LetterH
    {
        public void LetterHCreate()
        {
            int x = 3000;
            int y = 4000;
            int z = 5000;

            //first column
            VerticalColumn beamH1 = new VerticalColumn();

            var firstPointH1 = new Point(0, 2 * y, 0);
            var secondPointH1 = new Point(0, 2 * y, z);

            beamH1.Column(firstPointH1, secondPointH1);

            //second column
            VerticalColumn beamH2 = new VerticalColumn();

            var firstPointH2 = new Point(x, 2 * y, 0);
            var secondPointH2 = new Point(x, 2 * y, z);

            beamH2.Column(firstPointH2, secondPointH2);

            //hor beam
            HorizontalBeam beamH3 = new HorizontalBeam();

            var firstPointH3 = new Point(0, y * 2, z / 2);
            var secondPointH3 = new Point(x, y * 2, z / 2);

            beamH3.HorBeam(firstPointH3, secondPointH3, Position.DepthEnum.BEHIND);
        }



    }
}
