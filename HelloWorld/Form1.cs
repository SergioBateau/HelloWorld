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

            // letter H
            //первый столбец
            var firstPointH1 = new Point(0, 8000, 0);
            var secondPointH1 = new Point(0, 8000, 5000);
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
            var firstPointH2 = new Point(3000, 8000, 0);
            var secondPointH2 = new Point(3000, 8000, 5000);
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
            var firstPointH3 = new Point(0, 8000, 2500);
            var secondPointH3 = new Point(3000, 8000, 2500);
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
            var firstPointE1 = new Point(0, 8000, 0);
            var secondPointE1 = new Point(0, 8000, 5000);
            var profileE1 = new Profile { ProfileString = "UC310*97" };
            var materialE1 = new Material { MaterialString = "300PLUS" };
            var classE1 = "2";

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
            var firstPointH2 = new Point(3000, 8000, 0);
            var secondPointH2 = new Point(3000, 8000, 5000);
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
            var firstPointH3 = new Point(0, 8000, 2500);
            var secondPointH3 = new Point(3000, 8000, 2500);
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
        }
    }
}
