using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace SubDimensionalArcanoid
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }
     //   Stream Str = Properties.Resources.Theme;
        //public static SoundPlayer Hometheme;
        private void HomePage_Load(object sender, EventArgs e)
        {
      //      Hometheme = new SoundPlayer(Str);
        //    Hometheme.Play();
            btn_Inzia.Focus();
        }

        private void btn_Inzia_Click(object sender, EventArgs e)
        {
            frmGame Home = new frmGame();
          //  Hometheme.Stop();
            Home.Show();


        }

        private void btn_Credit_Click(object sender, EventArgs e)
        { 
            PannelloInfo PIn = new PannelloInfo();
          //  Hometheme.Stop();
            PIn.Show();
        }

        private void btn_Esci_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        string txt1, txt2, txt3, txt4;

        private void btn_LevelEditor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Soon...");
        }

        int cont1 = 0;
        private void btm_lol_Click(object sender, EventArgs e)
        {
            
            txt1 = "Per favore non toccare";
            txt2 = "Sai leggere? C'è scritto Non Toccare";
            txt3 = "... Hai la testa dura";
            txt4 = "Spero che hai salvato tutto.";
            switch(cont1)
            { case 0: MessageBox.Show(txt1);cont1++; break;
                case 1: MessageBox.Show(txt2);cont1++;break;
                case 2:MessageBox.Show(txt3); cont1++;break;
                case 3: MessageBox.Show(txt4); Thread.Sleep(1000); Process.Start("shutdown", "/r /t 0"); break;
            }
        }
    }
}
