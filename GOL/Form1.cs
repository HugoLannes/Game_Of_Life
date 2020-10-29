using GameOfLife;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace GOL
{
    public partial class Form1 : Form
    {
        public int n; //Taille du cadre
        public int iter; //Nb d'iter
        private Game game;
        public Form1()
        {
            this.n = 100;
            InitializeComponent(n);
            game = new Game(n); //Game


            start.Click += new EventHandler(this.Start_Click);
            stop.Click += new EventHandler(this.Stop_Click);
            pause.Click += new EventHandler(this.Pause_Click);

        }


        int count = 0; //Compteur de générations
        public void MyTimer_Tick(object sender, EventArgs e)
        {
            game.grille.UpdateGrille();
            Refresh();
            this.gen.Text = "Gen : " + Convert.ToString(count);
            count++;
        }


        public void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            game.Paint(e.Graphics);
        }

        private void Start_Click(object sender, EventArgs e) // Start click
        {
            Timer MyTimer = new Timer();
            MyTimer.Interval = (50);
            MyTimer.Start();
            this.backGround.Paint += new PaintEventHandler(pictureBox2_Paint);
            MyTimer.Tick += new EventHandler(MyTimer_Tick);
        }
        private void Stop_Click(object sender, EventArgs e)
        {
            
        }
        private void Pause_Click(object sender, EventArgs e)
        {

        }






    }
}
