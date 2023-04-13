using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Life.GameLogic
{
    public class Cell
    {
        #region Params

        public bool alive;

        #endregion

        #region Constructor

        public Cell(bool _alive)
        {
            this.alive = _alive;
        }

        #endregion

        #region Functions
        private void SetState( int numAliveNeighbours)
        {
            if (alive)
            {
                if(numAliveNeighbours < 2 || numAliveNeighbours > 3)
                {
                    alive = false;
                }

            }
            else
            {
                if (numAliveNeighbours == 3)
                {
                    alive = true;
                }
            }
        }

        public void Update(int numAliveNeighbours)
        {
            SetState(numAliveNeighbours);
        }
        #endregion
    }
}
