using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccesoDatos
{
    public partial class FrmEliminar : Form
    {
        public FrmEliminar()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string sql = "insert into personas(cedula, apellidos, nombres, fechaNacimiento, peso)";
            sql += "values(@cedula)";

            MessageBox.Show("Esta seguro que desea eliminar este registro? ");
        }
    }
}
