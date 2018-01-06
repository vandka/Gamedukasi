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
    public partial class EduMath : Form
    {
        public EduMath()
        {
            InitializeComponent();
        }
        string connectku = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\Database\Base.accdb";
        Educlass Edu = new Educlass();

        #region "Give Life"
        int life = 5;// Life Sesuai Sprites
        private void Lifecount(bool reset)
        {
            if (reset==false)
            {
                life--;// Kurangi Nyawa
                switch (life)//Update Nyawa Pada Sprites
                {
                    case 0:
                        pan_over.Visible = true;// Memunculkan Panel Game Over
                        pic_life.Width = 0;
                        tmr_bar.Dispose();//Hentikan Timer Bar
                        break;
                    case 1:
                        pic_life.Width = 25;
                        break;
                    case 2:
                        pic_life.Width = 49;
                        break;
                    case 3:
                        pic_life.Width = 73;
                        break;
                    case 4:
                        pic_life.Width = 97;
                        break;
                    case 5:
                        pic_life.Width = 120;
                        break;
                }
            }
            else
            {
                tmr_bar.Start();
                life = 5;
                pic_life.Width = 120;
            }

        }
        private void bu_retry_Click(object sender, EventArgs e)
        {
            pan_over.Visible = false;
            Lifecount(true);
        }

        #endregion

        #region "SOAL"
        string SOALOP,Jawaban;
        private void BeriSoal()
        {
           int SO1,SO2;// Soal Temp
           //================================= RANdom Soal
           Random Soal = new Random();
           Random SoalOperate = new Random();
          //================================== VALUE SOal Min & MAX
           SO1= Soal.Next(0, 100);
           SO2= Soal.Next(0, 100);
         //=================================== Random Operator Kalkulasi + Jawaban
           switch(SoalOperate.Next(0, 3))
            {
                case 0:
                    SOALOP = " + ";
                    Jawaban = Convert.ToString(SO1 + SO2);
                    break;
                case 1:
                    SOALOP = " - ";
                    Jawaban = Convert.ToString(SO1 - SO2);
                    break;
                case 2:
                    SOALOP = " X ";
                    Jawaban = Convert.ToString(SO1 * SO2);
                    break;
                case 3:
                    SOALOP = " : ";
                    Jawaban = Convert.ToString(SO1 / SO2);
                    break;

            }
            //================================== To Textbox
            txtsoal.Text = Convert.ToString(SO1)+SOALOP+Convert.ToString(SO2);
        
        }
        #endregion

        #region "CHALLANGE"
        int call, timechallange;
        private void Challange()
        {
            Random Ttc = new Random();
            call = Ttc.Next(1, 50);//Random Kemungkinan Challange 1 - 50
            Random timecha = new Random();
            timechallange = timecha.Next(10, 20); //Random Waktu Challange
            //=================== POLICE LINE =====================
            if (call <= 10)// Kemungkinan Mendapatkan Soal Challange 10/50
            {
                tmr_challange.Start();
                Edu.EduMusic(Application.StartupPath + @"\Data\SFX\Bonus_Level.wav", true);
                lab_tmr.Visible = true;
                lab_challange.Text = "Answer Under " + Convert.ToString(timechallange) + " second";
                tmr_bar.Dispose();//Hentikan Waktu Progressbar Ketika Challange
            }
            else
            {
                timechallange = 0; //Reset Waktu Challange
                lab_tmr.Visible = false;
                lab_challange.Text = "No Challange Yet !! Keep Focus..";
            }
        }
        private void tmr_challange_Tick(object sender, EventArgs e)
        {
            if (timechallange <= 0)
            {
                lab_tmr.Visible = false;
                lab_challange.Text = "No Challange Yet !! Keep Focus..";
                tmr_challange.Dispose();//Disable Challange Timer
                Edu.EduMusic(Application.StartupPath + @"\Data\Music\"+Educlass.loadlastmusic, true);
                tmr_bar.Start();
            }
            else
            {
                timechallange--;
                var time = TimeSpan.FromSeconds(timechallange);
                lab_tmr.Text = "00:" + time.ToString("ss");
            }
        }
        #endregion

        #region "DATAMOD"
        int score;
        private void LoadData()
        {
            lab_freeze.Text = Convert.ToString(Educlass.Friz);
            lab_medic.Text  = Convert.ToString(Educlass.health);
            lab_money.Text  = Convert.ToString(Educlass.uang);
            lab_next.Text   = Convert.ToString(Educlass.Next);
        }
        #endregion
       

        private void EduMath_Load(object sender, EventArgs e)
        {
            LoadData();//
        }

        private void tmr_Ranso_Tick(object sender, EventArgs e)
        {
            BeriSoal();         
        }

        private void bu_stopit_Click(object sender, EventArgs e)
        {
            tmr_Ranso.Dispose();
            bu_stopit.Visible = false;
            txtjawab.Focus();
            tmr_bar.Start();
        }

        private void bu_next_Click(object sender, EventArgs e)
        {
            if(Educlass.Next>0)
            {
                Educlass.Next--;
                BeriSoal();
                lab_next.Text = Convert.ToString(Educlass.Next);
            }
            else
            {
                bu_next.Enabled = false;
            }
            Educlass.SavedData(connectku, Educlass.proname);
        }

        private void Medical(int x)
        {
            switch(x)
            {
                case 1:
                    life = 2;// +1 Lives
                    pic_life.Width = 49;
                    break;
                case 2:
                     life = 3;
                    pic_life.Width = 73;
                    break;
                case 3:
                    life = 4;
                    pic_life.Width = 97;
                    break;
                case 4:
                    life = 5;
                    pic_life.Width = 120;
                    break;       
            }
        }

        private void bu_medic_Click(object sender, EventArgs e)
        {
            if (Educlass.health> 0)
            {
                Educlass.health--;
                Medical(life);
                lab_medic.Text = Convert.ToString(Educlass.health);
            }
            else
            {
                bu_medic.Enabled = false;
            }
            Educlass.SavedData(connectku, Educlass.proname);
        }

        private void bu_main_Click(object sender, EventArgs e)
        {
           
        }

        private void txtjawab_TextChanged(object sender, EventArgs e)
        {
            if(txtjawab.Text==Jawaban)
            {
                BeriSoal();
                txtjawab.Clear();
                pbar.Value = pbar.Maximum;//Reset progressbar
                score += 2;
                lab_score.Text = Convert.ToString(score);
                if (lab_challange.Text != "No Challange Yet.. Keep Focus !!")
                {
                    Educlass.uang += timechallange * 2;
                    lab_money.Text = Convert.ToString(Educlass.uang);
                    Educlass.SavedData(connectku, Educlass.proname);
                }
                Challange();
            }
        }

      

        private void tmr_bar_Tick(object sender, EventArgs e)
        {
            if(pbar.Value!=pbar.Minimum)
            {
                pbar.Value--;
            }
            else
            {
                Lifecount(false);// Kurangi nyawa bila Value Pbar Habis
                pbar.Value = pbar.Maximum;//Reset Pbar
            }
        }
        private void bu_freeze_Click(object sender, EventArgs e)
        {
            if (Educlass.Friz> 0)
            {
                Educlass.Friz--;
                tmr_freeze.Start();
                bu_freeze.Enabled = false;
                lab_freeze.Text = Convert.ToString(Educlass.Friz);
            }
            else
            {
                bu_freeze.Enabled = false;
                tmr_freeze.Dispose();
            }
            Educlass.SavedData(connectku, Educlass.proname);
        }
        int timefreeze = 3;
        private void tmr_freeze_Tick(object sender, EventArgs e)
        {
            this.Text = Convert.ToString(timefreeze);
            if (timefreeze != 0)
            {
                timefreeze--;
                tmr_bar.Dispose();
            }
            else
            {
                tmr_freeze.Dispose();
                bu_freeze.Enabled = true;
                tmr_bar.Start();//Memlai TimerBar Jika Waktu Freeze Habis
                timefreeze = 3;// Reset Time Freeze
            }
        }

    }
}
