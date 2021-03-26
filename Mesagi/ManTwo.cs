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
    public partial class ManTwo : Form
    {
        public delegate void Message(string mess);
        public event Message Soobsil = delegate { };
        public ManTwo(){InitializeComponent();}

        private void cancelbut_Click(object sender, EventArgs e){Maluava.Text = "";}

        private void okbut_Click(object sender, MouseEventArgs e){
            MessageBox.Show("DDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDD");
            Addaem("I : "+Maluava.Text);
            Soobsil(Maluava.Text);
            Maluava.Text = "";
        }
        private void okbut_ddClick(object sender, EventArgs e)
        {
            MessageBox.Show("DDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDD");
            Addaem("I : " + Maluava.Text);
            Soobsil(Maluava.Text);
            Maluava.Text = "";
        }

        private void okbut_Click(object sender, EventArgs e)
        {
            Addaem("I : " + Maluava.Text);
            Soobsil(Maluava.Text);
            Maluava.Text = "";
        }

        public void PrinualSoobsenie(string Maluava)
        {
            Addaem("Ne I : " + Maluava);
        }

        void Addaem(string ss)
        {
            //Maluav.Rows.Add(ss);
            Maluav.Rows.Insert(0, ss);
        }
    }
}
