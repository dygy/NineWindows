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
    public partial class Form7 : Form
    {
        public Form7()
        {
           
            InitializeComponent();
          //  Thread.Sleep(3000);
      //      Form4 form4 = new Form4();
      //      form4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            button1.BackColor = randomColor;
        }
    }
}
