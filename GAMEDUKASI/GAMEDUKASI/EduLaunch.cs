using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAMEDUKASI
{
    public partial class EduLaunch : Form
    {
        public EduLaunch()
        {
            InitializeComponent();
        }
        string connectku = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\Database\Base.accdb";

        Educlass edu = new Educlass();
        int money = Educlass.uang;
        int freeze = Educlass.Friz;
        Image profil = Educlass.proimg;
        private void LoadData()
        {
            panmain.gambarprofil = profil;
            panmain.uangku = money;
            panmain.profile="";
            lab_ver.Text = ProductVersion;
        }
        private void EduLaunch_Load(object sender, EventArgs e)
        {
            LoadData();           
        }
    bool gameload;
        private void LoadForm(Form frm)
        {
            if(gameload==true)
            {
                gameload = false;
                //SAVE DATA SAAT FORM DIGANTI
            }
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.WindowState = FormWindowState.Maximized;
            frm.Dock = DockStyle.Fill;
            lopan.Controls.Add(frm);
            frm.Show();
            Educlass.SavedData(connectku, Educlass.proname);
        }
        private void panmain_PlayClicks()
        {
           
            if (panmain.gamemode == "Edu MATH")
            {
                LoadForm(new EduMath()); // Set frm menjadi EduMath Form
            }
            else
            {
                if (panmain.gamemode == "Edu What'is it")
                {
                    LoadForm(new Edutamb());// Set frm menjadi Edutamb Form
                }
            }   
            gameload = true;
        }

        private void panmain_SettingClicks()
        {
            LoadForm(new Eduset());
        }

        private void lilabuy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadForm(new EduBuy());
        }

        private void timinload_Tick(object sender, EventArgs e)
        {
            panmain.uangku = Educlass.uang;
            panmain.profile = Educlass.proname;
            panmain.gambarprofil = Educlass.proimg;
        }

        private void panmain_AboutClicks()
        {
            LoadForm(new About());
        }

        private void panmain_ProfileClicks()
        {
            LoadForm(new EduProf());
        }
    }
}
