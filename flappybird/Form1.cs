using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappybird
{
    public partial class bird : Form
    {
        Random random = new Random();
        int boruHızı = 5;
        int yerçekimi = 12;
        int score = 0;
        List<PictureBox[]> boruSetleri = new List<PictureBox[]>();
        public bird()
        {
            InitializeComponent();
        }

        private void bird_Load(object sender, EventArgs e)
        {
            boruSetleri.Add(new PictureBox[] { boru1ust, boru1alt });
            boruSetleri.Add(new PictureBox[] { boru2ust, boru2alt });
            boruSetleri.Add(new PictureBox[] { boru3ust, boru3alt });
            int borularArasiYatayMesafe = 350;
            int baslangicX = this.ClientSize.Width + 100;

            foreach (var set in boruSetleri)
            {
                PictureBox boruUst = set[0];
                PictureBox boruAlt = set[1];
                boruAlt.Left = baslangicX;
                boruUst.Left = baslangicX;
                baslangicX += borularArasiYatayMesafe;
                int bosluk = 150;
                int yeniAltYukseklik = random.Next(100, 300);
                boruAlt.Height = yeniAltYukseklik;
                boruAlt.Top = zemin.Top - boruAlt.Height;
                boruUst.Top = 0;
                boruUst.Height = zemin.Top - bosluk - boruAlt.Height;
                boruAlt.Tag = "no";
            }
            zemin.BringToFront();

        }

        private void gametimerevent(object sender, EventArgs e)
        {
            kuş.Top += yerçekimi;
            foreach (var set in boruSetleri)
            {
                PictureBox boruUst = set[0];
                PictureBox boruAlt = set[1];
                boruAlt.Left -= boruHızı;
                boruUst.Left -= boruHızı;
                if (boruAlt.Right<kuş.Left && (boruAlt.Tag==null || boruAlt.Tag.ToString() == "no"))
                {
                    score++;
                    scoreText.Text = "Score: " + score;
                    boruAlt.Tag = "yes";
                }
                if (boruAlt.Right < 0)
                {
                    int maxLeft = 0;
                    foreach(var s in boruSetleri)
                    {
                        if (s[0].Left > maxLeft)
                        {
                            maxLeft = s[0].Left;
                        }
                    }
                    boruAlt.Left = maxLeft + 300;
                    boruUst.Left = maxLeft + 300;

                    int bosluk = 150;
                    int yeniAltYukseklik = random.Next(100, 300);
                    boruAlt.Height = yeniAltYukseklik;
                    boruAlt.Top= zemin.Top - boruAlt.Height;
                    boruUst.Top = 0;
                    boruUst.Height = zemin.Top - bosluk - boruAlt.Height;
                    boruAlt.Tag = "no";
                }
                if (kuş.Bounds.IntersectsWith(boruAlt.Bounds) || kuş.Bounds.IntersectsWith(boruUst.Bounds))
                {
                    endgame();
                }
            }
            if (kuş.Bounds.IntersectsWith(zemin.Bounds) || kuş.Top < 0)
            {
                endgame();
            }
            if (score > 5 && boruHızı < 18)
            {
                boruHızı = 7; 
            }
            if (score > 10 && boruHızı < 18)
            {
                boruHızı = 9;
            }
            if (kuş.Top < -25)
            {
                endgame(); 
            }

        }

        private void gamekeydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                yerçekimi = -8;
            }
            else if (e.KeyCode == Keys.Enter && !gametimer.Enabled)
            {
                RestartGame();

            }

        }

        private void gamekeyup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                yerçekimi = +8;
            }
        }
        private void endgame()
        {
            gametimer.Stop();
            scoreText.Text = "Game Over! Yeniden başlamak için Enter'a basınız.";
        }
        private void RestartGame()
        {
            score = 0;
            boruHızı = 5;
            yerçekimi = 8;
            scoreText.Text = "Score: 0";
            kuş.Left = 60; 
            kuş.Top = 150; 
            int borularArasiYatayMesafe = 350;
            int baslangicX = this.ClientSize.Width + 100;

            foreach (var set in boruSetleri)
            {
                PictureBox boruUst = set[0];
                PictureBox boruAlt = set[1];
                boruAlt.Left = baslangicX;
                boruUst.Left = baslangicX;
                baslangicX += borularArasiYatayMesafe;
                int bosluk = 150;
                int yeniAltYukseklik = random.Next(100, 300);
                boruAlt.Height = yeniAltYukseklik;
                boruAlt.Top = zemin.Top - boruAlt.Height;
                boruUst.Top = 0;
                boruUst.Height = zemin.Top - bosluk - boruAlt.Height;
                boruAlt.Tag = "no";
            }
            gametimer.Start();
        }
    }
}