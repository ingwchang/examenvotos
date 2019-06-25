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
    public partial class Empadronar : Form


    {

        
        coneccion c = new coneccion();
        public Empadronar()
        {
            InitializeComponent();
        }
        private void Empadronar_Load(object sender, EventArgs e)
        {
            RbInsertar.Checked = true;
            coneccion c = new coneccion();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registrar_Click(object sender, EventArgs e)



        {

            if ((string.IsNullOrEmpty(textBoxDPI.Text) || (string.IsNullOrEmpty(textBoxnombre.Text))))
            {
                MessageBox.Show("Por favor llenar todos los requisitos");
            }

            else
            {

                if (c.personaRegistrada(Convert.ToInt32(textBoxDPI.Text)) == 0)
                {
                    MessageBox.Show(c.insertar(Convert.ToInt32(textBoxDPI.Text), textBoxnombre.Text, comboBoxmunicipio.Text));
                    //textBoxDPI.Text = "";
                    //textBoxnombre.Text = "";
                   // comboBoxmunicipio.Text = "";


                    if (comboBoxmunicipio.SelectedItem.Equals("Suchitepéquez"))
                    {
                        Suchitepequez n = new Suchitepequez();
                        n.Show();
                    }
                    if (comboBoxmunicipio.SelectedItem.Equals("Guatemala"))
                    {
                        Guatemala n = new Guatemala();
                        n.Show();
                    }

                    if (comboBoxmunicipio.SelectedItem.Equals("Quetzaltenango"))
                    {
                        Quetzaltenango nc = new Quetzaltenango();
                        nc.Show();
                    }

                    if (comboBoxmunicipio.SelectedItem.Equals("Sololá"))
                    {
                        Sololá n = new Sololá();
                        n.Show();
                    }

                    if (comboBoxmunicipio.SelectedItem.Equals("Retalhuleu"))
                    {
                        Retalhuleu n = new Retalhuleu();
                        n.Show();
                    }






                }
                else
                {
                    MessageBox.Show("El numero de C.U.I. ya esta empadronado");
                }

            }    
        }

            

        
    
        
        

        private void textBoxnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDPI_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBoxnombre.Enabled = true;
            textBoxDPI.Enabled = true;
            comboBoxmunicipio.Enabled = true;
            Registrar.Enabled = true;
            Cancelar.Enabled = true;

            DPI.Enabled = false;
            Aceptar.Enabled = false;
            DEPARTAMENTO.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
           
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {





            if ((string.IsNullOrEmpty(DPI.Text) || (string.IsNullOrEmpty(DEPARTAMENTO.Text))))

            {
                MessageBox.Show("Por favor llenar todos los requisitos");

            }
            else
            {

                if (DEPARTAMENTO.SelectedItem.Equals("Suchitepéquez"))
                {
                    Suchitepequez n = new Suchitepequez();
                    n.Show();
                }
                if (DEPARTAMENTO.SelectedItem.Equals("Guatemala"))
                {
                    Guatemala n = new Guatemala();
                    n.Show();
                }

                if (DEPARTAMENTO.SelectedItem.Equals("Quetzaltenango"))
                {
                    Quetzaltenango nc = new Quetzaltenango();
                    nc.Show();
                }

                if (DEPARTAMENTO.SelectedItem.Equals("Sololá"))
                {
                    Sololá n = new Sololá();
                    n.Show();
                }

                if (DEPARTAMENTO.SelectedItem.Equals("Retalhuleu"))
                {
                    Retalhuleu n = new Retalhuleu();
                    n.Show();
                }
            }









        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            textBoxDPI.Clear();
            textBoxnombre.Clear();
            comboBoxmunicipio.SelectedIndex = -1;
        }

        private void RbInsertar_CheckedChanged(object sender, EventArgs e)
        {
            DPI.Enabled = true;
            DEPARTAMENTO.Enabled = true;
            Aceptar.Enabled = true;

            textBoxDPI.Enabled = false;
            textBoxnombre.Enabled = false;
            comboBoxmunicipio.Enabled = false;
            Registrar.Enabled = false;
            Cancelar.Enabled = false;
        }

        private void Empadronar_Load_1(object sender, EventArgs e)
        {

        }
    }
    }

