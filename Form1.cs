using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {

        private int x = 200;
        private int y = 200;

        public Form1()
        {
            InitializeComponent();
        }

        private void picBoxNb_Click(object sender, EventArgs e)
        {

        }

        private void picBoxRy_Click(object sender, EventArgs e)
        {

        }

        private void tmrMove_Tick(object sender, EventArgs e)
        {
            picBoxNb.Location = new Point(x, 20);
            x += 20;
            x += 20;
        }

        private void tmrMove1_Tick(object sender, EventArgs e)
        {
            picBoxRy.Location = new Point(y, 20);
            y += 20;
            y += 20;
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            tmrMove.Enabled = true;
            tmrMove1.Enabled = true;
        }
    }
}
