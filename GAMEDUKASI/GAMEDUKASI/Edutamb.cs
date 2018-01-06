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
    public partial class Edutamb : Form
    {
        public Edutamb()
        {
            InitializeComponent();
        }
        Educlass edu = new Educlass();
        string jawaban;
        int random;
        #region "DATAMOD"
        private void LoadData()
        {
            lab_next.Text = Convert.ToString(Educlass.Next);
            lab_hint.Text = Convert.ToString(Educlass.hint);
            PicLoad();
            Acakgambar();
        }

        private void PicLoad()
        {
            string[] list = Directory.GetFiles(Application.StartupPath + @"\Data\RES");
            foreach (string file in list)
            {
                Image imgtoadd = Image.FromFile(file); //Ambil File Gambar
                imgtoadd.Tag = file.ToString(); // ADD Tag Pada Gambar..
                impic.Images.Add(Path.GetFileName(file), imgtoadd);// Load Image Pada ImageList

            }
        }


        #endregion 

        int life=5;
        private void Lifecount()
        {
                life--;// Kurangi Nyawa
                switch (life)//Update Nyawa Pada Sprites
                {
                    case 0:
                        pan_over.Visible = true;// Memunculkan Panel Game Over
                        piclife.Width = 0;
                        break;
                    case 1:
                        piclife.Width = 25;
                        break;
                    case 2:
                        piclife.Width = 49;
                        break;
                    case 3:
                        piclife.Width = 73;
                        break;
                    case 4:
                        piclife.Width = 97;
                        break;
                    case 5:
                        piclife.Width = 120;
                        break;
                }
        }

        private void Edutamb_Load(object sender, EventArgs e)
        {
            LoadData();//Load Semua Resource :)          
        }

        int skor;
        private void Jawabsama()
        {
            string jwb = txtjawab.Text;
            if(jwb=="")
            {
                lab_statusjwb.Text = "JAWAB DONG AH !!";
            }
            else
            {
                if (jwb == jawaban)
                {
                    lab_statusjwb.Text = "BENAR ";
                    skor += 2;
                    Acakgambar();
                    txtjawab.Clear();// Hapus Jawaban
                }  
                else
                {
                    if (jwb.Contains(jawaban))
                    {
                        lab_statusjwb.Text = "Hampir Benar";

                    }
                    else
                    {
                        if (jwb != jawaban)
                        {
                            lab_statusjwb.Text = "SALAH";
                            Lifecount();
                            this.Text = Convert.ToString(life);
                        }
                       
                    }
                }
            }
            timstatus.Start();         
        }
        private void bucek_Click(object sender, EventArgs e)
        {
           
            Jawabsama();
        }
        private void Hint()
        {
            // Note.. String Jangan Smpai Sama 1 & 2 Karana Akan +1 String _
            try
            {
                StringBuilder sb = new StringBuilder(jawaban);
                int panstring = sb.Length;
                int valstring;
                Random newstring = new Random();
                Random newstring2 = new Random();
                valstring = newstring.Next(0, 3);

                string myString = sb
                .Replace(Convert.ToString(sb[valstring]), " _ ")
                .ToString();
                lab_statusjwb.Text = myString;
                timpass.Start();
            }
            catch
            {

            }


        }
        private void Acakgambar()
        {
            int max = impic.Images.Count;// Hitung Jumlah Max Picture Pada ImageList
            Random pic = new Random();
            random = pic.Next(0, max);
            picbuff.Image = impic.Images[random];
            string x = impic.Images.Keys[random].ToString();
            int hitungpanjangstring = x.Length;//Hitung Panjang String
            jawaban = x.Remove(hitungpanjangstring - 4);
        }
        private void buhint_Click(object sender, EventArgs e)
        {
            if(Educlass.hint!= 0)
            {
                Hint();
                Educlass.hint--;
                lab_hint.Text = Convert.ToString(Educlass.hint);
            }
            else
            {
                buhint.Enabled = false;
            }
        }

        private void timpass_Tick(object sender, EventArgs e)
        {
            lab_statusjwb.Text = "";
            timpass.Dispose();
        }

        private void buskip_Click(object sender, EventArgs e)
        {
            if(Educlass.Next> 0)
            {
                Acakgambar();
                Educlass.Next--;
                lab_next.Text = Convert.ToString(Educlass.Next);
            }
            else
            {
                buskip.Enabled = false;
            }
        }

        private void timstatus_Tick(object sender, EventArgs e)
        {
            lab_statusjwb.Text = "";
            lab_skor.Text = Convert.ToString(skor);
            timstatus.Dispose();
        }

        private void bu_retry_Click(object sender, EventArgs e)
        {
            life = 5;
            Lifecount();
            pan_over.Visible = false;
            Acakgambar();
        }
    }
}
