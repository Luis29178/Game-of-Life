using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game_of_Life.Stucts;
using Game_of_Life.Editor;
using Game_of_Life.Frames;
using Game_of_Life.GameLogic;

namespace Game_of_Life.Stucts
{
    public class GameManager
    {
        #region params

        public GameEnviorment gameEnvironment;
        public FrameManager frameManager;
        public LabelGrid gameGrid;

      

        #endregion

        #region Constroctor  
        public GameManager(LabelGrid labelGrid)
        {
            this.gameGrid = labelGrid;
            frameManager = new FrameManager(gameGrid.cols, gameGrid.rows);
            gameEnvironment = new GameEnviorment(gameGrid.cols, gameGrid.rows);
        }

        #endregion

        #region Functions
         // Change to Have 2 sepret functions to set for 2 buttons
        public void RewindButton()
        {
            frameManager.rewind = !frameManager.rewind;
        }

        public void StartNewFrameRoot()
        {
            frameManager.CutAtIndex(frameManager.CurrentFrameIndex);
            frameManager.frames[frameManager.CurrentFrameIndex] = Frame.StatesToFrame(gameGrid.GetStatesfromLabels(), gameGrid.cols , gameGrid.rows);
            
        }

        public void Update()
        {
            bool[] gridCellStates = gameGrid.GetStatesfromLabels();

            if (frameManager.rewind)
            {

            }
            else
            {
                if(frameManager.NbFrames == 0)
                {
                    frameManager.AddFrame(Frame.StatesToFrame(gridCellStates,gameGrid.cols, gameGrid.rows));
                    frameManager.CurrentFrameIndex = 0;
                }
                else
                {
                    if(frameManager.NeedsNewFrame)
                    {
                        gameEnvironment.SetCells(gridCellStates);
                        gameEnvironment.Update(gridCellStates);

                        frameManager.AddFrame(Frame.StatesToFrame(gameEnvironment.CellStates, gameGrid.cols, gameGrid.rows));
                    }
                    else if(frameManager.CurrentFrameIndex < frameManager.NbFrames-1)
                    {
                        StartNewFrameRoot();
                    }
                }
            }

        }

        public void Draw()
        {
            if(frameManager.CurrentFrame != null)
            {
                gameGrid.SetLabelsFromFrame(frameManager.CurrentFrame);
            }
        }

        #endregion

    }
}
