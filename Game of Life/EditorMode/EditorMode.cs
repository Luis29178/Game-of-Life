using Game_of_Life.Frames;
using Game_of_Life.Stucts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Life.Editor
{
    public class EditorMode
    {

        #region params

        public enum editorMode
        {
            paint,
            select,
            copy,
            paste
        }
        public enum brushMode
        {
            Life,
            Death,
            Invert
        }
        public editorMode mode;
        public brushMode brush;

        public int brushThickness;

        public LabelGrid mainLabelGrid;
        public LabelGrid editorLabelGrid;
        public Frame copiedFrame;

        public int[] selectedTiles;


        #endregion

        #region Constructor
        public EditorMode(LabelGrid MainLabelGrid, LabelGrid editorLabelGrid)
        {
            this.mainLabelGrid = MainLabelGrid;
            this.editorLabelGrid = editorLabelGrid;
            mode = editorMode.paint;
            brush = brushMode.Invert;

            AssignLabelEvent(mainLabelGrid);
            AssignLabelEvent(editorLabelGrid);

            brushThickness = 1;
        }
        #endregion

        #region Functions
        public void AssignLabelEvent(LabelGrid labelGrid)
        {
            foreach (Control c in labelGrid.panel.Controls)
            {
                Label i = c as Label;
                i.Click += Label_Click;
            }
        }
        private void Paint(LabelGrid grid, int pos)
        {
            int cols = grid.cols;

            List<int> LabelsToPaint = new List<int>();

            for(int i = 1; i <= brushThickness; i++)
            { 

                int nb = (brushThickness*2 -1) - (2* (i-1));

                for(int j = 0; j < nb; j++)
                {
                    LabelsToPaint.Add(pos - cols * (i - 1) - ((brushThickness - 1) - (i - 1)) + j);
                    if(i > 1)
                    {
                        LabelsToPaint.Add(pos+cols*(i-1)-((brushThickness-1) - (i-1))+j);
                    }
                }
            
            }

            foreach (int t in LabelsToPaint)
            {
                if(t <= (grid.labels.Count - 1))
                {
                    switch (brush)
                    {
                        case brushMode.Invert:
                            grid.labels[t].BackColor = (grid.labels[t].BackColor == Globals.Alive) ? Globals.Dead : Globals.Alive;
                            break;
                        case brushMode.Life:
                            grid.labels[t].BackColor = Globals.Alive;
                            break;
                        case brushMode.Death:
                            grid.labels[t].BackColor = Globals.Dead;
                            break;
                        default:
                            break;

                    }
                    
                }
            }
        }

        private void Paste(LabelGrid grid, int pos)
        {


            Frame frame = Frame.StatesToFrame(grid.GetStatesfromLabels(), grid.cols, grid.rows);

            frame.blit(copiedFrame, pos);
            grid.SetLabelsFromFrame( frame );
        }
        private void Set_Grid(LabelGrid grid)
        {

        }

        private void Label_Click(object sender, EventArgs e)
        {
            Label i = sender as Label;
            bool main = mainLabelGrid.labels.Contains(i);
            int pos;
            LabelGrid grid;
            if (main)
            {
                pos = mainLabelGrid.labels.IndexOf(i);
                grid = mainLabelGrid;
            }
            else
            {
                pos = editorLabelGrid.labels.IndexOf(i);
                grid = editorLabelGrid;
            }

            switch(mode)
            {
                case editorMode.paint:
                    Paint(grid, pos); 
                    break;
                case editorMode.copy:
                    break;
                case editorMode.select: 
                    break;
                case editorMode.paste: 
                    Paste(grid, pos);
                    break;
            }
        }
        #endregion
    }
}
