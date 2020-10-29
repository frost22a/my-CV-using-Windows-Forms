using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace CV
{
    public partial class Loading : UserControl
    {
        int i = 0;
        public Loading()
        {
            InitializeComponent();
            this.textBox1.Text = "Loading";
         }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.textBox1.Text += ".";
            if (i > 10) 
            { 
                timer1.Enabled = false;
                this.SendToBack();
            }
            i++;
        }
    }
}
