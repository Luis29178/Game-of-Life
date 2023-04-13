using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Life.GameLogic
{
    public class GameEnviorment
    {
        #region params
        public List<Cell> cells;
        Dictionary<int, int[]> cellNeighbours;
        #endregion

        #region Props
        public bool[] CellStates
        {
            get
            {
                bool[] states = new bool[NbCells];

                for (int i = 0; i < NbCells; i++)
                {
                    states[i] = cells[i].alive;
                }
                return states;
            }
        }

        public int NbAliveCells
        {
            get
            {
                int count = 0;
                foreach (bool state in CellStates)
                {
                    if (state)
                    {
                        count++;
                    }
                }
                return count;
            }
        }
        public int NbDeadCells
        {
            get
            {
                return NbCells - NbAliveCells;
            }
        }
        public int NbCells
        {
            get { return cells.Count; }
        }
        #endregion

        #region Constructor

        public GameEnviorment(int cols, int rows, bool[] cellStates = null)
        {
            if (cellStates != null)
            {
                SetCells(cellStates);
            }
            SetCellNeighbours(cols, rows);
        }
        #endregion

        #region Functions

        public void SetCells(bool[] cellStates)
        {
            cells = new List<Cell>();
            foreach (bool state in cellStates)
            {

                cells.Add(new Cell(state));

            }
        }

        private void SetCellNeighbours(int cols, int rows)
        {
            cellNeighbours = new Dictionary<int, int[]>();
            int nbCells = cols * rows;

            for (int i = 0; i < nbCells; i++)
            {
                List<int> neighbourList = new List<int>();
                int col = (i % cols);
                double tempRow = (i / cols);
                int row = (int)Math.Floor(tempRow);

                bool Loaded = false;

                if (col == 0)
                {
                   
                    if (row == 0)
                    {
                        //Left
                        neighbourList.Add(i + (cols - 1));
                        //Top Left
                        neighbourList.Add(nbCells - 1);
                        //Buttom Left
                        neighbourList.Add((i + cols) + (cols - 1));
                        //Top
                        neighbourList.Add(i + (cols * (rows - 1)));
                        //Buttom
                        neighbourList.Add(i + cols);
                        //Top Right
                        neighbourList.Add((i + 1) + (cols * (rows - 1)));
                        //Rigth
                        neighbourList.Add(i + 1);
                        //Buttom Right
                        neighbourList.Add(i + (cols + 1));
                        Loaded = true;
                    }
                    if (row == (rows - 1))
                    {
                        //Top Left
                        neighbourList.Add(i - 1);
                        //Top
                        neighbourList.Add(i - cols);
                        //Top Right
                        neighbourList.Add((i + 1) -cols);
                        //Left
                        neighbourList.Add(nbCells -1);
                        //Rigth
                        neighbourList.Add(i + 1);
                        //Buttom Left
                        neighbourList.Add(cols - 1);
                        //Buttom
                        neighbourList.Add(0);
                        //Buttom Right
                        neighbourList.Add(1);

                        Loaded = true;
                    }
                    if (!Loaded)
                    {
                        //Top Left
                        neighbourList.Add(i - 1);
                        //Top
                        neighbourList.Add(i - cols);
                        //Top Right
                        neighbourList.Add(i - (cols - 1));
                        //Left
                        neighbourList.Add(i + (cols - 1));
                        //Rigth
                        neighbourList.Add(i + 1);
                        //Buttom Left
                        neighbourList.Add((i + cols) + (cols - 1));
                        //Buttom
                        neighbourList.Add(i + cols);
                        //Buttom Right
                        neighbourList.Add(i + (cols + 1));

                        Loaded = true;

                    }
                }

                if (col == (cols-1))
                {
                    
                    if (row == 0)
                    {
                        //Top Left
                        neighbourList.Add((i - 1) + (cols * (rows - 1)));
                        //Top
                        neighbourList.Add(nbCells - 1);
                        //Top Right
                        neighbourList.Add(cols * (rows - 1));
                        //Left
                        neighbourList.Add(i - 1);
                        //Rigth
                        neighbourList.Add(0);
                        //Buttom Left
                        neighbourList.Add((i - 1) + cols);
                        //Buttom
                        neighbourList.Add(i + cols);
                        //Buttom Right
                        neighbourList.Add(i + 1);
                        Loaded = true;
                    }
                    if (row == (rows - 1))
                    {
                        //Top Left
                        neighbourList.Add(((i -1)-cols));
                        //Top
                        neighbourList.Add(i -cols);
                        //Top Right
                        neighbourList.Add(((i - cols) - (cols -1)));
                        //Left
                        neighbourList.Add(i -1);
                        //Rigth
                        neighbourList.Add((i -(cols -1)));
                        //Buttom Left
                        neighbourList.Add(cols -2);
                        //Buttom
                        neighbourList.Add(cols -1);
                        //Buttom Right
                        neighbourList.Add(0);
                        Loaded = true;
                    }
                    if (!Loaded)
                    {
                        //Top Left
                        neighbourList.Add((i-1) -cols);
                        //Top
                        neighbourList.Add(i - cols);
                        //Top Right
                        neighbourList.Add((i - cols) - (cols - 1));
                        //Left
                        neighbourList.Add(i-1);
                        //Rigth
                        neighbourList.Add(i - (cols -1));
                        //Buttom Left
                        neighbourList.Add((i - 1) + cols);
                        //Buttom
                        neighbourList.Add(i + cols);
                        //Buttom Right
                        neighbourList.Add(i +1);

                        Loaded = true;
                    }
                }

                if (row == 0 && !Loaded)
                {

                    //Top Left
                    neighbourList.Add((i - 1)+(cols * (rows-1)));
                    //Top
                    neighbourList.Add(i + (cols * (rows - 1)));
                    //Top Right
                    neighbourList.Add((i + 1) + (cols * (rows - 1)));
                    //Left
                    neighbourList.Add(i - 1);
                    //Rigth
                    neighbourList.Add(i + 1);
                    //Buttom Left
                    neighbourList.Add((i - 1) + cols);
                    //Buttom
                    neighbourList.Add(i + cols);
                    //Buttom Right
                    neighbourList.Add((i + 1) + cols);

                    Loaded = true;


                }
                if ((row == (rows -1)) && !Loaded)
                {
                    //Top Left
                    neighbourList.Add((i -1)-cols);
                    //Top
                    neighbourList.Add(i - cols);
                    //Top Right
                    neighbourList.Add((i +1) - cols);
                    //Left
                    neighbourList.Add(i-1);
                    //Rigth
                    neighbourList.Add(i+1);
                    //Buttom Left
                    neighbourList.Add((i -1) - (cols*(rows-1)));
                    //Buttom
                    neighbourList.Add(i - (cols * (rows - 1)));
                    //Buttom Right
                    neighbourList.Add((i + 1) - (cols * (rows - 1)));

                    Loaded = true;
                }

                if (!(row == 0 || row == (rows - 1)) && !(col == 0 || col == (cols - 1)))
                {
                    //Top Left
                    neighbourList.Add((i - 1) - cols);
                    //Top
                    neighbourList.Add(i - cols);
                    //Top Right
                    neighbourList.Add((i + 1) - cols);
                    //Left
                    neighbourList.Add(i - 1);
                    //Rigth
                    neighbourList.Add(i + 1);
                    //Buttom Left
                    neighbourList.Add((i - 1) + cols);
                    //Buttom
                    neighbourList.Add(i + cols);
                    //Buttom Right
                    neighbourList.Add((i +1) + cols);

                    Loaded = true;
                }


                cellNeighbours.Add(i, neighbourList.ToArray());
            }
        }

        private void UpdateCell(int position, int nbAliveNeightbours)
        {
            cells[position].Update(nbAliveNeightbours);
        }
        private void UpdateCells(bool[] CellStates)
        {
            foreach (KeyValuePair<int, int[]> CellsAndNeighbour in cellNeighbours)
            {
                int nbAliveNeighBours = 0;

                foreach (int neighbour in CellsAndNeighbour.Value)
                {
                    if (CellStates[neighbour])
                    {
                        nbAliveNeighBours++;
                    }
                }
                UpdateCell(CellsAndNeighbour.Key, nbAliveNeighBours);

            }

        }

        public void Update(bool[] CellStates)
        {
            UpdateCells(CellStates);
        }
        #endregion
    }
}
