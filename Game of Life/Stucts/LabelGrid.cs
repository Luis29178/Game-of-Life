using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using Game_of_Life.Frames;
using Game_of_Life.GameLogic;

namespace Game_of_Life.Stucts
{
    public class LabelGrid
    {
        // replace class with using GameOfLife3.Frames;

        #region Params



        public int cols;
        public int rows;
        public int InternalSeperation;
        int externalSeperationX;
        int externalSeperationY;
        public int LabelWidth;
        public int LabelHeight;
        int locationX;
        int locationY;

        public List<Label> labels;
        public Panel panel;


        #endregion

        #region props


        int Width { get {  return panel.Width; } }
        int Height { get { return panel.Height; } }
        int NbLables { get { return labels.Count; } }

        public bool[] State
        {
            get
            {
                bool[] states = new bool[NbLables];
                for (int i = 0; i < NbLables; i++)
                {
                    states[i] = (labels[i].BackColor == Globals.Alive) ? true : false; 
                }
                return states;
            }
        }


        #endregion

        #region constructor
        public LabelGrid(Panel panel, int cols,int rows, int lableWidth,int lableHight, int internalSeperation)
        {
            this.panel = panel;
            this.LabelWidth = lableWidth;
            this.LabelHeight = lableHight;
            this.InternalSeperation = internalSeperation;
            this.cols = cols;
            this.rows = rows;
            this.locationX = panel.Location.X;
            this.locationY = panel.Location.Y;

            externalSeperationX = GetExternalSeperation()[0];
            externalSeperationY = GetExternalSeperation()[1];

            GenerateLabels();

        }


        #endregion

        #region Functions
        private int getSumInternalSep(int Condition)
        {
            int sum = 0;

            switch (Condition)
            {   
                case 0:
                    sum = (cols) * InternalSeperation;
                    break;
                case 1:
                    sum = (rows + 2) * InternalSeperation;
                    break;
            }
            return sum;



        }

        private int[] GetExternalSeperation()
        {
            int usedWidth = (Width - getSumInternalSep(0));
            int usedHeight = (Height - getSumInternalSep(1));

            LabelWidth = ((usedWidth) / cols);
            LabelHeight = ((usedHeight) / rows);

            int externalSeperationX = (usedWidth % cols) / 2;
            int externalSeperationY = ((usedHeight % rows) /2 );

            return new int[2] { 
                externalSeperationX, 
                externalSeperationY 
            };


        }

        public bool[] GetStatesfromLabels()
        {
            bool[] states = new bool[NbLables];

            for (int i = 0; i < NbLables; i++)
            {
                states[i] = (labels[i].BackColor == Globals.Alive);
            }

            return states;
        }

        public void SetLabelsFromFrame(Frame frame)
        {
            for (int i = 0;i < frame.states.Count();i++)
            {

                labels[i].BackColor = (frame.states[i]) ? Globals.Alive : Globals.Dead;
                
            }
        }

        public void SetLabelsFromState(bool[] states)
        {
            for (int i = 0; i < states.Count(); i++)
            {
                labels[i].BackColor = (states[i]) ? Globals.Alive :Globals.Dead;
            }
        }




        private void GenerateLabels()
        {
            labels = new List<Label>();

            for (int i = 0;i < rows;i++)
            {
                for (int j = 0;j < cols;j++)
                {
                    Label label = new Label();
                    int xLocation = (externalSeperationX + (j * LabelWidth)+(j * InternalSeperation));
                    int yLocation =  (externalSeperationY + (i * LabelHeight) + (i * InternalSeperation));

                    label.Location = new Point(xLocation, yLocation);
                    label.Size = new Size(LabelWidth, LabelHeight);
                    label.BackColor = Globals.Dead;
                    panel.Controls.Add(label);
                    labels.Add(label);

                }
            }
            
        }

        private void EraseLabels()
        {
            foreach (Label label in labels)
            {
                panel.Controls.Remove(label);
            }
        }
        public void Clear()
        {
            foreach(Label label in labels)
            {
                label.BackColor = Globals.Dead;
            }
        }

        public void Reverse()
        {
            foreach(Label label in labels)
            {
                label.BackColor = (label.BackColor == Globals.Dead) ? Globals.Alive : Globals.Dead;
            }
        }
        public void ChangeDimentions(int cols, int rows)
        {
            EraseLabels();
            this.cols = cols;
            this.rows = rows;

            externalSeperationX = GetExternalSeperation()[0];
            externalSeperationY = GetExternalSeperation()[1]; 
            
            GenerateLabels();

        }

        #endregion
    }
}
