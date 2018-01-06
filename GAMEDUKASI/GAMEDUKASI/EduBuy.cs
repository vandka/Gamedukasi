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
    public partial class EduBuy : Form
    {
        public EduBuy()
        {
            InitializeComponent();
        }
        string connectku = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\Database\Base.accdb";
        private void Beliapa(string barang,int harga)
        {

            if(Educlass.uang<harga)
            {
                labshop.Text = "UANG TIDAK CUKUP";
            }
            else
            {
              switch(barang)
                {
                    case "freeze":
                        Educlass.Friz++;
                        labshop.Text = "Total Freeze :" + Educlass.Friz;
                        Educlass.uang = Educlass.uang - harga;   
                        break;
                    case "hint":
                        Educlass.hint++;
                        labshop.Text = "Total Hint :" + Educlass.hint;
                        Educlass.uang = Educlass.uang - harga;
                        break;
                    case "skip":
                        Educlass.Next++;
                        labshop.Text = "Total Skip :" + Educlass.Next;
                        Educlass.uang = Educlass.uang - harga;
                        break;
                    case "heal":
                        Educlass.health++;
                        labshop.Text = "Total Heal :" + Educlass.health;
                        Educlass.uang = Educlass.uang - harga;
                        break;
                }

            }
            lab_money.Text = Convert.ToString(Educlass.uang);
            Educlass.SavedData(connectku, Educlass.proname);
        }
          
        private void bu_buyfreeze_Click(object sender, EventArgs e)
        {
            Beliapa("freeze",50);
        }

        private void EduBuy_Load(object sender, EventArgs e)
        {
            lab_money.Text = Convert.ToString(Educlass.uang);
        }

        private void bu_buyhint_Click(object sender, EventArgs e)
        {
            Beliapa("hint", 75);
        }

        private void bu_buyskip_Click(object sender, EventArgs e)
        {
            Beliapa("skip", 70);
        }

        private void bu_buyhealth_Click(object sender, EventArgs e)
        {
            Beliapa("heal", 150);
        }
    }
}
