using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tekla.Structures.Model;
using Tekla.Structures.Geometry3d;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var model = new Model();

            var x = 3000;
            var y = 4000;
            var z = 5000;

            // letter H
            //first column

            VerticalColumn beamH1 = new VerticalColumn();

            var firstPointH1 = new Point(0, 2 * y, 0);
            var secondPointH1 = new Point(0, 2 * y, z);

            beamH1.Column(firstPointH1, secondPointH1);

            //второй столбец
            var firstPointH2 = new Point(x, 2*y, 0);
            var secondPointH2 = new Point(x, 2*y, z);
            var profileH2 = new Profile { ProfileString = "UC310*97" };
            var materialH2 = new Material { MaterialString = "300PLUS" };
            var classH2 = "2";
            
            var beamH2 = new Beam
            {
                StartPoint = firstPointH2,
                EndPoint = secondPointH2,
                Profile = profileH2,
                Material = materialH2,
                Class = classH2
            };

            beamH2.Position.Depth = Position.DepthEnum.MIDDLE;

            //hor beam
            HorizontalBeam beamH3 = new HorizontalBeam();

            var firstPointH3 = new Point(0, y*2, z/2);
            var secondPointH3 = new Point(x, y*2, z/2);

            beamH3.HorBeam(firstPointH3,secondPointH3, Position.DepthEnum.BEHIND);

            //letter E
            var firstPointE1 = new Point(2*x, y*2, 0);

            var secondPointE1 = new Point(2*x, y*2, z);
            var profileE1 = new Profile { ProfileString = "UC310*97" };
            var materialE1 = new Material { MaterialString = "300PLUS" };
            var classE1 = "2";

            var beamE1 = new Beam
            {
                StartPoint = firstPointE1,
                EndPoint = secondPointE1,
                Profile = profileE1,
                Material = materialE1,
                Class = classE1
            };

            beamE1.Position.Depth = Position.DepthEnum.MIDDLE;

            //hor bottom beam 
            var firstPointE2 = new Point(x*2, y*2, 0);
            var secondPointE2 = new Point(x*3, y*2, 0);
            var profileE2 = new Profile { ProfileString = "UB360*51" };
            var materialE2 = new Material { MaterialString = "300PLUS" };
            var classE2 = "1";

            var beamE2 = new Beam
            {
                StartPoint = firstPointE2,
                EndPoint = secondPointE2,
                Profile = profileE2,
                Material = materialE2,
                Class = classE2
            };

            beamE2.Position.Depth = Position.DepthEnum.FRONT;

            //hor middle beam
            var firstPointE3 = new Point(x*2, y*2, z/2);
            var secondPointE3 = new Point(x*3, y*2, z/2);
            var profileE3 = new Profile { ProfileString = "UB360*51" };
            var materialE3 = new Material { MaterialString = "300PLUS" };
            var classE3 = "1";

            var beamE3 = new Beam
            {
                StartPoint = firstPointE3,
                EndPoint = secondPointE3,
                Profile = profileE3,
                Material = materialE3,
                Class = classE3
            };

            //hor top beam
            var firstPointE4 = new Point(x*2, y*2, z);
            var secondPointE4 = new Point(x*3, y*2, z);
            var profileE4 = new Profile { ProfileString = "UB360*51" };
            var materialE4 = new Material { MaterialString = "300PLUS" };
            var classE4 = "1";

            var beamE4 = new Beam
            {
                StartPoint = firstPointE4,
                EndPoint = secondPointE4,
                Profile = profileE4,
                Material = materialE4,
                Class = classE4
            };

            beamE4.Position.Depth = Position.DepthEnum.BEHIND;

            beamE1.Insert();
            beamE2.Insert();
            beamE3.Insert();
            beamE4.Insert();

            // letter L
            //первый столбец
            var firstPointL1 = new Point(x*4, 2 * y, 0);
            var secondPointL1 = new Point(x*4, 2 * y, z);
            var profileL1 = new Profile { ProfileString = "UC310*97" };
            var materialL1 = new Material { MaterialString = "300PLUS" };
            var classL1 = "2";

            var beamL1 = new Beam
            {
                StartPoint = firstPointL1,
                EndPoint = secondPointL1,
                Profile = profileL1,
                Material = materialL1,
                Class = classL1
            };

            beamL1.Position.Depth = Position.DepthEnum.MIDDLE;

            //hor bottom beam 
            var firstPointL2 = new Point(x * 4, y * 2, 0);
            var secondPointL2 = new Point(x * 5, y * 2, 0);
            var profileL2 = new Profile { ProfileString = "UB360*51" };
            var materialL2 = new Material { MaterialString = "300PLUS" };
            var classL2 = "1";

            var beamL2 = new Beam
            {
                StartPoint = firstPointL2,
                EndPoint = secondPointL2,
                Profile = profileL2,
                Material = materialL2,
                Class = classL2
            };

            beamL2.Position.Depth = Position.DepthEnum.FRONT;

            beamL1.Insert();
            beamL2.Insert();

            //letter W
            //первый столбец
            var firstPointW1 = new Point(x * 4 + 305, 0, 0);
            var secondPointW1 = new Point(x * 4 + 305, 0, 1000);
            var profileW1 = new Profile { ProfileString = "UC310*97" };
            var materialW1 = new Material { MaterialString = "300PLUS" };
            var classW1 = "2";

            var beamW1 = new Beam
            {
                StartPoint = firstPointW1,
                EndPoint = secondPointW1,
                Profile = profileW1,
                Material = materialW1,
                Class = classW1
            };

            beamW1.Position.Depth = Position.DepthEnum.MIDDLE;

            //второй столбец
            var firstPointW2 = new Point(x * 4, 0, 1000);
            var secondPointW2 = new Point(x * 4, 0, z);
            var profileW2 = new Profile { ProfileString = "UC310*97" };
            var materialW2 = new Material { MaterialString = "300PLUS" };
            var classW2 = "2";

            var beamW2 = new Beam
            {
                StartPoint = firstPointW2,
                EndPoint = secondPointW2,
                Profile = profileW2,
                Material = materialW2,
                Class = classW2
            };

            beamW2.Position.Depth = Position.DepthEnum.MIDDLE;

            beamW1.Insert();
            beamW2.Insert();

            //slope beam
            var firstPointW3 = new Point(x * 4 + 305, 0, 1000);
            var secondPointW3 = new Point(x * 4 + x / 2, 0, z / 2);
            var profileW3 = new Profile { ProfileString = "UB360*51" };
            var materialW3 = new Material { MaterialString = "300PLUS" };
            var classW3 = "1";

            var beamW3 = new Beam
            {
                StartPoint = firstPointW3,
                EndPoint = secondPointW3,
                Profile = profileW3,
                Material = materialW3,
                Class = classW3
            };

            beamW3.Position.Depth = Position.DepthEnum.BEHIND;

            beamW3.Insert();
            

            model.CommitChanges();
        }
    }
}
