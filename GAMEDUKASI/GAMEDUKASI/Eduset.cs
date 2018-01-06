using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAMEDUKASI
{
    public partial class Eduset : Form
    {
        public Eduset()
        {
            InitializeComponent();
        }
        Educlass edu = new Educlass();
        private void Loadmusic()
        {
            listsong.Items.Clear();
            string[] list = Directory.GetFiles(Application.StartupPath + @"\Data\Music");
            foreach (string file in list)
            {
                //

                listsong.Items.Add(Path.GetFileName(file), 0);
            }
        }
        private void Eduset_Load(object sender, EventArgs e)
        {
            Loadmusic();
            swc.ischeck = Educlass.musicplay;
            lab_musicplayed.Text = Educlass.loadlastmusic;
        }

        private void listsong_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // int hitungpanjangstring = listsong.SelectedItems[0].Text.Length;//Hitung Panjang String
                string file = listsong.SelectedItems[0].Text;
                edu.EduMusic(Application.StartupPath + @"\Data\Music\" + file, true);
                Educlass.loadlastmusic = file;
                lab_musicplayed.Text = file;
            }
            catch (Exception)
            {
                return;
            }
        }

        private void swc_icheck()
        {
            try
            {
                if (swc.ischeck == true)
                {
                    edu.EduMusic(Application.StartupPath + @"\Data\Music\" + lab_musicplayed.Text, true);
                    listsong.Enabled = true;
                    lab_musicplayed.Visible = true;
                    Educlass.musicplay = true;
                }
                else
                {
                    edu.EduMusic(Application.StartupPath + @"\Data\Music\" + lab_musicplayed.Text, false);
                    listsong.Enabled = false;
                    lab_musicplayed.Visible = false;
                    Educlass.musicplay = false;
                }
            }
            catch (Exception)
            {

            }
            this.Text = swc.ischeck + "";
        }
    }
}
