namespace GAMEDUKASI
{
    partial class Eduset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eduset));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lab_musicplayed = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listsong = new System.Windows.Forms.ListView();
            this.imlist = new System.Windows.Forms.ImageList(this.components);
            this.swc = new GAMEDUKASI.EduSwitch();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.swc);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.listsong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 398);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(3, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "List Music :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.lab_musicplayed);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(677, 37);
            this.panel2.TabIndex = 1;
            // 
            // lab_musicplayed
            // 
            this.lab_musicplayed.AutoSize = true;
            this.lab_musicplayed.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_musicplayed.ForeColor = System.Drawing.Color.White;
            this.lab_musicplayed.Location = new System.Drawing.Point(106, 9);
            this.lab_musicplayed.Name = "lab_musicplayed";
            this.lab_musicplayed.Size = new System.Drawing.Size(106, 16);
            this.lab_musicplayed.TabIndex = 1;
            this.lab_musicplayed.Text = "No Music Played";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Playing Music : ";
            // 
            // listsong
            // 
            this.listsong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listsong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listsong.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listsong.Location = new System.Drawing.Point(6, 63);
            this.listsong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listsong.MultiSelect = false;
            this.listsong.Name = "listsong";
            this.listsong.Size = new System.Drawing.Size(444, 330);
            this.listsong.SmallImageList = this.imlist;
            this.listsong.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listsong.TabIndex = 0;
            this.listsong.UseCompatibleStateImageBehavior = false;
            this.listsong.View = System.Windows.Forms.View.List;
            this.listsong.SelectedIndexChanged += new System.EventHandler(this.listsong_SelectedIndexChanged);
            // 
            // imlist
            // 
            this.imlist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlist.ImageStream")));
            this.imlist.TransparentColor = System.Drawing.Color.Transparent;
            this.imlist.Images.SetKeyName(0, "Music_01.png");
            this.imlist.Images.SetKeyName(1, "Music_02.png");
            // 
            // swc
            // 
            this.swc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.swc.BackColor = System.Drawing.Color.Transparent;
            this.swc.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swc.ForeColor = System.Drawing.Color.White;
            this.swc.ischeck = true;
            this.swc.Location = new System.Drawing.Point(456, 64);
            this.swc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.swc.MaximumSize = new System.Drawing.Size(343, 58);
            this.swc.Name = "swc";
            this.swc.Size = new System.Drawing.Size(209, 44);
            this.swc.TabIndex = 4;
            this.swc.icheck += new GAMEDUKASI.EduSwitch.Chakis(this.swc_icheck);
            // 
            // Eduset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 398);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Eduset";
            this.Text = "Eduset";
            this.Load += new System.EventHandler(this.Eduset_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listsong;
        private EduSwitch swc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lab_musicplayed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imlist;
    }
}