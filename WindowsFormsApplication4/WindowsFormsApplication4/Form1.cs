
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        Stopwatch stopwatch = new Stopwatch();
        Form2 secform = new Form2();
        public Form1()
        {
            InitializeComponent();
        }
        public void but()
        {
            Random rnd = new Random();
          
            switch (x.countz[((x.count-1)%9)])
            {
                case 1:
                    {
                        button1.Size = new Size(rnd.Next(50, 250), rnd.Next(30, 150));
                        
                        button1.Visible = true;
                    button1.Enabled = true;
                    button1.Text = Convert.ToString(x.count);
                    }
                    break;
                case 2:
                    {
                        button2.Size = new Size(rnd.Next(50, 250), rnd.Next(30, 150)); 
                        button2.Visible = true;
                button2.Enabled = true;
                button2.Text = Convert.ToString(x.count);

                }
                    break;
                case 3:
                    {
                        button3.Size = new Size(rnd.Next(50, 250), rnd.Next(30, 150)); 
                        button3.Visible = true;
                button3.Enabled = true;
                button3.Text = Convert.ToString(x.count);
                }
                    break;
                case 4:
                    {
                        button4.Size = new Size(rnd.Next(50, 250), rnd.Next(30, 150)); 
                        button4.Visible = true;
                button4.Enabled = true;
                button4.Text = Convert.ToString(x.count);
                }
                    break;
                case 5: {
                    button5.Size = new Size(rnd.Next(50, 250), rnd.Next(30, 150)); 
                    button5.Visible = true;
                button5.Enabled = true;
                button5.Text = Convert.ToString(x.count);
                }
                    break;
                case 6:
                    {
                        button6.Size = new Size(rnd.Next(50, 250), rnd.Next(30, 150));
                        button6.Visible = true;
                button6.Enabled = true;
                button6.Text = Convert.ToString(x.count);
                }
                    break;
                case 7:
                    {
                        button7.Size = new Size(rnd.Next(50, 250), rnd.Next(30, 150)); 
                        button7.Visible = true;
                button7.Enabled = true;
                button7.Text = Convert.ToString(x.count);
                }
                    break;
                case 8:
                    {
                        button8.Size = new Size(rnd.Next(50, 250), rnd.Next(30, 150));
                        button8.Visible = true;
                button8.Enabled = true;
                button8.Text = Convert.ToString(x.count);
                }
                    break;
                case 9:
                    {
                        button9.Size = new Size(rnd.Next(50, 250), rnd.Next(30, 150)); 
                        button9.Visible = true;
                button9.Enabled = true;
                button9.Text = Convert.ToString(x.count);
                }
                    break;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            
            for (int i = 1; i <= 3; i++)
            {
                int a = rnd.Next(0, 9);
                int c = rnd.Next(0, 9);
                int temp = 0;
                temp = x.countz[a];
                x.countz[a] = x.countz[c];
                x.countz[c] = temp;

            }
           
           
            but();
            stopwatch.Start();
            x.count++;
            x.fName = DateTime.Now.ToString("yyyy-MM-dd_hh-mm-ss") + ".txt";
            FileStream fs = File.Open(@"C:\mouse_data\" + x.fName, FileMode.CreateNew, FileAccess.Write);
            using (StreamWriter sw = new StreamWriter(fs))
            {
                
            }
  
        }

        private void button1_Click(object sender, EventArgs e)
        {

            stopwatch.Stop(); 
            
            var milliSeocnds = stopwatch.ElapsedMilliseconds;
            int mx,my;
            mx=button1.Location.X+(button1.Size.Width/2);
            my = button1.Location.Y + (button1.Size.Height/2);
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(@"C:\mouse_data\" + x.fName, true))
            {
                x.input = "1" + "," + button1.Size + ","+mx +"  "+my+","+Cursor.Position+","+milliSeocnds;
                sw.WriteLine(x.input);
              
            }
            button1.Visible = false;
            button1.Enabled = false;
            if (x.count == 41)
            {
                MessageBox.Show("Thank you for giving test,And we would like to have little feedback from you. ");
                secform.Show();
                this.Hide();
                
            }

            but();
            stopwatch.Reset();
            stopwatch.Start();
            
            x.count++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            stopwatch.Stop();
           
            var milliSeocnds = stopwatch.ElapsedMilliseconds;
            int mx, my;
            mx = button2.Location.X + (button2.Size.Width / 2);
            my = button2.Location.Y + (button2.Size.Height / 2);
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(@"C:\mouse_data\" + x.fName, true))
            {
                x.input = "2" + "," + button2.Size + "," + mx +" "+ my + "," + Cursor.Position + "," + milliSeocnds;
                sw.WriteLine(x.input);

            }
            button2.Visible = false;
            button2.Enabled = false;
            if (x.count == 41)
            {
                MessageBox.Show("Thank you for giving test,And we would like to have little feedback from you. ");
                secform.Show();
                this.Hide();

            }

            but();
            stopwatch.Reset();
            stopwatch.Start();
            
            x.count++;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            stopwatch.Stop();
            
            var milliSeocnds = stopwatch.ElapsedMilliseconds;
            int mx, my;
            mx = button3.Location.X + (button3.Size.Width / 2);
            my = button3.Location.Y + (button3.Size.Height / 2);
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(@"C:\mouse_data\" + x.fName, true))
            {
                x.input = "3" + "," + button3.Size + "," + mx +" "+ my + "," + Cursor.Position + "," +milliSeocnds;
                sw.WriteLine(x.input);

            }
            button3.Visible = false;
            button3.Enabled = false;
            if (x.count == 41)
            {
                MessageBox.Show("Thank you for giving test,And we would like to have little feedback from you. ");
                secform.Show();
                this.Hide();

            }

            but();
            stopwatch.Reset();
            stopwatch.Start();
            x.count++;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            stopwatch.Stop();
            
            var milliSeocnds = stopwatch.ElapsedMilliseconds;
            int mx, my;
            mx = button4.Location.X + (button4.Size.Width / 2);
            my = button4.Location.Y + (button4.Size.Height / 2);
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(@"C:\mouse_data\" + x.fName, true))
            {
                x.input = "4" + "," + button4.Size + "," + mx + " "+my + "," + Cursor.Position + "," + milliSeocnds;
                sw.WriteLine(x.input);

            }
            button4.Visible = false;
            button4.Enabled = false;
            if (x.count == 41)
            {
                MessageBox.Show("Thank you for giving test,And we would like to have little feedback from you. ");
                secform.Show();
                this.Hide();

            }
            but();
            stopwatch.Reset();
            stopwatch.Start();
            
            x.count++;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            stopwatch.Stop();
            
            var milliSeocnds = stopwatch.ElapsedMilliseconds;
            int mx, my;
            mx = button5.Location.X + (button5.Size.Width / 2);
            my = button5.Location.Y + (button5.Size.Height / 2);
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(@"C:\mouse_data\" + x.fName, true))
            {
                x.input = "5" + "," + button5.Size + "," + mx + " "+my + "," + Cursor.Position + "," +milliSeocnds;
                sw.WriteLine(x.input);

            }
            button5.Visible = false;
            button5.Enabled = false;
            if (x.count == 41)
            {
                MessageBox.Show("Thank you for giving test,And we would like to have little feedback from you. ");
                secform.Show();
                this.Hide();

            }
            but();
            stopwatch.Reset();
            stopwatch.Start();
            
            x.count++;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            stopwatch.Stop();
            
            var milliSeocnds = stopwatch.ElapsedMilliseconds;
            int mx, my;
            mx = button6.Location.X + (button6.Size.Width / 2);
            my = button6.Location.Y + (button6.Size.Height / 2);
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(@"C:\mouse_data\" + x.fName, true))
            {
                x.input = "6" + "," + button6.Size + "," + mx + " "+my + "," + Cursor.Position + "," +milliSeocnds;
                sw.WriteLine(x.input);

            }
            button6.Visible = false;
            button6.Enabled = false;
            if (x.count == 41)
            {
                MessageBox.Show("Thank you for giving test,And we would like to have little feedback from you. ");
                secform.Show();
                this.Hide();

            }

            but();
            stopwatch.Reset();
            stopwatch.Start();
            
            x.count++;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
            
            var milliSeocnds = stopwatch.ElapsedMilliseconds;
            int mx, my;
            mx = button7.Location.X + (button7.Size.Width / 2);
            my = button7.Location.Y + (button7.Size.Height / 2);
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(@"C:\mouse_data\" + x.fName, true))
            {
                x.input = "7" + "," + button7.Size + "," + mx + " " + my + "," + Cursor.Position + "," + milliSeocnds;
                sw.WriteLine(x.input);

            }
            button7.Visible = false;
            button7.Enabled = false;
            if (x.count == 41)
            {
                MessageBox.Show("Thank you for giving test,And we would like to have little feedback from you. ");
                secform.Show();
                this.Hide();

            }

            but();
            stopwatch.Reset();
            stopwatch.Start();
            
            x.count++;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
           
            var milliSeocnds = stopwatch.ElapsedMilliseconds;
            int mx, my;
            mx = button8.Location.X + (button8.Size.Width / 2);
            my = button8.Location.Y + (button8.Size.Height / 2);
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(@"C:\mouse_data\" + x.fName, true))
            {
                x.input = "8" + "," + button8.Size + "," + mx + " "+my + "," + Cursor.Position + "," + milliSeocnds;
                sw.WriteLine(x.input);

            }
            button8.Visible = false;
            button8.Enabled = false;
            if (x.count == 41)
            {
                MessageBox.Show("Thank you for giving test,And we would like to have little feedback from you. ");
                secform.Show();
                this.Hide();

            }

            but();
            stopwatch.Reset();
            stopwatch.Start();
            x.count++;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
            
            var milliSeocnds = stopwatch.ElapsedMilliseconds;
            int mx, my;
            mx = button9.Location.X + (button9.Size.Width / 2);
            my = button9.Location.Y + (button9.Size.Height / 2);
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(@"C:\mouse_data\" + x.fName, true))
            {
                x.input = "9" + "," + button9.Size + "," + mx +" "+ my + "," + Cursor.Position + "," + milliSeocnds;
                sw.WriteLine(x.input);

            }
            button9.Visible = false;
            button9.Enabled = false;
             if (x.count == 41)
            {
                MessageBox.Show("Thank you for giving test,And we would like to have little feedback from you. ");
                secform.Show();
                this.Hide();
                
            }
             but();
             stopwatch.Reset();
             stopwatch.Start();
            
            x.count++;

        }

        
       
    }
        public static class x
        {
            public static int[] countz = new int[] { 2, 3, 1, 4, 5, 6, 7, 9, 8 };
            public static int count=1;
            public static String fName = " ";
           public static string input = " ";
           public static int c = 0;
           public static int cnt = 0;
        }

    
}