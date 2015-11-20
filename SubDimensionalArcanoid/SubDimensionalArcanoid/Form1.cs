using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubDimensionalArcanoid
{
    public partial class frmGame : Form
    {
        public frmGame()
        {
            InitializeComponent();

        }
        int vite;
        Palla P1;
        private double punteggio = 0;
        private Rectangle rtn_Barra;
        private Rectangle rtn_Palla;
        int VittoriaCont;
        AltriMetodi Ogg = new AltriMetodi();
        private void frmGame_Load(object sender, EventArgs e)
        {
            rtn_Barra = new Rectangle(pcb_Paddle.Location.X, pcb_Paddle.Location.Y, pcb_Paddle.Width, pcb_Paddle.Height);
            rtn_Palla = new Rectangle(pcb_Ball.Location.X, pcb_Ball.Location.Y, pcb_Ball.Width, pcb_Ball.Height);

            Ogg.SpawnaOggetti(ref Brick, ref pnl_Home, ref Rect);
            P1 = new Palla(ref rtn_Palla, ref pcb_Ball);
            //tmr_Resume.Stop();
            pcb_Start.Focus();
        }

        
        private void Ball_Movement_Timer_Tick(object sender, EventArgs e)
        {
            rtn_Barra.Location = pcb_Paddle.Location;
            if (P1.MovimentoEGestione(ref rtn_Barra, ref Brick, ref Rect, ref VittoriaCont, ref punteggio) == true)
            {
                Ball_Movement_Timer.Stop();
                Ball_Movement_Timer.Enabled = false;
                MessageBox.Show("Hai perso una vita Idiota");
                vite--;
                lbl_Vite.Text = vite.ToString();
                CheckVite();

                pcb_Ball.Location = new Point(160, 360);

                punteggio /= 2;
                MessageBox.Show("Clicca sulla palla per continuare (Non premere 'e'") ;
            }
            else
            { lbl_Point.Text = punteggio.ToString(); }
            if (VittoriaCont == 35)
            {
                Ball_Movement_Timer.Stop();
                if (EE1_1 == true)
                    //EE1.Stop();

                if (!Serial)
                {
                    MessageBox.Show("Vuoi vincere? Compra il DLC presso steam");
                }
                else
                {
                    Stream S1 = Properties.Resources.WinTheme;
                    SoundPlayer SP1 = new SoundPlayer(S1);
                    SP1.Play();
                    MessageBox.Show("Complimenti, hai vinto la partita");
                    SP1.Stop();
                    Ogg.AttivaNewGame(ref Brick, ref pcb_Ball, ref VittoriaCont, ref pnl_Home, ref pcb_Start, ref punteggio, ref lbl_Point, ref pcb_Paddle);
                    pcb_Start.Enabled = true;
                }
            }
        }
        private void CheckVite()
        {
            if (vite == 0)
            {
                MessageBox.Show("Hai perso, il tuo punteggio finale è di" + punteggio);
                Ogg.AttivaNewGame(ref Brick, ref pcb_Ball, ref VittoriaCont, ref pnl_Home, ref pcb_Start, ref punteggio, ref lbl_Point, ref pcb_Paddle);
            }
        }
        bool Serial = false;
        private void pcb_Start_Click(object sender, EventArgs e)
        {
            pnl_Impo.Enabled = false;
            Ball_Movement_Timer.Start();
            if (EE1_2)
            {
                lbl_Vite.Text = "Inf";
                vite = 100;
            }
            else
            {
                vite = 4;
                lbl_Vite.Text = vite.ToString();
            }

            pnl_Home.Enabled = true;
        }
        private void pnl_Home_MouseMove(object sender, MouseEventArgs e)
        {
            if (Muovimento)
            {
                int x, y;
                x = Convert.ToInt32(e.X);
                y = pcb_Paddle.Location.Y;

                this.pcb_Paddle.Location = new Point(e.X - pcb_Paddle.Width / 2, 390);
            }
        }
        string EasterEggCode = "";
        //Stream S2 = Properties.Resources.SongEasterEgg;
        //SoundPlayer EE1;
        bool EE1_1 = false;
        bool EE1_2 = false;



        private void txt_EasterEgg_KeyPress(object sender, KeyPressEventArgs e)
        {
            string ds = "E5A87DHXA";
            EE1_2 = false;
            pcb_EasterEgg.Value = 0;
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                switch (EasterEggCode)
                {
                    case "songnameplz":
                        //EE1 = new SoundPlayer(S2); EE1.Play(); EE1_1 = true;
                        pcb_EasterEgg.Visible = true; break;
                    case "neptuniaplz": MessageBox.Show("Se non te l'ho dicevo io te non ci arrivavi mai... -_-"); EE1_2 = true; lbl_Vite.Text = "Infinite"; break;
                    case "tnnandtoop4me": MessageBox.Show("E vabbe... costava tanto pagare 0,50€... "); Serial = true; break;
                    default: MessageBox.Show("Ehehehehheeh, non ti aiuto io"); break;

                }
                pcb_EasterEgg.Visible = true;
                for (int i = 0; i < 10; i++)
                {
                    pcb_EasterEgg.Value += pcb_EasterEgg.Step;
                }

                ds = ds.ToLower();
                EasterEggCode = txt_EasterEgg.Text.ToLower();

            }
        }
        int x, y;
        private void frmGame_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (Char.ToLower((char)e.KeyChar))
            {
                case 'e': txt_EasterEgg.Visible = true; break;
                case (char)Keys.Return:
                    if (Ball_Movement_Timer.Enabled == false)
                    {
                        Ball_Movement_Timer.Enabled = true;
                        Ball_Movement_Timer.Start();
                    }
                    break;
                case 'a':
                    if (Muovimento == false)
                    {
                        x = pcb_Paddle.Location.X;
                        x -= 10;
                        y = pcb_Paddle.Location.Y;

                        this.pcb_Paddle.Location = new Point(x, y);
                    }break;
                case 'd':
                    if (Muovimento == false)
                    {
                        x = pcb_Paddle.Location.X;
                        x -= 10;
                        y = pcb_Paddle.Location.Y;

                        this.pcb_Paddle.Location = new Point(x, y);
                    }
                    break;
                default: break;
            }

            
        }


        private void btn_Return_Click(object sender, EventArgs e)
        {
         //   SoundPlayer Bye = new SoundPlayer(Properties.Resources.sm64_mario_thank_you);
          //  Bye.Play();

           /// HomePage.Hometheme.Play();
            Close();
        }

        private void pcb_Ball_Click(object sender, EventArgs e)
        {
            if (Ball_Movement_Timer.Enabled == false)
            {
                Ball_Movement_Timer.Enabled = true;
                Ball_Movement_Timer.Start();
            }
        }

        private void btn_Return_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (Char.ToLower((char)e.KeyChar))
            {
                case 'e': txt_EasterEgg.Visible = true; break;
                case (char)Keys.Return:
                    if (Ball_Movement_Timer.Enabled == false)
                    {
                        Ball_Movement_Timer.Enabled = true;
                        Ball_Movement_Timer.Start();
                    }
                    break;
                default: break;
            }


        }
        bool Muovimento = true;
        private void rdb_mouse_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_mouse.Checked)
            { Muovimento = true; }
            else { Muovimento = false; }
        }

        private void btn_Return_KeyDown(object sender, KeyEventArgs e)
        { }
    }
}
