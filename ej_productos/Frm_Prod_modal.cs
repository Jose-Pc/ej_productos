using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ej_productos
{
    public partial class Frm_Prod_modal : Form
    {
        public String cod { get; set; }
        public String nombre { get; set; }
        public String Descripcion { get; set; }
        public String tipo { get; set; }
        public int cantidad { get; set; }
        public float precio { get; set; }

        public Frm_Prod_modal()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Frm_Prod_modal_Load(object sender, EventArgs e)
        {
            txtB_codigoProd.Text = cod;
            txtB_nombre.Text = nombre;
            txtB_descripcion.Text = Descripcion;
            cmbox_tipo.SelectedIndex= 0 ;
            nud_cantidad.Value = cantidad;
            nud_precio.Value = new decimal((float) precio);
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            cod = txtB_codigoProd.Text;
            nombre = txtB_nombre.Text;
            Descripcion = txtB_descripcion.Text;
            tipo = cmbox_tipo.SelectedItem.ToString();
            cantidad = (int)nud_cantidad.Value;
            precio = (float)nud_precio.Value;

            if (cod == "" || nombre == "" || Descripcion == ""||tipo== null ||cantidad== 0 || precio == 0)
            {
                MessageBox.Show("No se pueden dejar cambios vacios.");
            }
            else
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
