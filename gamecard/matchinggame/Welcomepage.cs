using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matchinggame
{
    public partial class Welcomepage : Form
    {
        finform ms = new finform();
        public Welcomepage()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //username from welcomeform to Form1
            if(richTextBox1.Text == " ")
            {
                ms.message("please enter username");
            }
            string rtbx = richTextBox1.Text;
            Form1 form1 = new Form1(rtbx);
            form1.Show();
            this.Hide();

        }
    }
}
