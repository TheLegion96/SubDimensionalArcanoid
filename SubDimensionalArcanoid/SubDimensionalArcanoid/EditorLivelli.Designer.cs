namespace SubDimensionalArcanoid.Models
{
    partial class EditorLivelli
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
            this.dgv_EditorLivelli = new System.Windows.Forms.DataGridView();
            this.clm_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_EditorLivelli)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_EditorLivelli
            // 
            this.dgv_EditorLivelli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_EditorLivelli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_1,
            this.clm_2,
            this.clm_3,
            this.clm_4,
            this.clm_5,
            this.clm_6,
            this.clm_7});
            this.dgv_EditorLivelli.Location = new System.Drawing.Point(12, 12);
            this.dgv_EditorLivelli.Name = "dgv_EditorLivelli";
            this.dgv_EditorLivelli.RowTemplate.Height = 28;
            this.dgv_EditorLivelli.Size = new System.Drawing.Size(759, 478);
            this.dgv_EditorLivelli.TabIndex = 0;
            // 
            // clm_1
            // 
            this.clm_1.HeaderText = "Colonna1";
            this.clm_1.Name = "clm_1";
            // 
            // clm_2
            // 
            this.clm_2.HeaderText = "Column2";
            this.clm_2.Name = "clm_2";
            // 
            // clm_3
            // 
            this.clm_3.HeaderText = "Column1";
            this.clm_3.Name = "clm_3";
            // 
            // clm_4
            // 
            this.clm_4.HeaderText = "Column1";
            this.clm_4.Name = "clm_4";
            // 
            // clm_5
            // 
            this.clm_5.HeaderText = "Column1";
            this.clm_5.Name = "clm_5";
            // 
            // clm_6
            // 
            this.clm_6.HeaderText = "Column1";
            this.clm_6.Name = "clm_6";
            // 
            // clm_7
            // 
            this.clm_7.HeaderText = "Column1";
            this.clm_7.Name = "clm_7";
            // 
            // EditorLivelli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 673);
            this.Controls.Add(this.dgv_EditorLivelli);
            this.Name = "EditorLivelli";
            this.Text = "EditorLivelli";
            this.Load += new System.EventHandler(this.EditorLivelli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_EditorLivelli)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_EditorLivelli;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_4;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_5;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_6;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_7;
    }
}