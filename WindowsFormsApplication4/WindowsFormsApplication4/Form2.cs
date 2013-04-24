using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApplication4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(@"C:\mouse_data\" + "survey_" + x.fName, true))
            {
                if (radioButton1.Checked == true)
                {
                    sw.WriteLine("1" + "\n");
                    radioButton1.Checked = false;
                }
                if (radioButton2.Checked == true)
                {
                    sw.WriteLine("2" + "\n");
                    radioButton2.Checked = false;
                }
                if (radioButton3.Checked == true)
                {
                    sw.WriteLine("3" + "\n");
                    radioButton3.Checked = false;
                }
                if (radioButton4.Checked == true)
                {
                    sw.WriteLine("4" + "\n");
                    radioButton4.Checked = false;
                }
                if (radioButton5.Checked == true)
                {
                    sw.WriteLine("5" + "\n");
                    radioButton5.Checked = false;
                }
                if (x.cnt == 7)
                {
                    MessageBox.Show("Thank You");
                    this.Close();
                }
                x.cnt++;
                switch (x.cnt)
                {
                    case 1:
                        label1.Text = "Are you Hesitant?";
                        break;
                    case 2:
                        label1.Text = "Are you Nervous?";
                        break;
                    case 3:
                        label1.Text = "Are you Relaxed?";
                        break;
                    case 4:
                        label1.Text = "Are you Sad?";
                        break;
                    case 5: label1.Text = "Are you Tired?";
                        break;
                    case 6: label1.Text = "Are you Angry?";
                        break;
                    case 7: label1.Text = "Are you Excited?";
                        break;
                }
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            label1.Text = "Are you confident?";


            FileStream fxm = File.Open(@"C:\mouse_data\" + "survey_" + x.fName, FileMode.CreateNew, FileAccess.Write);

            using (StreamWriter sw = new StreamWriter(fxm))
            {

            }

        }
    }
}
