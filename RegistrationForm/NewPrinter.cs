using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationForm
{
    public partial class NewPrinter : Form
    {
        public NewPrinter()
        {
            InitializeComponent();
        }

        bool expand = false;
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(expand == false)
            {
                panel2.Height += 15;
                if(panel2.Height >= panel2.MaximumSize.Height)
                {
                    timer1.Stop();
                    expand = true;
                }
            }
            else
            {
                panel2.Height -= 15;
                if(panel2.Height <= panel2.MinimumSize.Height)
                {
                    timer1.Stop();
                    expand = false;
                }
            }
        }
        private void label18_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button1.Text = "Microsoft Print to PDF Ready.";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button1.Text = "     Microsoft XPS Document Writer Ready.";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button1.Text = "OneNote (Desktop) Ready.";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button1.Text = "         OneNote for Windows 10 Ready.";
        }
        private void label20_Click(object sender, EventArgs e)
        {
            label1.Text = "Add printer...";
        }

        private void label19_Click(object sender, EventArgs e)
        {
            label1.Text = "Print to File..";
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            if (expand == false)
            {
                panel3.Height += 15;
                if (panel3.Height >= panel3.MaximumSize.Height)
                {
                    timer2.Stop();
                    expand = true;
                }
            }
            else
            {
                panel3.Height -= 15;
                if (panel3.Height <= panel3.MinimumSize.Height)
                {
                    timer2.Stop();
                    expand = false;
                }
            }
        }

        private void label23_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Text = "Print All pages, the whole thing.";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = "Print All pages, the whole thing.";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = "Print selection, just the one selected.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = "OneNote (Desktop) Ready.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = "OneNote for Windows 10 Ready .";
        }

        private void label16_Click(object sender, EventArgs e)
        {
            label16.Text = "Add to printer...";
        }

        private void label15_Click(object sender, EventArgs e)
        {
            label15.Text = "Print to File..";
        }

       
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (expand == false)
            {
                panel4.Height += 15;
                if (panel4.Height >= panel4.MaximumSize.Height)
                {
                    timer3.Stop();
                    expand = true;
                }
            }
            else
            {
                panel4.Height -= 15;
                if (panel4.Height <= panel4.MinimumSize.Height)
                {
                    timer3.Stop();
                    expand = false;
                }
            }
        }

        private void label21_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.Text = "Print One Sided, only print on one side of the page";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.Text = "Print One Sided, only print on one side of the page";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.Text = "Manually Print on both sides Reload paper when prompted to print the second side.";
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (expand == false)
            {
                panel5.Height += 15;
                if (panel5.Height >= panel5.MaximumSize.Height)
                {
                    timer4.Stop();
                    expand = true;
                }
            }
            else
            {
                panel5.Height -= 15;
                if (panel5.Height <= panel5.MinimumSize.Height)
                {
                    timer4.Stop();
                    expand = false;
                }
            }
        }

        private void label24_Click(object sender, EventArgs e)
        {
            timer4.Start();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button17.Text = "Collated 1,2,3, 1,2,3, 1,2,3";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.Text = "Collated 1,2,3, 1,2,3, 1,2,3";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.Text = "Uncollated 1,2,3, 1,2,3, 1,2,3";
        }
    }
}
