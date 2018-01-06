namespace GAMEDUKASI
{
    partial class EduSwitch
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EduSwitch));
            this.imlist = new System.Windows.Forms.ImageList(this.components);
            this.picbuff = new System.Windows.Forms.PictureBox();
            this.lab_musix = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbuff)).BeginInit();
            this.SuspendLayout();
            // 
            // imlist
            // 
            this.imlist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlist.ImageStream")));
            this.imlist.TransparentColor = System.Drawing.Color.Transparent;
            this.imlist.Images.SetKeyName(0, "switch_style2_on.ico");
            this.imlist.Images.SetKeyName(1, "switch_style2_off.ico");
            this.imlist.Images.SetKeyName(2, "switch_style1_on.ico");
            this.imlist.Images.SetKeyName(3, "switch_style1_off.ico");
            this.imlist.Images.SetKeyName(4, "switch_style3_on.ico");
            this.imlist.Images.SetKeyName(5, "switch_style3_off.ico");
            // 
            // picbuff
            // 
            this.picbuff.BackColor = System.Drawing.Color.Transparent;
            this.picbuff.Location = new System.Drawing.Point(2, 2);
            this.picbuff.Name = "picbuff";
            this.picbuff.Size = new System.Drawing.Size(64, 38);
            this.picbuff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picbuff.TabIndex = 0;
            this.picbuff.TabStop = false;
            this.picbuff.Click += new System.EventHandler(this.picbuff_Click);
            // 
            // lab_musix
            // 
            this.lab_musix.AutoSize = true;
            this.lab_musix.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_musix.Location = new System.Drawing.Point(63, 11);
            this.lab_musix.Name = "lab_musix";
            this.lab_musix.Size = new System.Drawing.Size(148, 16);
            this.lab_musix.TabIndex = 1;
            this.lab_musix.Text = "Music Player Menyala :)";
            // 
            // EduSwitch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lab_musix);
            this.Controls.Add(this.picbuff);
            this.MaximumSize = new System.Drawing.Size(294, 44);
            this.Name = "EduSwitch";
            this.Size = new System.Drawing.Size(230, 44);
            this.Load += new System.EventHandler(this.EduSwitch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbuff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbuff;
        private System.Windows.Forms.ImageList imlist;
        private System.Windows.Forms.Label lab_musix;
    }
}
