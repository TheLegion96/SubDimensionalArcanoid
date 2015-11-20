using System;
using SubDimensionalArcanoid.Properties;
using SubDimensionalArcanoid;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SubDimensionalArcanoid
{
   public class AltriMetodi
    {
        int x, y;
        public void SpawnaOggetti(ref PictureBox[] pcb_Matt, ref Panel pnl_Home, ref Rectangle[] Rect)
        {
  
            x = 3;
            y = 3;
            for (int i = 0; i < 12; i++)
            {
                pcb_Matt[i] = new PictureBox();
                pcb_Matt[i].Width = 25; pcb_Matt[i].Height = 15;
                pcb_Matt[i].Image = SubDimensionalArcanoid.Properties.Resources.RedBrick;
                pcb_Matt[i].SizeMode = PictureBoxSizeMode.StretchImage;
                pcb_Matt[i].Enabled = false;
                pcb_Matt[i].Location = new Point(x, y);
                x += 30;
                pcb_Matt[i].BackColor = Color.Red;
                pnl_Home.Controls.Add(pcb_Matt[i]);
                Rect[i] = new Rectangle(pcb_Matt[i].Location.X, pcb_Matt[i].Location.Y, pcb_Matt[i].Width, pcb_Matt[i].Height);

            }
            y += 35;
            x = 3;
            for (int i = 12; i < 24; i++)
            {
                pcb_Matt[i] = new PictureBox();
                pcb_Matt[i].Width = 25; pcb_Matt[i].Height = 15;
                pcb_Matt[i].Name = "btn_GreenBrick" + i;
                pcb_Matt[i].Image = SubDimensionalArcanoid.Properties.Resources.GreenBrick;
                pcb_Matt[i].SizeMode = PictureBoxSizeMode.StretchImage;
                pcb_Matt[i].Enabled = false;
                pcb_Matt[i].Location = new Point(x, y);
                x += 30;
                pcb_Matt[i].BackColor = Color.Green;
                pnl_Home.Controls.Add(pcb_Matt[i]);
                Rect[i] = new Rectangle(pcb_Matt[i].Location.X, pcb_Matt[i].Location.Y, pcb_Matt[i].Width, pcb_Matt[i].Height);
                
            }
            y += 35;
            x = 3;
            for (int i = 24; i < 36; i++)
            {
                pcb_Matt[i] = new PictureBox();
                pcb_Matt[i].Width = 25; pcb_Matt[i].Height = 15;
                pcb_Matt[i].Name = "btm_BlueBrick" + i;
                pcb_Matt[i].Image = SubDimensionalArcanoid.Properties.Resources.BlueBrick;
                pcb_Matt[i].SizeMode = PictureBoxSizeMode.StretchImage;
                pcb_Matt[i].Enabled = false;
                pcb_Matt[i].Location = new Point(x, y);
                x += 30;
                pcb_Matt[i].BackColor = Color.Blue;
                pnl_Home.Controls.Add(pcb_Matt[i]);
                Rect[i] = new Rectangle(pcb_Matt[i].Location.X, pcb_Matt[i].Location.Y, pcb_Matt[i].Width, pcb_Matt[i].Height);
            }

        }
  public  void AttivaNewGame
            (ref PictureBox[] Brick, ref PictureBox pcb_Ball, ref int VittoriaCont, ref Panel pnl_Home, ref PictureBox pcb_Start,ref double punteggio, ref Label lbl_Point, ref PictureBox pcb_Paddle)
        {
            for (int i = 0; i < Brick.Length; i++)
            {
                Brick[i].Visible = true;
            }
            pcb_Ball.Location = new Point(375, 243);
            pnl_Home.Enabled = false;
            VittoriaCont = 0;
            pcb_Start.Enabled = true;
            pcb_Paddle.Location = new Point(218, 23);
            punteggio = 0;
            lbl_Point.Text = punteggio.ToString();
        }

    }
}
