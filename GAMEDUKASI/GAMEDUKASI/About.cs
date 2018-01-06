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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }
        #region"MovingLabel"
        private void movinglab_Tick(object sender, EventArgs e)
        {
            if(panedu.Location.Y!=0)
            {
               panedu.Location = new Point(panedu.Location.Y, panedu.Location.Y - 1);
            }
            else
            {
                if (labcreate.Location.X != 10)
                {
                    labcreate.Location = new Point(labcreate.Location.X + 1, labcreate.Location.Y);
                }
                else
                {
                    if (labprog.Location.Y != 43)
                    {
                        labprog.Location = new Point(labprog.Location.X, labprog.Location.Y + 1);
                        
                    }
                    else
                    {
                        labprog2.Visible = true;
                        if (labprog2.Location.Y<60)
                        {
                            labprog2.Location = new Point(labprog2.Location.X, labprog2.Location.Y + 1);
                        }
                        else
                        {
                            labthanks.Visible = true;
                            if(labthanks.Location.Y!=100)
                            {
                                labthanks.Location = new Point(labthanks.Location.X, labthanks.Location.Y + 1);
                            }
                            else
                            {
                                labthanks02.Visible = true;
                                labthanks04.Visible = true;
                                if(labthanks04.Location.Y !=120)
                                {
                                    labthanks04.Location = new Point(labthanks04.Location.X, labthanks04.Location.Y + 1);
                                }
                                else
                                {
                                    labthanks01.Visible = true;
                                    if(labthanks01.Location.Y!=140)
                                    {
                                        labthanks01.Location = new Point(labthanks01.Location.X, labthanks01.Location.Y + 1);
                                    }
                                    else
                                    {
                                        labthanks03.Visible = true;
                                       if(labthanks03.Location.Y!=160)
                                        {
                                            labthanks03.Location = new Point(labthanks03.Location.X, labthanks03.Location.Y + 1);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
          

      
        }
        #endregion


        private void randcery()
        {
            int x, y;
            Random xx = new Random();
            Random yy = new Random();
           x= xx.Next(5, this.ClientSize.Width-50);
           y= yy.Next(5, this.ClientSize.Height-50);
            piccery.Location = new Point(x, y);
        }

        private void movasteroid_Tick(object sender, EventArgs e)
        {
            int x = picas.Location.X;
            int y = picas.Location.Y;
            int x2 = picufo.Location.X + 1;
            int y2 = picufo.Location.Y + 1;
            if(picufo.Bounds.IntersectsWith(piccery.Bounds))
            {
                skor += 1;
                randcery();
                labskor.Text ="Skor : "+ skor;
            }
            if (picufo.Bounds.IntersectsWith(picas.Bounds))
            {
                labedu1.Text = "GAME -";
                labedu2.Text = "OVER";
                movufo.Dispose();
            }
            else
            {
                if (x < picufo.Location.X)
                {
                    picas.Location = new Point(picas.Location.X + 1, picas.Location.Y);
                }
                if (y < picufo.Location.Y)
                {
                    picas.Location = new Point(picas.Location.X, picas.Location.Y + 1);
                }
                if (x > picufo.Location.X)
                {
                    picas.Location = new Point(picas.Location.X - 1, picas.Location.Y);
                }
                if (y > picufo.Location.Y)
                {
                    picas.Location = new Point(picas.Location.X, picas.Location.Y - 1);
                }
            }
            this.Text = "UFO = X" + Convert.ToString(picufo.Location.X) + "- Y " + Convert.ToString(picufo.Location.Y)+" MET X "+ Convert.ToString(picas.Location.X) + "- Y " + Convert.ToString(picas.Location.Y);

        }

        private void About_Load(object sender, EventArgs e)
        {

        }
        int skor,movx, movy;
        int maxX, maxY;//Maximum Location pada form ..

        private void movufo_Tick(object sender, EventArgs e)
        {
            maxX = this.Size.Width - picufo.Width;
            maxY = this.Size.Height - picufo.Height-5;
            if (picufo.Location.X < 0)
            {
                picufo.Location = new Point(maxX, picufo.Location.Y);
            }      
            else
            {
                if(picufo.Location.Y<0)
                {
                   picufo.Location = new Point(picufo.Location.X, maxY);
                }
                else
                {
                    if (picufo.Location.X > maxX)
                    {
                        picufo.Location = new Point(0, picufo.Location.Y);
                    }
                    else
                    {
                        if (picufo.Location.Y > maxY)
                        {
                            picufo.Location = new Point(picufo.Location.X, 0);
                        }
                        else
                        {
                            picufo.Location = new Point(picufo.Location.X + movx, picufo.Location.Y + movy);
                        }
                    }
                }
            }    
        }
        int ticktok = 3;
        private void labplay_Click(object sender, EventArgs e)
        {
            if(ticktok>0)
            {
                ticktok--;
            }
            else
            {
                randcery();
                labplay.Visible = false;
                movasteroid.Start();
                movufo.Start();
            }
        }



        private void About_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyData==Keys.A)
            {
                movx = 0;
            }
            if(e.KeyData==Keys.D)
            {
                movx = 0;
            }    
            if(e.KeyData==Keys.W)
            {
                movy = 0;
            }        
            if(e.KeyData==Keys.S)
            {
                movy = 0;
            }
            labbumov.Text = "";
        }

        private void About_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.A)
            {
                movx -= 1;
            }
            if (e.KeyData == Keys.D)
            {
                movx += 1;
            }
            if (e.KeyData == Keys.W)
            {
                movy -= 1;
            }
            if (e.KeyData == Keys.S)
            {
                movy += 1;
            }
            labbumov.Text = e.KeyData.ToString();
        }
    }
}
