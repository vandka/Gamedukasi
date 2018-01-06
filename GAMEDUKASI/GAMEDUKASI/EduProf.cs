using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace GAMEDUKASI
{
    public partial class EduProf : Form
    {
        public EduProf()
        {
            InitializeComponent();
        }
        int imcount;

        string connectku = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+Application.StartupPath+@"\Database\Base.accdb";

        private void ReadData()
        {
            listprofil.Items.Clear();
            OleDbConnection connection = new OleDbConnection(connectku);
            OleDbCommand cmd;
            connection.Open();
            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT User FROM Profile";//"SELECT * FROM profile"
                OleDbDataReader read = cmd.ExecuteReader();// Baca List User 
                while (read.Read())
                {
                    listprofil.Items.Add(read["User"].ToString());// Add User ke List
                }
                read.Close();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        private void Update()
        {
            OleDbConnection connection = new OleDbConnection(connectku);
            connection.Open();
            OleDbCommand cmd;
            try
            {
                //update.ExecuteNonQuery();

                 cmd = connection.CreateCommand();
                 cmd.CommandText = "UPDATE Profile  SET [User]='"+txprofil.Text+ "'," + "[ProfilePicture]='"+val+"' "+ "WHERE User='"+listprofil.SelectedItem.ToString()+"'";
                 cmd.ExecuteNonQuery();
                MessageBox.Show("Profil Di-Upgrade..");

            }
            catch (Exception en)
            {
                MessageBox.Show(en.ToString());//Error Diag
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    ReadData();
                    connection.Close();
                    pantwo.Visible = false;
                    panone.Visible = true;
                }
            }
        }

        private void Insert()
        {
            newuser = true;
            OleDbConnection connection = new OleDbConnection(connectku);
            OleDbCommand cmd;
            connection.Open();
            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT INTO Profile VALUES('" + txprofil.Text + "','" + val + "','0','0','0','0','0','0')";//"SELECT * FROM profile"
                cmd.ExecuteNonQuery();
                MessageBox.Show("Profil Dibuat..");
            }
            catch (Exception)
            {         
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    ReadData();
                    connection.Close();
                }
            }

        }
        private void EduProf_Load(object sender, EventArgs e)
        {         
            ReadData();
            imcount = imglist.Images.Count;
            picbuff.Image = imglist.Images[imgpic];
            picav.Image= imglist.Images[imgpic];
        }

        private void buranav_Click(object sender, EventArgs e)
        {
            
            Random ran = new Random();
            val = ran.Next(0, imcount);
            picav.Image = imglist.Images[val];
            
        }

        private void busav_Click(object sender, EventArgs e)
        {
           if(newuser==true)
            {
                Insert();
            }
           else
            {
                Update();
            }
            newuser = false;
            panone.Visible = true;
            pantwo.Visible = false;
        }
        int imgpic,val;
        private void buload_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(connectku);
            OleDbCommand cmd;
            connection.Open();
            if(listprofil.SelectedItem==null)
            {
                MessageBox.Show("Anda Belum memilih Profil di List..");
                return;
            }
            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * from Profile where User='" + listprofil.SelectedItem.ToString() + "'";//"SELECT * FROM profile"
                OleDbDataReader read = cmd.ExecuteReader();// Baca List User 
                while (read.Read())
                {
                    Educlass.proname = read["User"].ToString();
                    imgpic = Convert.ToInt32(read["ProfilePicture"]);
                    Educlass.Friz = Convert.ToInt32(read["Freeze"]);
                    Educlass.uang = Convert.ToInt32(read["Money"]);
                    Educlass.Next = Convert.ToInt32(read["Skip"]);
                    Educlass.health = Convert.ToInt32(read["Health"]);
                    Educlass.hint = Convert.ToInt32(read["Hint"]);
                    Educlass.proimg = imglist.Images[imgpic];
                }
            }
            catch(Exception)
            {

            }
        }

        private void budel_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(connectku);
            OleDbCommand cmd;
            connection.Open();
            try
            {

                cmd = connection.CreateCommand();
                cmd.CommandText = "DELETE FROM Profile WHERE USER='"+ listprofil.SelectedItem.ToString()+"'";//"SELECT * FROM profile"
                cmd.ExecuteNonQuery();
                listprofil.SelectedIndex = 0;
                MessageBox.Show("Profil Berhasil Dihapus..");
            }
            catch (Exception en)
            {
                MessageBox.Show(en.ToString());//Error Diag
            }
            finally
            {
                if(connection.State ==ConnectionState.Open)
                {
                    ReadData();
                    connection.Close();
                }
            }
        }
        bool newuser;
        private void buinsert_Click(object sender, EventArgs e)
        {
            panone.Visible = false;
            pantwo.Visible = true;
            newuser = true;
        }

        private void listprofil_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(connectku);
            OleDbCommand cmd;
            connection.Open();
            if (listprofil.SelectedItem == null)
            {
                MessageBox.Show("Anda Belum memilih Profil di List..");
                return;
            }
            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * from Profile where User='" + listprofil.SelectedItem.ToString() + "'";//"SELECT * FROM profile"
                OleDbDataReader read = cmd.ExecuteReader();// Baca List User 
                while (read.Read())
                {
                    imgpic = Convert.ToInt32(read["ProfilePicture"]);
                    picbuff.Image = imglist.Images[imgpic];
                }
            }
            catch (Exception)
            {

            }
        }

        private void bucan_Click(object sender, EventArgs e)
        {
            panone.Visible = true;
            pantwo.Visible = false;
        }

        private void buup_Click(object sender, EventArgs e)
        {
            if (listprofil.SelectedItem == null)
            {
                MessageBox.Show("Anda Belum memilih Profil di List..");
                return;
            }
            txprofil.Text = listprofil.SelectedItem.ToString();
            panone.Visible = false;
            pantwo.Visible = true;
        }
    }
}
