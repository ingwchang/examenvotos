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
    public partial class Quetzaltenango : Form
    {
        public Quetzaltenango()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (c1.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                c1.Enabled = false;
                c2.Enabled = false;
                c3.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 3;
                c1.Checked = false;
            }

            if (c2.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                c1.Enabled = false;
                c2.Enabled = false;
                c3.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 3;
                c2.Checked = false;
            }

            if (c3.Checked == true)
            {
                MessageBox.Show("Voto Nulo");
                c1.Enabled = false;
                c2.Enabled = false;
                c3.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 3;
                c3.Checked = false;
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (a1.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                a1.Enabled = false;
                a2.Enabled = false;
                a3.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 2;
                a1.Checked = false;
            }

            if (a2.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                a1.Enabled = false;
                a2.Enabled = false;
                a3.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 2;
                a2.Checked = false;
            }

            if (a3.Checked == true)
            {
                MessageBox.Show("Voto Nulo");
                a1.Enabled = false;
                a2.Enabled = false;
                a3.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 2;
                a3.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (s1.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                s1.Enabled = false;
                s2.Enabled = false;
                s3.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 1;
                s1.Checked = false;
            }

            if (s2.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                s1.Enabled = false;
                s2.Enabled = false;
                s3.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 1;
                s1.Checked = false;
            }

            if (s3.Checked == true)
            {
                MessageBox.Show("Voto Nulo");
                s1.Enabled = false;
                s2.Enabled = false;
                s3.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 1;
                s1.Checked = false;
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
    
    

