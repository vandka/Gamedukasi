namespace GAMEDUKASI
{
    partial class About
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
            this.picufo = new System.Windows.Forms.PictureBox();
            this.picas = new System.Windows.Forms.PictureBox();
            this.movasteroid = new System.Windows.Forms.Timer(this.components);
            this.movufo = new System.Windows.Forms.Timer(this.components);
            this.piccery = new System.Windows.Forms.PictureBox();
            this.labskor = new System.Windows.Forms.Label();
            this.labbumov = new System.Windows.Forms.Label();
            this.labedu1 = new System.Windows.Forms.Label();
            this.labplay = new System.Windows.Forms.Label();
            this.labedu2 = new System.Windows.Forms.Label();
            this.panedu = new System.Windows.Forms.Panel();
            this.labcreate = new System.Windows.Forms.Label();
            this.labthanks = new System.Windows.Forms.Label();
            this.labthanks02 = new System.Windows.Forms.Label();
            this.labthanks01 = new System.Windows.Forms.Label();
            this.labthanks03 = new System.Windows.Forms.Label();
            this.labprog = new System.Windows.Forms.Label();
            this.labthanks04 = new System.Windows.Forms.Label();
            this.movinglab = new System.Windows.Forms.Timer(this.components);
            this.labprog2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picufo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piccery)).BeginInit();
            this.panedu.SuspendLayout();
            this.SuspendLayout();
            // 
            // picufo
            // 
            this.picufo.BackColor = System.Drawing.Color.Transparent;
            this.picufo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picufo.Image = global::GAMEDUKASI.Properties.Resources.ufo;
            this.picufo.Location = new System.Drawing.Point(428, 133);
            this.picufo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picufo.Name = "picufo";
            this.picufo.Size = new System.Drawing.Size(25, 25);
            this.picufo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picufo.TabIndex = 1;
            this.picufo.TabStop = false;
            // 
            // picas
            // 
            this.picas.BackColor = System.Drawing.Color.Transparent;
            this.picas.Image = global::GAMEDUKASI.Properties.Resources.organism;
            this.picas.Location = new System.Drawing.Point(561, 34);
            this.picas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picas.Name = "picas";
            this.picas.Size = new System.Drawing.Size(25, 25);
            this.picas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picas.TabIndex = 0;
            this.picas.TabStop = false;
            // 
            // movasteroid
            // 
            this.movasteroid.Interval = 25;
            this.movasteroid.Tick += new System.EventHandler(this.movasteroid_Tick);
            // 
            // movufo
            // 
            this.movufo.Enabled = true;
            this.movufo.Interval = 50;
            this.movufo.Tick += new System.EventHandler(this.movufo_Tick);
            // 
            // piccery
            // 
            this.piccery.BackColor = System.Drawing.Color.Transparent;
            this.piccery.Image = global::GAMEDUKASI.Properties.Resources.cherry;
            this.piccery.Location = new System.Drawing.Point(511, 72);
            this.piccery.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.piccery.Name = "piccery";
            this.piccery.Size = new System.Drawing.Size(25, 25);
            this.piccery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.piccery.TabIndex = 2;
            this.piccery.TabStop = false;
            // 
            // labskor
            // 
            this.labskor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labskor.AutoSize = true;
            this.labskor.BackColor = System.Drawing.Color.Transparent;
            this.labskor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labskor.Location = new System.Drawing.Point(589, 9);
            this.labskor.Name = "labskor";
            this.labskor.Size = new System.Drawing.Size(59, 17);
            this.labskor.TabIndex = 3;
            this.labskor.Text = "Score : 0";
            // 
            // labbumov
            // 
            this.labbumov.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labbumov.AutoSize = true;
            this.labbumov.Font = new System.Drawing.Font("Nightclub BTN", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labbumov.ForeColor = System.Drawing.Color.Teal;
            this.labbumov.Location = new System.Drawing.Point(604, 233);
            this.labbumov.Name = "labbumov";
            this.labbumov.Size = new System.Drawing.Size(44, 19);
            this.labbumov.TabIndex = 4;
            this.labbumov.Text = "       ";
            // 
            // labedu1
            // 
            this.labedu1.AutoSize = true;
            this.labedu1.Font = new System.Drawing.Font("Nasalization", 18.75F, System.Drawing.FontStyle.Bold);
            this.labedu1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.labedu1.Location = new System.Drawing.Point(3, 6);
            this.labedu1.Name = "labedu1";
            this.labedu1.Size = new System.Drawing.Size(117, 22);
            this.labedu1.TabIndex = 5;
            this.labedu1.Text = "GAME D";
            // 
            // labplay
            // 
            this.labplay.AutoSize = true;
            this.labplay.Font = new System.Drawing.Font("Nasalization", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labplay.ForeColor = System.Drawing.Color.Crimson;
            this.labplay.Location = new System.Drawing.Point(115, 6);
            this.labplay.Name = "labplay";
            this.labplay.Size = new System.Drawing.Size(26, 22);
            this.labplay.TabIndex = 6;
            this.labplay.Text = "U";
            this.labplay.Click += new System.EventHandler(this.labplay_Click);
            // 
            // labedu2
            // 
            this.labedu2.AutoSize = true;
            this.labedu2.Font = new System.Drawing.Font("Nasalization", 18.75F, System.Drawing.FontStyle.Bold);
            this.labedu2.ForeColor = System.Drawing.Color.DarkMagenta;
            this.labedu2.Location = new System.Drawing.Point(147, 6);
            this.labedu2.Name = "labedu2";
            this.labedu2.Size = new System.Drawing.Size(67, 22);
            this.labedu2.TabIndex = 7;
            this.labedu2.Text = "KASI";
            // 
            // panedu
            // 
            this.panedu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panedu.Controls.Add(this.labplay);
            this.panedu.Controls.Add(this.labedu2);
            this.panedu.Controls.Add(this.labedu1);
            this.panedu.Location = new System.Drawing.Point(428, 233);
            this.panedu.Name = "panedu";
            this.panedu.Size = new System.Drawing.Size(230, 33);
            this.panedu.TabIndex = 8;
            // 
            // labcreate
            // 
            this.labcreate.AutoSize = true;
            this.labcreate.Font = new System.Drawing.Font("Nasalization", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labcreate.ForeColor = System.Drawing.Color.DarkBlue;
            this.labcreate.Location = new System.Drawing.Point(-112, 46);
            this.labcreate.Name = "labcreate";
            this.labcreate.Size = new System.Drawing.Size(123, 13);
            this.labcreate.TabIndex = 9;
            this.labcreate.Text = "Created By :  ";
            // 
            // labthanks
            // 
            this.labthanks.AutoSize = true;
            this.labthanks.Font = new System.Drawing.Font("Nasalization", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labthanks.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.labthanks.Location = new System.Drawing.Point(12, 46);
            this.labthanks.Name = "labthanks";
            this.labthanks.Size = new System.Drawing.Size(107, 13);
            this.labthanks.TabIndex = 10;
            this.labthanks.Text = "Thanks TO : ";
            this.labthanks.Visible = false;
            // 
            // labthanks02
            // 
            this.labthanks02.AutoSize = true;
            this.labthanks02.Font = new System.Drawing.Font("Nightclub BTN", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labthanks02.ForeColor = System.Drawing.Color.DarkCyan;
            this.labthanks02.Location = new System.Drawing.Point(135, 100);
            this.labthanks02.Name = "labthanks02";
            this.labthanks02.Size = new System.Drawing.Size(179, 18);
            this.labthanks02.TabIndex = 11;
            this.labthanks02.Text = "Icon By : Flat icon && icon8";
            this.labthanks02.Visible = false;
            // 
            // labthanks01
            // 
            this.labthanks01.AutoSize = true;
            this.labthanks01.Font = new System.Drawing.Font("Nightclub BTN", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labthanks01.ForeColor = System.Drawing.Color.Crimson;
            this.labthanks01.Location = new System.Drawing.Point(195, 120);
            this.labthanks01.Name = "labthanks01";
            this.labthanks01.Size = new System.Drawing.Size(105, 18);
            this.labthanks01.TabIndex = 12;
            this.labthanks01.Text = "ALL my Friends";
            this.labthanks01.Visible = false;
            // 
            // labthanks03
            // 
            this.labthanks03.AutoSize = true;
            this.labthanks03.Font = new System.Drawing.Font("Nightclub BTN", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labthanks03.ForeColor = System.Drawing.Color.DarkMagenta;
            this.labthanks03.Location = new System.Drawing.Point(195, 140);
            this.labthanks03.Name = "labthanks03";
            this.labthanks03.Size = new System.Drawing.Size(105, 18);
            this.labthanks03.TabIndex = 13;
            this.labthanks03.Text = "P. Fahrur Rozi";
            this.labthanks03.Visible = false;
            // 
            // labprog
            // 
            this.labprog.AutoSize = true;
            this.labprog.BackColor = System.Drawing.Color.Transparent;
            this.labprog.Font = new System.Drawing.Font("Permanent Marker", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labprog.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labprog.Location = new System.Drawing.Point(134, -19);
            this.labprog.Name = "labprog";
            this.labprog.Size = new System.Drawing.Size(73, 22);
            this.labprog.TabIndex = 14;
            this.labprog.Text = "Novan :P";
            // 
            // labthanks04
            // 
            this.labthanks04.AutoSize = true;
            this.labthanks04.Font = new System.Drawing.Font("Nightclub BTN", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labthanks04.ForeColor = System.Drawing.Color.DarkOrange;
            this.labthanks04.Location = new System.Drawing.Point(135, 100);
            this.labthanks04.Name = "labthanks04";
            this.labthanks04.Size = new System.Drawing.Size(165, 18);
            this.labthanks04.TabIndex = 15;
            this.labthanks04.Text = "SFx By : cloudfront.net";
            this.labthanks04.Visible = false;
            // 
            // movinglab
            // 
            this.movinglab.Enabled = true;
            this.movinglab.Interval = 55;
            this.movinglab.Tick += new System.EventHandler(this.movinglab_Tick);
            // 
            // labprog2
            // 
            this.labprog2.AutoSize = true;
            this.labprog2.BackColor = System.Drawing.Color.Transparent;
            this.labprog2.Font = new System.Drawing.Font("Permanent Marker", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labprog2.ForeColor = System.Drawing.Color.Gray;
            this.labprog2.Location = new System.Drawing.Point(134, 43);
            this.labprog2.Name = "labprog2";
            this.labprog2.Size = new System.Drawing.Size(52, 22);
            this.labprog2.TabIndex = 16;
            this.labprog2.Text = "Edo A";
            this.labprog2.Visible = false;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(660, 261);
            this.Controls.Add(this.labskor);
            this.Controls.Add(this.piccery);
            this.Controls.Add(this.picas);
            this.Controls.Add(this.picufo);
            this.Controls.Add(this.labcreate);
            this.Controls.Add(this.panedu);
            this.Controls.Add(this.labprog);
            this.Controls.Add(this.labprog2);
            this.Controls.Add(this.labthanks02);
            this.Controls.Add(this.labthanks);
            this.Controls.Add(this.labbumov);
            this.Controls.Add(this.labthanks04);
            this.Controls.Add(this.labthanks01);
            this.Controls.Add(this.labthanks03);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "About";
            this.Text = "About";
            this.Load += new System.EventHandler(this.About_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.About_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.About_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picufo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piccery)).EndInit();
            this.panedu.ResumeLayout(false);
            this.panedu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picas;
        private System.Windows.Forms.PictureBox picufo;
        private System.Windows.Forms.Timer movasteroid;
        private System.Windows.Forms.Timer movufo;
        private System.Windows.Forms.PictureBox piccery;
        private System.Windows.Forms.Label labskor;
        private System.Windows.Forms.Label labbumov;
        private System.Windows.Forms.Label labedu1;
        private System.Windows.Forms.Label labplay;
        private System.Windows.Forms.Label labedu2;
        private System.Windows.Forms.Panel panedu;
        private System.Windows.Forms.Label labcreate;
        private System.Windows.Forms.Label labthanks;
        private System.Windows.Forms.Label labthanks02;
        private System.Windows.Forms.Label labthanks01;
        private System.Windows.Forms.Label labthanks03;
        private System.Windows.Forms.Label labprog;
        private System.Windows.Forms.Label labthanks04;
        private System.Windows.Forms.Timer movinglab;
        private System.Windows.Forms.Label labprog2;
    }
}