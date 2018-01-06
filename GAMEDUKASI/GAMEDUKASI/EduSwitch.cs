using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAMEDUKASI
{
    public partial class EduSwitch : UserControl
    {
        public EduSwitch()
        {
            InitializeComponent();
        }
        bool checkis;
        private void picbuff_Click(object sender, EventArgs e)
        {
            if (checkis == true)
            {
                checkis = false;
            }
            else
            {
                if (checkis == false)
                {
                    checkis = true;
                }
            }
            nyala();
            EduSwcheck();
        }

        private void nyala()
        {
            if(checkis==true)
            {
                picbuff.Image = imlist.Images[0];
                lab_musix.Text = "Music Player Menyala :)";
            }
            else
            {
                if(checkis==false)
                {
                    picbuff.Image = imlist.Images[1];
                    lab_musix.Text = "Music Tidak Diputar :(";
                }
            }
            EduSwcheck();
        }
        public bool ischeck
        {
            get
            {
                return checkis;
            }
            set
            {
                EduSwcheck();
                checkis = value;
                nyala();
            }
        }
        public delegate void Chakis();
        public event Chakis icheck;
        protected virtual void EduSwcheck()
        {
            if (icheck != null)
            {
                icheck();
            }
        }
        private void EduSwitch_Load(object sender, EventArgs e)
        {
        }
    }
}
