namespace projekkp_systemgugur.daftarpeserta
{
    partial class daftarudA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(daftarudA));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnama = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbagan = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(569, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(845, 471);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(513, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "DAFTAR PESERTA ";
            // 
            // txtnama
            // 
            this.txtnama.AutoSize = true;
            this.txtnama.Font = new System.Drawing.Font("Lucida Bright", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnama.Location = new System.Drawing.Point(592, 83);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(29, 33);
            this.txtnama.TabIndex = 2;
            this.txtnama.Text = "?";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.Location = new System.Drawing.Point(1, 765);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(45, 23);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1269, 649);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(939, 649);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(324, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "PESERTA BERJUMLAH";
            // 
            // txtbagan
            // 
            this.txtbagan.ActiveBorderThickness = 1;
            this.txtbagan.ActiveCornerRadius = 20;
            this.txtbagan.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.txtbagan.ActiveForecolor = System.Drawing.Color.White;
            this.txtbagan.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.txtbagan.BackColor = System.Drawing.SystemColors.Control;
            this.txtbagan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtbagan.BackgroundImage")));
            this.txtbagan.ButtonText = "Bagan";
            this.txtbagan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtbagan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbagan.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtbagan.IdleBorderThickness = 1;
            this.txtbagan.IdleCornerRadius = 20;
            this.txtbagan.IdleFillColor = System.Drawing.Color.White;
            this.txtbagan.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.txtbagan.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.txtbagan.Location = new System.Drawing.Point(1254, 720);
            this.txtbagan.Margin = new System.Windows.Forms.Padding(5);
            this.txtbagan.Name = "txtbagan";
            this.txtbagan.Size = new System.Drawing.Size(181, 54);
            this.txtbagan.TabIndex = 6;
            this.txtbagan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtbagan.Click += new System.EventHandler(this.txtbagan_Click);
            // 
            // daftarudA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 788);
            this.Controls.Add(this.txtbagan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtnama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "daftarudA";
            this.Text = "daftarudA";
            this.Load += new System.EventHandler(this.daftarudA_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtnama;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuThinButton2 txtbagan;
    }
}