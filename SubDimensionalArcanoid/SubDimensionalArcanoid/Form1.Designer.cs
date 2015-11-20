namespace SubDimensionalArcanoid
{
    partial class frmGame
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGame));
            this.lbl_Testo = new System.Windows.Forms.Label();
            this.lbl_Point = new System.Windows.Forms.Label();
            this.lbl_Testo2 = new System.Windows.Forms.Label();
            this.lbl_Vite = new System.Windows.Forms.Label();
            this.pcb_EasterEgg = new System.Windows.Forms.ProgressBar();
            this.txt_EasterEgg = new System.Windows.Forms.TextBox();
            this.Ball_Movement_Timer = new System.Windows.Forms.Timer(this.components);
            this.btn_Return = new System.Windows.Forms.Button();
            this.pnl_Home = new System.Windows.Forms.Panel();
            this.pcb_Ball = new System.Windows.Forms.PictureBox();
            this.pcb_Paddle = new System.Windows.Forms.PictureBox();
            this.pcb_Start = new System.Windows.Forms.PictureBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rdb_mouse = new System.Windows.Forms.RadioButton();
            this.pnl_Impo = new System.Windows.Forms.Panel();
            this.pnl_Home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Paddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Start)).BeginInit();
            this.pnl_Impo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Testo
            // 
            resources.ApplyResources(this.lbl_Testo, "lbl_Testo");
            this.lbl_Testo.Name = "lbl_Testo";
            // 
            // lbl_Point
            // 
            resources.ApplyResources(this.lbl_Point, "lbl_Point");
            this.lbl_Point.Name = "lbl_Point";
            // 
            // lbl_Testo2
            // 
            resources.ApplyResources(this.lbl_Testo2, "lbl_Testo2");
            this.lbl_Testo2.Name = "lbl_Testo2";
            // 
            // lbl_Vite
            // 
            resources.ApplyResources(this.lbl_Vite, "lbl_Vite");
            this.lbl_Vite.Name = "lbl_Vite";
            // 
            // pcb_EasterEgg
            // 
            resources.ApplyResources(this.pcb_EasterEgg, "pcb_EasterEgg");
            this.pcb_EasterEgg.Name = "pcb_EasterEgg";
            // 
            // txt_EasterEgg
            // 
            resources.ApplyResources(this.txt_EasterEgg, "txt_EasterEgg");
            this.txt_EasterEgg.Name = "txt_EasterEgg";
            this.txt_EasterEgg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_EasterEgg_KeyPress);
            // 
            // Ball_Movement_Timer
            // 
            this.Ball_Movement_Timer.Interval = 1;
            this.Ball_Movement_Timer.Tick += new System.EventHandler(this.Ball_Movement_Timer_Tick);
            // 
            // btn_Return
            // 
            this.btn_Return.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btn_Return, "btn_Return");
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.UseVisualStyleBackColor = true;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            this.btn_Return.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Return_KeyDown);
            this.btn_Return.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn_Return_KeyPress);
            // 
            // pnl_Home
            // 
            this.pnl_Home.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnl_Home.Controls.Add(this.pcb_Ball);
            this.pnl_Home.Controls.Add(this.pcb_Paddle);
            resources.ApplyResources(this.pnl_Home, "pnl_Home");
            this.pnl_Home.Name = "pnl_Home";
            this.pnl_Home.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Home_MouseMove);
            // 
            // pcb_Ball
            // 
            this.pcb_Ball.Image = global::SubDimensionalArcanoid.Properties.Resources.sfera_durmotirite;
            resources.ApplyResources(this.pcb_Ball, "pcb_Ball");
            this.pcb_Ball.Name = "pcb_Ball";
            this.pcb_Ball.TabStop = false;
            this.pcb_Ball.Click += new System.EventHandler(this.pcb_Ball_Click);
            // 
            // pcb_Paddle
            // 
            this.pcb_Paddle.Image = global::SubDimensionalArcanoid.Properties.Resources.Paddle2;
            resources.ApplyResources(this.pcb_Paddle, "pcb_Paddle");
            this.pcb_Paddle.Name = "pcb_Paddle";
            this.pcb_Paddle.TabStop = false;
            // 
            // pcb_Start
            // 
            this.pcb_Start.Image = global::SubDimensionalArcanoid.Properties.Resources.Start;
            resources.ApplyResources(this.pcb_Start, "pcb_Start");
            this.pcb_Start.Name = "pcb_Start";
            this.pcb_Start.TabStop = false;
            this.pcb_Start.Click += new System.EventHandler(this.pcb_Start_Click);
            // 
            // radioButton1
            // 
            resources.ApplyResources(this.radioButton1, "radioButton1");
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rdb_mouse
            // 
            resources.ApplyResources(this.rdb_mouse, "rdb_mouse");
            this.rdb_mouse.Checked = true;
            this.rdb_mouse.Name = "rdb_mouse";
            this.rdb_mouse.TabStop = true;
            this.rdb_mouse.UseVisualStyleBackColor = true;
            this.rdb_mouse.CheckedChanged += new System.EventHandler(this.rdb_mouse_CheckedChanged);
            // 
            // pnl_Impo
            // 
            this.pnl_Impo.Controls.Add(this.radioButton1);
            this.pnl_Impo.Controls.Add(this.rdb_mouse);
            resources.ApplyResources(this.pnl_Impo, "pnl_Impo");
            this.pnl_Impo.Name = "pnl_Impo";
            // 
            // frmGame
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Return;
            this.Controls.Add(this.pnl_Impo);
            this.Controls.Add(this.btn_Return);
            this.Controls.Add(this.txt_EasterEgg);
            this.Controls.Add(this.pcb_EasterEgg);
            this.Controls.Add(this.lbl_Vite);
            this.Controls.Add(this.lbl_Testo2);
            this.Controls.Add(this.lbl_Point);
            this.Controls.Add(this.lbl_Testo);
            this.Controls.Add(this.pcb_Start);
            this.Controls.Add(this.pnl_Home);
            this.Name = "frmGame";
            this.Load += new System.EventHandler(this.frmGame_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmGame_KeyPress);
            this.pnl_Home.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Paddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Start)).EndInit();
            this.pnl_Impo.ResumeLayout(false);
            this.pnl_Impo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Home;
        private System.Windows.Forms.PictureBox pcb_Start;
        private System.Windows.Forms.PictureBox pcb_Ball;
        private System.Windows.Forms.PictureBox pcb_Paddle;
        private System.Windows.Forms.Label lbl_Testo;
        private System.Windows.Forms.Label lbl_Point;
        private System.Windows.Forms.Label lbl_Testo2;
        private System.Windows.Forms.Label lbl_Vite;
        private System.Windows.Forms.ProgressBar pcb_EasterEgg;

        private System.Windows.Forms.TextBox txt_EasterEgg;
        private System.Windows.Forms.PictureBox[] Brick= new System.Windows.Forms.PictureBox[36];
        private System.Drawing.Rectangle[] Rect= new System.Drawing.Rectangle[36];
        private System.Windows.Forms.Timer Ball_Movement_Timer;
        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rdb_mouse;
        private System.Windows.Forms.Panel pnl_Impo;
    }

}

