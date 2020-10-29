using System.Drawing;
using System.Windows.Forms;

namespace GOL
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        public void InitializeComponent(int n)
        {
            this.backGround = new System.Windows.Forms.PictureBox();
            this.gen = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();


            ((System.ComponentModel.ISupportInitialize)(this.backGround)).BeginInit();
            this.SuspendLayout();
            //
            // Start Button
            //
            this.start.Location = new System.Drawing.Point(10, 10);
            this.start.Name = "Start";
            this.start.Size = new System.Drawing.Size(75, 25);
            this.start.TabIndex = 1;
            this.start.Font = new Font("Roboto", 10);
            this.start.UseCompatibleTextRendering = true;
            this.start.Text = "Start";
            this.start.BackColor = Color.FromArgb(38, 38, 38);
            this.start.ForeColor = Color.FromArgb(179, 179, 179);
            this.start.FlatStyle = FlatStyle.Flat;
            //
            // Stop Button
            //
            this.stop.Location = new System.Drawing.Point(100, 10);
            this.stop.Name = "Stop";
            this.stop.Size = new System.Drawing.Size(75, 25);
            this.stop.TabIndex = 1;
            this.stop.Font = new Font("Roboto", 10);
            this.stop.UseCompatibleTextRendering = true;
            this.stop.Text = "Stop";
            this.stop.BackColor = Color.FromArgb(38, 38, 38);
            this.stop.ForeColor = Color.FromArgb(179, 179, 179);
            this.stop.FlatStyle = FlatStyle.Flat;
            //
            // Pause Button
            //
            this.pause.Location = new System.Drawing.Point(190, 10);
            this.pause.Name = "Pause";
            this.pause.Size = new System.Drawing.Size(75, 25);
            this.pause.TabIndex = 1;
            this.pause.Font = new Font("Roboto", 10);
            this.pause.UseCompatibleTextRendering = true;
            this.pause.Text = "Pause";
            this.pause.BackColor = Color.FromArgb(38, 38, 38);
            this.pause.ForeColor = Color.FromArgb(179, 179, 179);
            this.pause.FlatStyle = FlatStyle.Flat;
            // 
            //  Gen
            // 
            this.gen.Location = new Point(10, 460);
            this.gen.AutoSize = true;
            this.gen.Font = new Font("Calibri", 18);
            this.gen.ForeColor = Color.FromArgb(179, 179, 179);
            this.gen.BackColor = Color.FromArgb(38, 38, 38);

            // 
            //  BG
            // 
            this.backGround.Location = new System.Drawing.Point(0, 0);
            this.backGround.Name = "pictureBox2";
            this.backGround.Size = new System.Drawing.Size(5 * n, 5 * n);
            this.backGround.TabIndex = 0;
            this.backGround.TabStop = false;
            // 
            // Jeu de la vie
            // 
            this.backGround.BackColor = Color.FromArgb(38, 38, 38);
            this.ClientSize = new System.Drawing.Size(5 * n, 5 * n);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Controls.Add(this.backGround);
            this.Controls.Add(this.gen);
            this.backGround.SizeMode = PictureBoxSizeMode.CenterImage;
            this.Name = "Form1";
            this.Text = "Jeu de la vie";
            ((System.ComponentModel.ISupportInitialize)(this.backGround)).EndInit();
            this.ResumeLayout(false);
            this.Controls.Add(this.backGround); // Controls
            this.Controls.Add(this.gen);
            this.Controls.Add(this.start);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.pause);
            gen.BringToFront();
            start.BringToFront();
            stop.BringToFront();
            pause.BringToFront();
        }

        #endregion

        
        private System.Windows.Forms.PictureBox backGround;
        private System.Windows.Forms.Label gen;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button pause;

    }
}

