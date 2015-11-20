using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubDimensionalArcanoid
{
    class Palla
    {
        private Rectangle recBall;   //Rif
        private PictureBox pictBall;
        private int xMov = 0;// ||
                             // ||Costanti movimento
        private int yMov = 0;// ||
        private int kMovimento = 0;//Velocità Costante
        private Random m = new Random();
        public Palla(ref Rectangle rBall, ref PictureBox bBall)
        {
            this.recBall = rBall;
            this.pictBall = bBall;
            xMov = 1;
            yMov = 1;
            kMovimento = 5;

        }
        //  _______Movimento_________
        public bool MovimentoEGestione(ref Rectangle recPaddle, ref PictureBox[] ArrayButton, ref Rectangle[] ArrayRectangle,ref int contV, ref double Punti )
        {
            bool Trigger;
            pictBall.Location = new Point(pictBall.Location.X + xMov, pictBall.Location.Y + yMov);
            recBall.Location = pictBall.Location;


            for (int i = 0; i < 36; i++)
            {

                if (ArrayButton[i].Visible == true && ArrayRectangle[i].IntersectsWith(recBall))
                {
                 //   SoundPlayer bumb = new SoundPlayer(Properties.Resources.smb_bump);
                 //   bumb.Play();
                    yMov = kMovimento;
                    ArrayButton[i].Visible = false;
                   contV++;
                    Punti += 10;
                                           
                }

            }
            Trigger = false;
            if (recBall.IntersectsWith(recPaddle))
            {
                yMov = -kMovimento;
                xMov = m.Next(-5, 5);
            }
            else if (pictBall.Location.X >= 341)
                xMov = -kMovimento + m.Next(0, 5);
            else if (pictBall.Location.X <= 1)
                xMov = kMovimento + m.Next(0, 5);
            else if (pictBall.Location.Y <= 0)
                yMov = kMovimento + m.Next(0, 5);
            else if (pictBall.Location.Y >= 397)
            {
                Trigger = true;
                //TriggerLostBall
                /*
                     Ball_Movement_Timer.Stop();
                     MessageBox.Show("Hai perso una vita [Idiota]");
                     vite--;
                     lbl_Vite.Text = vite.ToString();
                     CheckVite();
                     btn_PallaGioco.Location = new Point(405, 180);
                     btn_PallaGioco.Focus();
                     punteggio /= 2;
                     MessageBox.Show("Clicca sulla palla o premi invio per continuare");
                */
            }
            return Trigger;
        }
    }          
    }

