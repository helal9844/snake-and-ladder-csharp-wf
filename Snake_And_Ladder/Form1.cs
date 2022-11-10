using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_And_Ladder
{
    public partial class Form1 : Form
    {
        int flag = 0;
        int sec = 0;
        bool red = false, green = false;
        int x = 24, y = 518, dicevalue, p = 0;
        int Bx = 24, By = 518, q = 0;

        private void label9_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void DIce_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labeldisable();
            /* disable other button*/
            if (flag == 0)
            {
                button2.Enabled = false;
                label1.BackColor = System.Drawing.Color.Red;
            }

            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            /* back image*/
            pictureBox3.Image = Image.FromFile(@"imgs\bkj.jpg");
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            /*Point Position*/   
            dicevalue = Logical.Rolldice(pictureBox3);
            DIce.Text = dicevalue.ToString();
            /*Dice value for red enable*/
            if (red == true)
            {
                p = Logical.move(ref x, ref y, p, dicevalue, pictureBox4, label9);
                label8.Text = p.ToString();
            }
            //*Red disable*/
            if (DIce.Text == "6" && red == false)
            {
                pictureBox4.Visible = true;
                pictureBox1.Visible = false;
                red = true;
                pictureBox4.Location = new Point(x, y);
                label4.Text = x.ToString();
                label6.Text = y.ToString();
                label8.Text = p.ToString();
                p++;

            }
            //*Red win check*/
            if (p == 100)
            {
                MessageBox.Show("Winner #RED# !");
                button1.Enabled = false;
            }
            p = Logical.snake(ref x, ref y, p, pictureBox4);
            p = Logical.lader(ref x, ref y, p, pictureBox4);
            label8.Text = p.ToString();

            //*button accecabilty*/
            if (dicevalue == 6)
            {
                flag = 0;

            }
            else
            {
                flag = 1;
                button1.Enabled = false;
                button2.Enabled = true;
            }
            label1.BackColor = System.Drawing.Color.Green;
            label1.Text = "Player 2";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            /*Point Position*/
            dicevalue = Logical.Rolldice(pictureBox3);
            DIce.Text = dicevalue.ToString();
            /*Dice value for Green enable*/
            if (green == true)
            {
                q = Logical.move(ref Bx, ref By, q, dicevalue, pictureBox5, label9);
                label8.Text = q.ToString();
            }
            //*Green disable*/
            if (DIce.Text == "6" && green == false)
            {
                pictureBox5.Visible = true;
                pictureBox2.Visible = false;
                green = true;
                pictureBox5.Location = new Point(x, y);
                label4.Text = x.ToString();
                label6.Text = y.ToString();
                label10.Text = q.ToString();
                q++;

            }
            //*Green win check*/
            if (q == 100)
            {
                MessageBox.Show("Winner #GREEN# !");
                button2.Enabled = false;
            }
            q = Logical.snake(ref Bx, ref By, q, pictureBox5);
            q = Logical.lader(ref Bx, ref By, q, pictureBox5);
            label10.Text = q.ToString();
            //*button accecabilty*/
            if (dicevalue == 6)
            {
                flag = 1;

            }
            else
            {
                flag = 0;
                button2.Enabled = false;
                button1.Enabled = true;
            }
            label1.BackColor = System.Drawing.Color.Red;
            label1.Text = "Player 1";

        }
        public void labeldisable()
        {
           // label1.Visible = false;
            //label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            

        }


    }
   
}
