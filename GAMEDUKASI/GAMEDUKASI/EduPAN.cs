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
    public partial class EduPAN : UserControl
    {
        public EduPAN()
        {
            InitializeComponent();
        }

        string prof;
        int uang;
        Image gambar;
        private void Resetcolor(int panel)
        {
            switch (panel)
            {
                case 1:
                    pan_play.BackColor = p1.BackColor;
                    pan_prof.BackColor = panmenu.BackColor;
                    pan_sett.BackColor = panmenu.BackColor;
                    pan_abot.BackColor = panmenu.BackColor;
                    break;
                case 2:
                    pan_play.BackColor = panmenu.BackColor;
                    pan_prof.BackColor = p2.BackColor;
                    pan_sett.BackColor = panmenu.BackColor;
                    pan_abot.BackColor = panmenu.BackColor;
                    break;
                case 3:
                    pan_play.BackColor = panmenu.BackColor;
                    pan_prof.BackColor = panmenu.BackColor;
                    pan_sett.BackColor = p3.BackColor;
                    pan_abot.BackColor = panmenu.BackColor;
                    break;
                case 4:
                    pan_play.BackColor = panmenu.BackColor;
                    pan_prof.BackColor = panmenu.BackColor;
                    pan_sett.BackColor = panmenu.BackColor;
                    pan_abot.BackColor = p4.BackColor;
                    break;
            }
        }

        private void lab_play_Click(object sender, EventArgs e)
        {
            Resetcolor(1);
            PanPlayClick();
        }

        private void lab_prof_Click(object sender, EventArgs e)
        {
            Resetcolor(2);
            PanProfileClick();
        }

        private void lab_sett_Click(object sender, EventArgs e)
        {
            Resetcolor(3);
            PanSettingClick();
        }

        private void lab_abot_Click(object sender, EventArgs e)
        {
            Resetcolor(4);
            PanAboutClick();
        }

        public delegate void Playclick();
        public event Playclick PlayClicks;

        protected virtual void PanPlayClick()
        {
            if (PlayClicks != null)
            {
                PlayClicks();
            }
        }

        public delegate void ProfileClick();
        public event ProfileClick ProfileClicks;
        protected virtual void PanProfileClick()
        {
            if (ProfileClicks != null)
            {
                ProfileClicks();
            }
        }

        public delegate void SettingClick();
        public event SettingClick SettingClicks;
        protected virtual void PanSettingClick()
        {
            if (SettingClicks != null)
            {
                SettingClicks();
            }
        }

        public delegate void AboutClick();
        public event SettingClick AboutClicks;
        protected virtual void PanAboutClick()
        {
            if (AboutClicks != null)
            {
                AboutClicks();
            }
        }

        public string profile
        {
            get
            {
                return prof;
            }
            set
            {
                prof = value;
                lab_profil.Text = prof;
            }
        }

        public int uangku
        {
            get
            {
                return uang;
            }
            set
            {
                uang = value;
                lab_uang.Text = Convert.ToString(uang);
            }
        }

        public Image gambarprofil
        {
            get
            {
                return gambar;
            }
            set
            {
                gambar = value;
                pic_profil.Image = gambar;
            }
        }
        string gmod= "Edu MATH";
        public string gamemode
        {
            get
            {
                return gmod;
            }
            set
            {
                gmod = value;
            }
        }
        private void link_gamemode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           if(link_gamemode.Text== "Edu MATH")
            {
                gmod= "Edu What'is it";
                link_gamemode.Text = "Edu What'is it";
            }
           else
            {
                gmod= "Edu MATH";
                link_gamemode.Text = "Edu MATH";
            }
        }

        private void panmenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
