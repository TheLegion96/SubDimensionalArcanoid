namespace SubDimensionalArcanoid
{
    partial class PannelloInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PannelloInfo));
            this.lbl_Titoli_Di_Coda = new System.Windows.Forms.Label();
            this.tmr_Ending = new System.Windows.Forms.Timer(this.components);
            this.lbl_Titolidicoda2 = new System.Windows.Forms.Label();
            this.btn_RitornaAlGioco = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Titoli_Di_Coda
            // 
            this.lbl_Titoli_Di_Coda.AutoSize = true;
            this.lbl_Titoli_Di_Coda.Location = new System.Drawing.Point(278, 14);
            this.lbl_Titoli_Di_Coda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Titoli_Di_Coda.Name = "lbl_Titoli_Di_Coda";
            this.lbl_Titoli_Di_Coda.Size = new System.Drawing.Size(115, 20);
            this.lbl_Titoli_Di_Coda.TabIndex = 1;
            this.lbl_Titoli_Di_Coda.Text = "Ringraziamenti";
            // 
            // tmr_Ending
            // 
            this.tmr_Ending.Interval = 10;
            this.tmr_Ending.Tick += new System.EventHandler(this.tmr_Ending_Tick);
            // 
            // lbl_Titolidicoda2
            // 
            this.lbl_Titolidicoda2.AutoSize = true;
            this.lbl_Titolidicoda2.Location = new System.Drawing.Point(98, 615);
            this.lbl_Titolidicoda2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Titolidicoda2.Name = "lbl_Titolidicoda2";
            this.lbl_Titolidicoda2.Size = new System.Drawing.Size(478, 220);
            this.lbl_Titolidicoda2.TabIndex = 2;
            this.lbl_Titolidicoda2.Text = resources.GetString("lbl_Titolidicoda2.Text");
            this.lbl_Titolidicoda2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_RitornaAlGioco
            // 
            this.btn_RitornaAlGioco.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_RitornaAlGioco.Location = new System.Drawing.Point(18, 448);
            this.btn_RitornaAlGioco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_RitornaAlGioco.Name = "btn_RitornaAlGioco";
            this.btn_RitornaAlGioco.Size = new System.Drawing.Size(633, 35);
            this.btn_RitornaAlGioco.TabIndex = 3;
            this.btn_RitornaAlGioco.Text = "Ritorna al Gioco";
            this.btn_RitornaAlGioco.UseVisualStyleBackColor = true;
            this.btn_RitornaAlGioco.Click += new System.EventHandler(this.btn_RitornaAlGioco_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SubDimensionalArcanoid.Properties.Resources.CreditImage;
            this.pictureBox1.Location = new System.Drawing.Point(18, 263);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(633, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PannelloInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btn_RitornaAlGioco;
            this.ClientSize = new System.Drawing.Size(700, 492);
            this.ControlBox = false;
            this.Controls.Add(this.btn_RitornaAlGioco);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_Titolidicoda2);
            this.Controls.Add(this.lbl_Titoli_Di_Coda);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PannelloInfo";
            this.Text = "Crediti";
            this.Load += new System.EventHandler(this.PannelloInfo_Load);
            this.Leave += new System.EventHandler(this.PannelloInfo_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Titoli_Di_Coda;
        private System.Windows.Forms.Timer tmr_Ending;
        private System.Windows.Forms.Label lbl_Titolidicoda2;
        private System.Windows.Forms.Button btn_RitornaAlGioco;
    }
}