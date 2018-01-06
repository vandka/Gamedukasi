namespace GAMEDUKASI
{
    partial class EduLaunch
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
            this.panup = new System.Windows.Forms.Panel();
            this.lilabuy = new System.Windows.Forms.LinkLabel();
            this.lab_ver = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lopan = new System.Windows.Forms.Panel();
            this.timinload = new System.Windows.Forms.Timer(this.components);
            this.panmain = new GAMEDUKASI.EduPAN();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panup
            // 
            this.panup.BackColor = System.Drawing.Color.Indigo;
            this.panup.Controls.Add(this.pictureBox1);
            this.panup.Controls.Add(this.lilabuy);
            this.panup.Controls.Add(this.lab_ver);
            this.panup.Controls.Add(this.label1);
            this.panup.Dock = System.Windows.Forms.DockStyle.Top;
            this.panup.Location = new System.Drawing.Point(0, 0);
            this.panup.Name = "panup";
            this.panup.Size = new System.Drawing.Size(778, 55);
            this.panup.TabIndex = 0;
            // 
            // lilabuy
            // 
            this.lilabuy.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.lilabuy.AutoSize = true;
            this.lilabuy.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lilabuy.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lilabuy.LinkColor = System.Drawing.Color.White;
            this.lilabuy.Location = new System.Drawing.Point(729, 27);
            this.lilabuy.Name = "lilabuy";
            this.lilabuy.Size = new System.Drawing.Size(37, 16);
            this.lilabuy.TabIndex = 2;
            this.lilabuy.TabStop = true;
            this.lilabuy.Text = "Store";
            this.lilabuy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lilabuy_LinkClicked);
            // 
            // lab_ver
            // 
            this.lab_ver.AutoSize = true;
            this.lab_ver.BackColor = System.Drawing.Color.Transparent;
            this.lab_ver.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_ver.ForeColor = System.Drawing.Color.White;
            this.lab_ver.Location = new System.Drawing.Point(147, 0);
            this.lab_ver.Name = "lab_ver";
            this.lab_ver.Size = new System.Drawing.Size(27, 16);
            this.lab_ver.TabIndex = 1;
            this.lab_ver.Text = "ver";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gamedukasi";
            // 
            // lopan
            // 
            this.lopan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lopan.Location = new System.Drawing.Point(246, 55);
            this.lopan.Name = "lopan";
            this.lopan.Size = new System.Drawing.Size(532, 397);
            this.lopan.TabIndex = 2;
            // 
            // timinload
            // 
            this.timinload.Enabled = true;
            this.timinload.Tick += new System.EventHandler(this.timinload_Tick);
            // 
            // panmain
            // 
            this.panmain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panmain.Dock = System.Windows.Forms.DockStyle.Left;
            this.panmain.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panmain.gambarprofil = global::GAMEDUKASI.Properties.Resources.boy;
            this.panmain.gamemode = "Edu MATH";
            this.panmain.Location = new System.Drawing.Point(0, 55);
            this.panmain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panmain.Name = "panmain";
            this.panmain.profile = "";
            this.panmain.Size = new System.Drawing.Size(246, 397);
            this.panmain.TabIndex = 1;
            this.panmain.uangku = 0;
            this.panmain.PlayClicks += new GAMEDUKASI.EduPAN.Playclick(this.panmain_PlayClicks);
            this.panmain.ProfileClicks += new GAMEDUKASI.EduPAN.ProfileClick(this.panmain_ProfileClicks);
            this.panmain.SettingClicks += new GAMEDUKASI.EduPAN.SettingClick(this.panmain_SettingClicks);
            this.panmain.AboutClicks += new GAMEDUKASI.EduPAN.SettingClick(this.panmain_AboutClicks);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GAMEDUKASI.Properties.Resources.cart02;
            this.pictureBox1.Location = new System.Drawing.Point(699, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // EduLaunch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(778, 452);
            this.Controls.Add(this.lopan);
            this.Controls.Add(this.panmain);
            this.Controls.Add(this.panup);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(794, 491);
            this.MinimumSize = new System.Drawing.Size(794, 491);
            this.Name = "EduLaunch";
            this.Text = " ";
            this.Load += new System.EventHandler(this.EduLaunch_Load);
            this.panup.ResumeLayout(false);
            this.panup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panup;
        private System.Windows.Forms.Label lab_ver;
        private System.Windows.Forms.Label label1;
        private EduPAN panmain;
        private System.Windows.Forms.Panel lopan;
        private System.Windows.Forms.LinkLabel lilabuy;
        private System.Windows.Forms.Timer timinload;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

