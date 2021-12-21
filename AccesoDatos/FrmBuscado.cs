using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public partial class FrmBuscado : Form
    {
        public FrmBuscado()
        {
            InitializeComponent();
        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void CmbPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void FrmBuscado_Load(object sender, EventArgs e)
        {
            DataTable dt = getpersonas();
            this.CmbPersonas.DataSource = dt;
            this.CmbPersonas.DisplayMember = "nombreCompleto";
            this.CmbPersonas.ValueMember = "cedula";

          
        }

        private DataTable getpersonas()
        {
            throw new NotImplementedException();
        }

        private DataTable getpersonas(string cedula="")
        {
            SqlConnection conexion = new SqlConnection(@"server = L - ELR - 017\SQLEXPRESS; database = TI2021; Integrated Security = true");
            string sql = "";
            if(cedula=="")
            {
                sql = "Select cedula, apellidos, nombres, uper(apellidos+''+nombre) as nombreCompleto, fechaNacimiento, peso";
                sql += "from personas order by apellidos, nombres";

            }
            else
            {
                sql = "Select cedula, apellidos, nombres, fechaNacimineto, peso";
                sql += "From personas order by apellidos, nombres, fechaNacimineto, peso ";

            }

            SqlCommand comando = new SqlCommand(sql, conexion);
            if (cedula == "")
            {
                comando.Parameters.Add(new SqlParameter("@cedula",cedula));
            }
            SqlDataAdapter ad1 = new SqlDataAdapter(comando);

            //pasar los desde el adaptador a un datable
            DataTable dt = new DataTable();
            ad1.Fill(dt);

            return dt;

        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            DataTable dt = getpersonas(this.CmbPersonas.SelectedValue.ToString());
            //Mostrar la informacion de los cuadros de texto
            foreach(DataRow row in dt.Rows)
            {
                this.txtCedula.Text = row["Cedula"].ToString();
                this.txtApellido.Text = row["Apellidos"].ToString();
                this.txtNombres.Text = row["Nombres"].ToString();
                this.TxtFechaNaci.Text = row["FechaNacimiento"].ToString();
                this.txtPeso.Text = row["Peso"].ToString();
                this.TxtFeNa.Text = row["FechaNac"].ToString();
            }
        }
    }
}
