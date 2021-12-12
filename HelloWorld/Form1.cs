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
            //первый столбец
            var firstPointH1 = new Point(0, 2*y, 0);
            var secondPointH1 = new Point(0, 2*y, z);
            var profileH1 = new Profile { ProfileString = "UC310*97" };
            var materialH1 = new Material { MaterialString = "300PLUS" };
            var classH1 = "2";

            var beamH1 = new Beam
            {
                StartPoint = firstPointH1,
                EndPoint = secondPointH1,
                Profile = profileH1,
                Material = materialH1,
                Class = classH1
            };

            beamH1.Position.Depth = Position.DepthEnum.MIDDLE;

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
            var firstPointH3 = new Point(0, y, z/2);
            var secondPointH3 = new Point(x, y, z/2);
            var profileH3 = new Profile { ProfileString = "UB360*51" };
            var materialH3 = new Material { MaterialString = "300PLUS" };
            var classH3 = "1";

            var beamH3 = new Beam
            {
                StartPoint = firstPointH3,
                EndPoint = secondPointH3,
                Profile = profileH3,
                Material = materialH3,
                Class = classH3
            };

            beamH1.Insert();
            beamH2.Insert();
            beamH3.Insert();

            model.CommitChanges();

            //letter E
            var firstPointE1 = new Point(2*x, y*2, 0);

            var secondPointE1 = new Point(2*x, y*2, z/2);
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

            model.CommitChanges();
        }
    }
}
