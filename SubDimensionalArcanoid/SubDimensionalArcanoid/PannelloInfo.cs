using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
using System.IO;

namespace SubDimensionalArcanoid
{
    public partial class PannelloInfo : Form
    {
        public PannelloInfo()
        {
            InitializeComponent();
           
        }
        int  y2;
        private void tmr_Ending_Tick(object sender, EventArgs e)
        {
           
            y2 = lbl_Titolidicoda2.Location.Y - 1;
           
            if (y2 == 25)
            {
                tmr_Ending.Stop();             
            }
            else
                lbl_Titolidicoda2.Location = new Point(lbl_Titolidicoda2.Location.X, y2);
        }

        private void PannelloInfo_Leave(object sender, EventArgs e)
        {
          
        }
     //   Stream prova = SubDimensionalArcanoid.Properties.Resources.CreditTheme;

       // SoundPlayer Credit;
        private void btn_RitornaAlGioco_Click(object sender, EventArgs e)
        {
            
            //Credit.Stop();
            //HomePage.Hometheme.Play();
            this.Close();

        }

        private void PannelloInfo_Load(object sender, EventArgs e)
        {
           // Credit = new SoundPlayer(prova);
           // Credit.Play();
            tmr_Ending.Start();
        }
    }
}
