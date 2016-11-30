using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupManagement
{
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPage m1 = new MainPage();
            this.Hide();
            m1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChronologicalGraph f4 = new ChronologicalGraph();
            this.Hide();
            f4.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GroupEvents f3 = new GroupEvents();
            this.Hide();
            f3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActionRequired A = new ActionRequired();
            this.Hide();
            A.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Profile f2 = new Profile();
            this.Hide();
            f2.ShowDialog();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainPage m1 = new MainPage();
            this.Hide();
            m1.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Profile f2 = new Profile();
            this.Hide();
            f2.ShowDialog();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ActionRequired A = new ActionRequired();
            this.Hide();
            A.ShowDialog();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GroupEvents f3 = new GroupEvents();
            this.Hide();
            f3.ShowDialog();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChronologicalGraph c = new ChronologicalGraph();
            this.Hide();
            c.ShowDialog();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {

        }
    }
}
