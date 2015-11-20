namespace SubDimensionalArcanoid
{
    partial class HomePage
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
            this.btn_Inzia = new System.Windows.Forms.Button();
            this.btn_LevelEditor = new System.Windows.Forms.Button();
            this.btn_Esci = new System.Windows.Forms.Button();
            this.btn_Credit = new System.Windows.Forms.Button();
            this.pcb_Logo = new System.Windows.Forms.PictureBox();
            this.btm_lol = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Inzia
            // 
            this.btn_Inzia.BackColor = System.Drawing.Color.Transparent;
            this.btn_Inzia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inzia.Location = new System.Drawing.Point(75, 182);
            this.btn_Inzia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Inzia.Name = "btn_Inzia";
            this.btn_Inzia.Size = new System.Drawing.Size(246, 88);
            this.btn_Inzia.TabIndex = 1;
            this.btn_Inzia.Text = "Start Game";
            this.btn_Inzia.UseVisualStyleBackColor = false;
            this.btn_Inzia.Click += new System.EventHandler(this.btn_Inzia_Click);
            // 
            // btn_LevelEditor
            // 
            this.btn_LevelEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LevelEditor.Location = new System.Drawing.Point(75, 297);
            this.btn_LevelEditor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_LevelEditor.Name = "btn_LevelEditor";
            this.btn_LevelEditor.Size = new System.Drawing.Size(246, 88);
            this.btn_LevelEditor.TabIndex = 1;
            this.btn_LevelEditor.Text = " Level \r\nEditor\r\n (NaN)";
            this.btn_LevelEditor.UseVisualStyleBackColor = true;
            this.btn_LevelEditor.Click += new System.EventHandler(this.btn_LevelEditor_Click);
            // 
            // btn_Esci
            // 
            this.btn_Esci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Esci.Location = new System.Drawing.Point(75, 555);
            this.btn_Esci.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Esci.Name = "btn_Esci";
            this.btn_Esci.Size = new System.Drawing.Size(246, 88);
            this.btn_Esci.TabIndex = 1;
            this.btn_Esci.Text = "Esci";
            this.btn_Esci.UseVisualStyleBackColor = true;
            this.btn_Esci.Click += new System.EventHandler(this.btn_Esci_Click);
            // 
            // btn_Credit
            // 
            this.btn_Credit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Credit.Location = new System.Drawing.Point(75, 418);
            this.btn_Credit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Credit.Name = "btn_Credit";
            this.btn_Credit.Size = new System.Drawing.Size(246, 88);
            this.btn_Credit.TabIndex = 1;
            this.btn_Credit.Text = "Credit";
            this.btn_Credit.UseVisualStyleBackColor = true;
            this.btn_Credit.Click += new System.EventHandler(this.btn_Credit_Click);
            // 
            // pcb_Logo
            // 
            this.pcb_Logo.Image = global::SubDimensionalArcanoid.Properties.Resources.LogoProva1;
            this.pcb_Logo.Location = new System.Drawing.Point(18, 18);
            this.pcb_Logo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pcb_Logo.Name = "pcb_Logo";
            this.pcb_Logo.Size = new System.Drawing.Size(334, 154);
            this.pcb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Logo.TabIndex = 2;
            this.pcb_Logo.TabStop = false;
            // 
            // btm_lol
            // 
            this.btm_lol.Location = new System.Drawing.Point(570, 703);
            this.btm_lol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btm_lol.Name = "btm_lol";
            this.btm_lol.Size = new System.Drawing.Size(117, 35);
            this.btm_lol.TabIndex = 3;
            this.btm_lol.Text = "Non Toccare";
            this.btm_lol.UseVisualStyleBackColor = true;
            this.btm_lol.Click += new System.EventHandler(this.btm_lol_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::SubDimensionalArcanoid.Properties.Resources.Home;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(687, 742);
            this.Controls.Add(this.btm_lol);
            this.Controls.Add(this.pcb_Logo);
            this.Controls.Add(this.btn_Esci);
            this.Controls.Add(this.btn_Credit);
            this.Controls.Add(this.btn_LevelEditor);
            this.Controls.Add(this.btn_Inzia);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HomePage";
            this.Text = "Home Page ";
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Inzia;
        private System.Windows.Forms.Button btn_LevelEditor;
        private System.Windows.Forms.Button btn_Esci;
        private System.Windows.Forms.PictureBox pcb_Logo;
        private System.Windows.Forms.Button btn_Credit;
        private System.Windows.Forms.Button btm_lol;
    }
}