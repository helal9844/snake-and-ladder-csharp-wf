using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_And_Ladder
{
    internal class Logical
    {
        /*   the dice logic          */
        public static int Rolldice(PictureBox px)
        {
            int dice ;
            Random r = new Random();
            dice = r.Next(1, 7);

            px.Image = Image.FromFile(@"imgs\" + dice + ".png");
            px.SizeMode = PictureBoxSizeMode.StretchImage;
            return dice;
        }
          /* Movement Logic    */
        public static int move(ref int x, ref int y, int p,int dice, PictureBox px, Label l)
        {
            /* check last 6 dice */
            if (dice + p > 100)
            {
                l.Text = "Bad Luck !";
                l.ForeColor = System.Drawing.Color.Red;

            }
            /* the other move line  */
            else
            {
                for (int i = 0; i < dice; i++)
                {

                    if (p == 10)
                    {

                        x = 799;
                        y = 459;

                    }
                    else if (p == 20)
                    {
                        x = 24;
                        y = 406;

                    }


                    else if (p == 30)
                    {
                        x = 799;
                        y = 345;

                    }
                    else if (p == 40)
                    {
                        x = 24;
                        y = 288;

                    }
                    else if (p == 50)
                    {
                        x = 799;
                        y = 231;

                    }
                    else if (p == 60)
                    {
                        x = 24;
                        y = 171;

                    }
                    else if (p == 70)
                    {
                        x = 799;
                        y = 116;

                    }
                    else if (p == 80)
                    {
                        x = 24;
                        y = 56;

                    }
                    else if (p == 90)
                    {
                        x = 799;
                        y = 3;

                    }
                    else if ((p < 20 && p >= 11) || (p < 40 && p >= 31) || (p < 60 && p >= 51) || (p < 80 && p >= 71) || (p < 100 && p >= 91))
                    {
                        x -= 86;

                    }     
                    else
                    {
                        x += 86;
                    }
                    l.Text = p.ToString();
                    px.Location = new Point(x, y);
                    p++; 
                }
            }
            return p;

        }
        /*  Snake Bite */
        public static int snake (ref int x, ref int y, int p,PictureBox px)
        {
            if (p==17)
            {
                x = 544;
                y = 518;
                p = 7;
                
            }
            else if (p == 62)
            {
                x = 115;
                y = 461;
                p = 19;
                
            }
            else if (p == 54)
            {
                x = 537; 
                y = 347;
                p = 34;
                
            }
            else if (p == 87)
            {
                x = 367; 
                y = 346;
                p = 36;
                 
            }
            else if (p == 64)
            {
                x = 24;
                y = 230;
                p = 60;
                 
            }
            else if (p == 93)
            {
                x = 626; 
                y = 118;
                p = 73;
                 
            }
            else if (p == 95)
            {
                x = 455; 
                y = 118;
                p = 75;
                
            }
            else if (p == 98)
            {
                x = 109; 
                y = 118;
                p = 79;
                
            }


            px.Location = new Point(x, y);
            return p;
        }
        /* Ladder Up */
        public static int lader(ref int x, ref int y, int p, PictureBox px)
        {
            if (p == 1)
            {
                x = 195;
                y = 345;
                p = 38;
            }
            else if (p == 4)
            {
                x = 535;
                y = 459;
                p = 14;
            }

            else if (p == 9)
            {
                x = 799;
                y = 345;
                p = 31;
            }
            else if (p == 28)
            {
                x = 277;
                y = 58;
                p = 84;
            }
            else if (p == 21)
            {
                x = 108;
                y = 587;
                p = 42;
            }
            else if (p == 51)
            {
                x = 536;
                y = 171;
                p = 86;
            }
            else if (p == 80)
            {
                x = 108;
                y = 3;
                p = 99;
            }
            else if (p == 72)
            {

                x = 797;
                y = 3;
                p = 91;

            }
            px.Location = new Point(x, y);
            return p;
        }
    }
}
