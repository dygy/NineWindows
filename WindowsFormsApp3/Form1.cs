using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
       
        Form2 form2 = new Form2();
        Form3 form3 = new Form3();
        Form4 form4 = new Form4();
        Form5 form5 = new Form5();
        Form6 form6 = new Form6();
        Form7 form7 = new Form7();
        Form8 form8 = new Form8();
        Form9 form9 = new Form9();
        public Form1()
        {
            InitializeComponent();
            
            form2.Show();
            
            form3.Show();
            
            form4.Show();
            
            form5.Show();
            
            form6.Show();
            
            form7.Show();
            
            form8.Show();
            
            form9.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            button1.BackColor = randomColor;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Alt | Keys.D1))
            {
                System.Windows.Forms.Application.Exit();
            }
            else if (keyData == (Keys.Alt | Keys.D2))
            {
                form2.Hide();
            }
            else if (keyData == (Keys.Alt | Keys.D3))
            {
                form3.Hide();
            }
            else if(keyData == (Keys.Alt | Keys.D4))
            {
                form4.Hide();
            }
            else if(keyData == (Keys.Alt | Keys.D5))
            {
                form5.Hide();
            }
            else if (keyData == (Keys.Alt | Keys.D6))
            {
                form6.Hide();
            }
            else if (keyData == (Keys.Alt | Keys.D7))
            {
                form7.Hide();
            }
            else if (keyData == (Keys.Alt | Keys.D8))
            {
                form8.Hide();
            }
            else if (keyData == (Keys.Alt | Keys.D9))
            {
                form9.Hide();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
