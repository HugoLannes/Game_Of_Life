using GOL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace GameOfLife
{
    struct Coords
    {

        public int _x { get; set; }
        public int _y { get; set; }


        public Coords(int x, int y)
        {
            this._x = x;
            this._y = y;
        }
    }

    class Game
    {
        private int n;
        public Grid grille;
        public List<Coords> AliveCellsCoords = new List<Coords>();
        public Game(int nbCells)
        {
            this.n = nbCells;
            AliveCellsCoords.Add(new Coords(25,25));
            AliveCellsCoords.Add(new Coords(26,25));
            AliveCellsCoords.Add(new Coords(25,26));
            AliveCellsCoords.Add(new Coords(26,26));
            AliveCellsCoords.Add(new Coords(25,27));
            AliveCellsCoords.Add(new Coords(24,27));
            AliveCellsCoords.Add(new Coords(24,28));
            AliveCellsCoords.Add(new Coords(23,27));


            grille = new Grid(nbCells, AliveCellsCoords);
        }


        public void Paint(Graphics g)
        {
            SolidBrush whiteBrush = new SolidBrush(Color.FromArgb(230, 230, 230));
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grille.TabCells[i, j]._isAlive)
                    {
                        g.FillRectangle(whiteBrush, i * 5, j * 5, 5, 5);
                    }
                }
            }
        }
    }
}





/*
            Ship
            AliveCellsCoords.Add(new Coords(25,25));
            AliveCellsCoords.Add(new Coords(26,25));
            AliveCellsCoords.Add(new Coords(27,25));
            AliveCellsCoords.Add(new Coords(28,25));
            AliveCellsCoords.Add(new Coords(29,25));
            AliveCellsCoords.Add(new Coords(30,24));
            AliveCellsCoords.Add(new Coords(30,22));   
            AliveCellsCoords.Add(new Coords(28,21));
            AliveCellsCoords.Add(new Coords(26,22));
            AliveCellsCoords.Add(new Coords(25,23));
            AliveCellsCoords.Add(new Coords(25,24));

            386 gens
            AliveCellsCoords.Add(new Coords(25,25));
            AliveCellsCoords.Add(new Coords(26,25));
            AliveCellsCoords.Add(new Coords(25,26));
            AliveCellsCoords.Add(new Coords(26,26));
            AliveCellsCoords.Add(new Coords(25,27));
            AliveCellsCoords.Add(new Coords(24,27));
            AliveCellsCoords.Add(new Coords(24,28));
            AliveCellsCoords.Add(new Coords(23,27));
*/