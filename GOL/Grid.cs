using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;


namespace GameOfLife
{
    class Grid
    {
        public int n;
        public Cell[,] TabCells; // 2D Tab
        

        public Grid(int nbCells, List<Coords> AliveCellsCoords) // Const Grid
        {
            this.n = nbCells;
            this.TabCells = new Cell[n, n];
            for (int x = 0; x < n; x++)
            {
                for (int y = 0; y < n; y++)
                {
                    if (AliveCellsCoords.Contains(new Coords(x, y)))
                    {
                        TabCells[x, y] = new Cell(true);
                    }
                    else { TabCells[x, y] = new Cell(false); }
                }
            }
        }


        public int GetNbAliveNeighboor(int x, int y) // Check number of Alives Neighboors
        {
            int NbAliveNeighboor = 0;
            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    if ((i != 0 || j != 0) && this.TabCells[CheckNeighboor(x, i), CheckNeighboor(y, j)]._isAlive)
                    {
                        NbAliveNeighboor++;
                    }

                }
            }
            return NbAliveNeighboor;
        }


        public int CheckNeighboor(int a, int b)
        {
            int result = (a + b) % n;
            return (result < 0) ? result + n : result;
        }


        public void UpdateGrille()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((this.TabCells[i, j]._isAlive == false) && this.GetNbAliveNeighboor(i, j) == 3)
                    {
                        this.TabCells[i, j].ComeAlive();
                    }

                    else if (this.TabCells[i, j]._isAlive)
                    {
                        int neighboor = this.GetNbAliveNeighboor(i, j);
                        if ((neighboor != 2) && (neighboor != 3))
                        {
                            this.TabCells[i, j].PassAway();
                        }
                        else { this.TabCells[i, j].ComeAlive(); }
                    }
                }
            }
            foreach (Cell entry in TabCells)
            entry.Update();
            
        }

        
    }
}
