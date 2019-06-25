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
    public partial class Suchitepequez : Form
    {
        public Suchitepequez()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                checkBox6.Enabled = false;
                checkBox5.Enabled = false;
                checkBox4.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 2;
                checkBox6.Checked = false;
            }

            if (checkBox5.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                checkBox5.Enabled = false;
                checkBox4.Enabled = false;
                checkBox6.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 2;
                checkBox5.Checked = false;
            }

            if (checkBox4.Checked == true)
            {
                MessageBox.Show("Voto Nulo");
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;
                checkBox6.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedIndex = 2;
                checkBox4.Checked = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (checkBox9.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                checkBox9.Enabled = false;
                checkBox8.Enabled = false;
                checkBox7.Enabled = false;
                button1.Enabled = false;
                Suchitepequez n = new Suchitepequez();
                n.Close();
            }

            if (checkBox8.Checked == true)
            {
                MessageBox.Show("Gracias por su voto");
                checkBox8.Enabled = false;
                checkBox7.Enabled = false;
                checkBox9.Enabled = false;
                button1.Enabled = false;

                Suchitepequez n = new Suchitepequez();
                n.Close();
            }

            if (checkBox7.Checked == true)
            {
                MessageBox.Show("Voto Nulo");
                checkBox7.Enabled = false;
                checkBox8.Enabled = false;
                checkBox9.Enabled = false;
                button1.Enabled = false;

                Suchitepequez n = new Suchitepequez();
                n.Close();
            }
        }

        private void Suchitepequez_Load(object sender, EventArgs e)
        {

        }
    }
    }
    
    

