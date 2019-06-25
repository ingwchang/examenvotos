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
    public partial class Retalhuleu : Form
    {
        public Retalhuleu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (vota1.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                vota1.Enabled = false;
                vota2.Enabled = false;
                vota3.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 2;
                vota1.Checked = false;
            }

            if (vota2.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                vota1.Enabled = false;
                vota2.Enabled = false;
                vota3.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 2;
                vota2.Checked = false;
            }

            if (vota3.Checked == true)
            {
                MessageBox.Show("Voto Nulo");
                vota1.Enabled = false;
                vota2.Enabled = false;
                vota3.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 2;
                vota3.Checked = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(a.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                a.Enabled = false;
                b.Enabled = false;
                c.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 1;
                a.Checked = false;
            }

            if (b.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                a.Enabled = false;
                b.Enabled = false;
                c.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 1;
                b.Checked = false;
            }

            if (c.Checked == true)
            {
                MessageBox.Show("Voto Nulo");
                a.Enabled = false;
                b.Enabled = false;
                c.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 1;
                c.Checked = false;
            }

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
                checkBox1.Checked = false;
            }

            if (checkBox3.Checked == true)
            {
                MessageBox.Show("Voto Nulo");
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 1;
                checkBox1.Checked = false;
            }
        }
    }
    }
 

