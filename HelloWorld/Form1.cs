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

            //letter D
            LetterD letterD = new LetterD();
            letterD.LetterDCreate();

            // letter L
            LetterL letterL1 = new LetterL();
            letterL1.LetterFirstLCreate();

            LetterL letterL2 = new LetterL();
            letterL2.LetterSecondLCreate();

            LetterL letterL3 = new LetterL();
            letterL3.LetterThirdLCreate();

            // letter O
            LetterO letterO1 = new LetterO();
            letterO1.LetterFirstOCreate();

            LetterO letterO2 = new LetterO();
            letterO2.LetterSecondOCreate();

            //letter W
            LetterW letterW = new LetterW();
            letterW.LetterWCreate();

            //letter R
            LetterR letterR = new LetterR();
            letterR.LetterRCreate();

            //exclamation point
            ExclamationPoint exclamationPoint = new ExclamationPoint();
            exclamationPoint.ExclamationPointCreate();

            model.CommitChanges();
        }
    }
}
