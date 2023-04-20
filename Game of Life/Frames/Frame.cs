using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Life.Frames
{
    public class Frame
    {
        #region params

        public bool[] states;
        int cols;
        int rows;

        #endregion

        #region Constructor

        public Frame(bool[] states, int cols, int rows)
        {
            this.states = states;
            this.cols = cols;
            this.rows = rows;
        }

        #endregion

        #region Functions

        public void blit(Frame subFrame, int positionInFraame)
        {
            int subFrameW = subFrame.cols;
            int subFrameH = subFrame.rows;
            int w = this.cols;
            int h = this.rows;

            for (int y = 0; y < subFrameH; y++)
            {
                for (int x = 0; x < subFrameW; x++)
                {
                    int statePosition = x + (y * subFrameW);
                    int newStatePosition = positionInFraame + x + (y * w);

                    if (newStatePosition < states.Count() && newStatePosition >= 0)
                    {
                        this.states[newStatePosition] = subFrame.states[statePosition];
                    }
                }
            }
        }

        public static Frame StatesToFrame(bool[] states, int cols, int rows)
        {
            return new Frame(states, cols, rows);
        }



        public static bool[] FrameToState(Frame frame)
        {
            return frame.states;
        }

        #endregion
    }
}
