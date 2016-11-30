using System;
using System.Windows.Forms;

namespace GroupManagement
{
    public partial class ActionRequired : Form
    {
        public ActionRequired()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Profile f2 = new Profile();
            this.Hide();
            f2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Statistics s = new Statistics();
            this.Hide();
            s.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GroupEvents f3 = new GroupEvents();
            this.Hide();
            f3.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChronologicalGraph f4 = new ChronologicalGraph();
            this.Hide();
            f4.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void ActionRequired_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GroupEvents f3 = new GroupEvents();
            this.Hide();
            f3.ShowDialog();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Statistics s = new Statistics();
            this.Hide();
            s.ShowDialog();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChronologicalGraph c = new ChronologicalGraph();
            this.Hide();
            c.ShowDialog();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
