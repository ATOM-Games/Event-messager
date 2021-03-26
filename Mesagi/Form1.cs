using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mesagi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ManOne Ol = new ManOne();
            ManTwo Tl = new ManTwo();
            Ol.Show();
            Tl.Show();
            Ol.Soobsil += Tl.PrinualSoobsenie;
            Tl.Soobsil += Ol.PrinualSoobsenie;
        }

        private void ц(object sender, EventArgs e)
        {
            this.Text = "уууууууууууууууууу";
        }
    }
}
