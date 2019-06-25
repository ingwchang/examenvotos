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
    public partial class Guatemala : Form
    {
        public Guatemala()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (h1.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                h1.Enabled = false;
                h2.Enabled = false;
                h3.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 1;
                h1.Checked = false;
            }

            if (h2.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                h1.Enabled = false;
                h2.Enabled = false;
                h3.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 1;
                h2.Checked = false;
            }

            if (h3.Checked == true)
            {
                MessageBox.Show("Voto Nulo");
                h1.Enabled = false;
                h2.Enabled = false;
                h3.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 1;
                h3.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (r1.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                r1.Enabled = false;
                r2.Enabled = false;
                r3.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 2;
                r1.Checked = false;
            }

            if (r2.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                r1.Enabled = false;
                r2.Enabled = false;
                r3.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 2;
                r2.Checked = false;
            }

            if (r3.Checked == true)
            {
                MessageBox.Show("Voto Nulo");
                r1.Enabled = false;
                r2.Enabled = false;
                r3.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 2;
                r3.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (o1.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                o1.Enabled = false;
                o2.Enabled = false;
                o3.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 1;
                o1.Checked = false;
            }

            if (o2.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                o1.Enabled = false;
                o2.Enabled = false;
                o3.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 1;
                o2.Checked = false;
            }

            if (o3.Checked == true)
            {
                MessageBox.Show("Voto Nulo");
                o1.Enabled = false;
                o2.Enabled = false;
                o3.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 1;
                o3.Checked = false;
            }
        }

        private void Guatemala_Load(object sender, EventArgs e)
        {

        }
    }
    }
    
    

