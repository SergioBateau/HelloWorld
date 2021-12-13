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
            LetterH letterH = new LetterH();
            letterH.LetterHCreate();

            //letter E
            LetterE letterE = new LetterE();
            letterE.LetterECreate();


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
