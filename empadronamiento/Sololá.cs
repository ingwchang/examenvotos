using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace empadronamiento
{
    public partial class Sololá : Form
    {
        public Sololá()
        {
            InitializeComponent();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (q1.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                q1.Enabled = false;
                q2.Enabled = false;
                q3.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 2;
                q1.Checked = false;
            }

            if (q2.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                q1.Enabled = false;
                q2.Enabled = false;
                q3.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 2;
                q1.Checked = false;
            }

            if (q3.Checked == true)
            {
                MessageBox.Show("Voto Nulo");
                q1.Enabled = false;
                q2.Enabled = false;
                q3.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 2;
                q1.Checked = false;
            }
        }
    

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (d1.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                d1.Enabled = false;
                d2.Enabled = false;
                d3.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 1;
                d1.Checked = false;
            }

            if (d2.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                d1.Enabled = false;
                d2.Enabled = false;
                d3.Enabled = false;
                d1.Enabled = false;

                tabControl1.SelectedIndex = 1;
                d1.Checked = false;
            }

            if (d3.Checked == true)
            {
                MessageBox.Show("Voto Nulo");
                d1.Enabled = false;
                d2.Enabled = false;
                d3.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 1;
                d1.Checked = false;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 1;
                checkBox1.Checked = false;
            }

            if (checkBox2.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 1;
                checkBox2.Checked = false;
            }

            if (checkBox3.Checked == true)
            {
                MessageBox.Show("Voto Nulo");
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 1;
                checkBox3.Checked = false;
            }
        }
    }
    }
   

