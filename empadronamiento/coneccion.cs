using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace empadronamiento
{
    class coneccion
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        public coneccion()
        {
            try
            {
                cn = new SqlConnection("Data Source=DESKTOP-U3SE54U\\SQLEXPRESS;Initial Catalog=wchang;Integrated Security=True");
                cn.Open();
                MessageBox.Show("Conectado a la base de Datos");
            }
            catch (Exception ex)

            {
                MessageBox.Show("No se conecto con la base de Datos"+ex.ToString());

            }

        }


        public string insertar(int dpi,string nombre,string municipio)
        {
            string salida = "Se a empadronado exitosamente";
            try
            {
                cmd = new SqlCommand("Insert into empadronar(dpi,Nombre,municipio) values(" + dpi + ",'" + nombre + "','" + municipio + "')", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }

       


        public int personaRegistrada(int dpi)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from empadronar where dpi=" + dpi+"", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return contador;
        }



    }
}
