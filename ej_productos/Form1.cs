using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ej_productos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dgv_productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            Frm_Prod_modal Frm_modDel = null;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgv_productos.Columns["modificar"].Index)
                {
                    String nombreProd = dgv_productos.Rows[e.RowIndex].Cells[dgv_productos.Columns["Nombre"].Index].Value.ToString();

                    if (MessageBox.Show("Seguro que deseas MODIFICAR el producto " + nombreProd.ToUpper() + " ?", "Modificar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Frm_modDel = new Frm_Prod_modal();

                        Frm_modDel.cod = dgv_productos.Rows[e.RowIndex].Cells[dgv_productos.Columns["cod_prod"].Index].Value.ToString();
                        Frm_modDel.nombre = dgv_productos.Rows[e.RowIndex].Cells[dgv_productos.Columns["Nombre"].Index].Value.ToString();
                        Frm_modDel.Descripcion = dgv_productos.Rows[e.RowIndex].Cells[dgv_productos.Columns["Descripción"].Index].Value.ToString();
                        Frm_modDel.tipo = dgv_productos.Rows[e.RowIndex].Cells[dgv_productos.Columns["Tipo"].Index].Value.ToString();
                        Frm_modDel.cantidad = Convert.ToInt16(dgv_productos.Rows[e.RowIndex].Cells[dgv_productos.Columns["Cantidad"].Index].Value.ToString());
                        Frm_modDel.precio = Convert.ToSingle(dgv_productos.Rows[e.RowIndex].Cells[dgv_productos.Columns["Precio"].Index].Value.ToString());

                        if (Frm_modDel.ShowDialog() == DialogResult.OK)
                        {
                            dgv_productos.Rows[e.RowIndex].Cells[dgv_productos.Columns["cod_prod"].Index].Value = Frm_modDel.cod;
                            dgv_productos.Rows[e.RowIndex].Cells[dgv_productos.Columns["Nombre"].Index].Value = Frm_modDel.nombre;
                            dgv_productos.Rows[e.RowIndex].Cells[dgv_productos.Columns["Descripción"].Index].Value = Frm_modDel.Descripcion;
                            dgv_productos.Rows[e.RowIndex].Cells[dgv_productos.Columns["Tipo"].Index].Value = Frm_modDel.tipo;
                            dgv_productos.Rows[e.RowIndex].Cells[dgv_productos.Columns["Cantidad"].Index].Value = Frm_modDel.cantidad;
                            dgv_productos.Rows[e.RowIndex].Cells[dgv_productos.Columns["Precio"].Index].Value = Frm_modDel.precio;
                        }
                    }
                    

                }
                if (e.ColumnIndex == dgv_productos.Columns["borrar"].Index)
                {
                    String nombreProd = dgv_productos.Rows[e.RowIndex].Cells[dgv_productos.Columns["Nombre"].Index].Value.ToString();

                    if (MessageBox.Show("Seguro que deseas borrar el producto "+nombreProd.ToUpper()+" ?", "Borrar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        dgv_productos.Rows.RemoveAt(e.RowIndex);

                        if (dgv_productos.Rows.Count != 0)
                        {
                            btn_exportCSV.Enabled = true;
                            exportarCSVToolStripMenuItem.Enabled = true;
                        }
                        else
                        {
                            btn_exportCSV.Enabled = false;
                            exportarCSVToolStripMenuItem.Enabled = false;
                            modificarProductoToolStripMenuItem.Enabled = false;
                            borrarProductoToolStripMenuItem.Enabled = false;
                        }
                        
                    }
                    
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            //string[] dato = { "1", "1", "1", "1", "1", "1" };
            //dgv_productos.Rows.Add(dato);
        }

        private void btn_anyadir_Click(object sender, EventArgs e)
        {
            Frm_Prod_modal fpr = new Frm_Prod_modal();

            if (fpr.ShowDialog() == DialogResult.OK)
            {
                string[] filaNueva = new string[6];
                filaNueva[0] = fpr.cod;
                filaNueva[1] = fpr.nombre;
                filaNueva[2] = fpr.Descripcion;
                filaNueva[3] = fpr.tipo;
                filaNueva[4] = fpr.cantidad.ToString();
                filaNueva[5] = fpr.precio.ToString();
               
                dgv_productos.Rows.Add(filaNueva); 

            }
            btn_exportCSV.Enabled = true;
            exportarCSVToolStripMenuItem.Enabled = true;
            modificarProductoToolStripMenuItem.Enabled = true;
            borrarProductoToolStripMenuItem.Enabled = true;

        }

        private void btn_exportCSV_Click(object sender, EventArgs e)
        {

            // crear un streamWriter para poder escribir en el fichero
            // StreamWriter miStrFile = new StreamWriter("C:\\Users\\alumno\\Documents\\ficheroCSV.csv");
            StreamWriter miStrFile = null;

            //crear fichero desde una ventana
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Title = "Elige un fichero";
            sfd.InitialDirectory = @"C:\Users\alumno\Documents";
            sfd.Filter = "Text and CSV Files(*.csv)|*.csv|CSV Files(*.csv)|*.csv|All Files(*.*)|*.*";
            sfd.FilterIndex = 1;
            sfd.RestoreDirectory = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                miStrFile = new StreamWriter(sfd.FileName);

                //Application.DoEvents();

                // crear bucle para añadir cabeceras de tabla y utilizar el separador ","
                for (int i = 0; i < (dgv_productos.Columns.Count) - 2; i++)
                {
                    miStrFile.Write(dgv_productos.Columns[i].HeaderText);
                    if (i != (dgv_productos.Columns.Count)-3)
                    {
                        miStrFile.Write(";");
                    }
                }

                miStrFile.Write(miStrFile.NewLine);// añadir linea

                // Con este bucle recorremos las filas
                foreach (DataGridViewRow dr in dgv_productos.Rows)
                {
                    // Recorremos las columnas de cada pasada de fila del bucle
                    for (int i = 0; i < (dgv_productos.Columns.Count) - 2; i++)
                    {
                        //Escribimos el contenido de cada celda de la fila
                        miStrFile.Write(dr.Cells[i].Value.ToString());

                        if (i != (dgv_productos.Columns.Count) - 3)
                        {
                            miStrFile.Write(";");//añadimos separador
                        }
                    }

                    miStrFile.Write(miStrFile.NewLine);//añadimos linea
                }
                //borra todos los búferes de esta secuencia y hace que todos los datos almacenados en el búfer se escriban en el dispositivo subyacente.
                miStrFile.Flush();
                //Cierra el streamWriter
                miStrFile.Close();


                MessageBox.Show("Fichero CSV creado con exito.");

            }
        }

        private void btn_importCSV_Click(object sender, EventArgs e)
        {
            // crear un streamReader para poder escribir en el fichero
            StreamReader miStrRead = null;

            // Cargar fichero desde una ventana
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Elige un fichero";
            ofd.InitialDirectory = @"C:\Users\alumno\Documents";
            ofd.Filter = "Text and CSV Files(*.csv)|*.csv|CSV Files(*.csv)|*.csv|All Files(*.*)|*.*";
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                miStrRead = new StreamReader(ofd.FileName);

                //Creamos una lista para guardar los datos del CSV
                List<string[]> datosCSV = new List<string[]>();

                string linea;
                string[] fila;
                // Omitimos la 1ª linea que son las cabeceras
                miStrRead.ReadLine();
                //Cargamos la lista con el resto de datos
                while ((linea = miStrRead.ReadLine()) != null)
                {

                    fila = linea.Split(';');
                   // datosCSV.Add(fila);

                    dgv_productos.Rows.Add(fila);                                      
                }
                miStrRead.Close();
            }
            if (dgv_productos.Rows.Count != 0)
            {
                btn_exportCSV.Enabled = true;
                exportarCSVToolStripMenuItem.Enabled = true;
                modificarProductoToolStripMenuItem.Enabled = true;
                borrarProductoToolStripMenuItem.Enabled = true;
            }
            else
            {
                btn_exportCSV.Enabled = false;
                exportarCSVToolStripMenuItem.Enabled = false;
                modificarProductoToolStripMenuItem.Enabled = false;
                borrarProductoToolStripMenuItem.Enabled = false;
            }
        }

        private void modificarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int posicion = dgv_productos.CurrentRow.Index;
            Frm_Prod_modal Frm_modDel = null;

            String nombreProd = dgv_productos.Rows[posicion].Cells[dgv_productos.Columns["Nombre"].Index].Value.ToString();

            if (MessageBox.Show("Seguro que deseas MODIFICAR el producto "+nombreProd.ToUpper()+" ?", "Modificar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Frm_modDel = new Frm_Prod_modal();

                Frm_modDel.cod = dgv_productos.Rows[posicion].Cells[dgv_productos.Columns["cod_prod"].Index].Value.ToString();
                Frm_modDel.nombre = dgv_productos.Rows[posicion].Cells[dgv_productos.Columns["Nombre"].Index].Value.ToString();
                Frm_modDel.Descripcion = dgv_productos.Rows[posicion].Cells[dgv_productos.Columns["Descripción"].Index].Value.ToString();
                Frm_modDel.tipo = dgv_productos.Rows[posicion].Cells[dgv_productos.Columns["Tipo"].Index].Value.ToString();
                Frm_modDel.cantidad = Convert.ToInt16(dgv_productos.Rows[posicion].Cells[dgv_productos.Columns["Cantidad"].Index].Value.ToString());
                Frm_modDel.precio = Convert.ToSingle(dgv_productos.Rows[posicion].Cells[dgv_productos.Columns["Precio"].Index].Value.ToString());

                if (Frm_modDel.ShowDialog() == DialogResult.OK)
                {
                    dgv_productos.Rows[posicion].Cells[dgv_productos.Columns["cod_prod"].Index].Value = Frm_modDel.cod;
                    dgv_productos.Rows[posicion].Cells[dgv_productos.Columns["Nombre"].Index].Value = Frm_modDel.nombre;
                    dgv_productos.Rows[posicion].Cells[dgv_productos.Columns["Descripción"].Index].Value = Frm_modDel.Descripcion;
                    dgv_productos.Rows[posicion].Cells[dgv_productos.Columns["Tipo"].Index].Value = Frm_modDel.tipo;
                    dgv_productos.Rows[posicion].Cells[dgv_productos.Columns["Cantidad"].Index].Value = Frm_modDel.cantidad;
                    dgv_productos.Rows[posicion].Cells[dgv_productos.Columns["Precio"].Index].Value = Frm_modDel.precio;
                }
            }
        }

        private void borrarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int seleccion = dgv_productos.SelectedRows.Count;

            if (seleccion == 0)
            {
                int posicion = dgv_productos.CurrentRow.Index;
                String nombreProd = dgv_productos.Rows[posicion].Cells[dgv_productos.Columns["Nombre"].Index].Value.ToString();
                if (MessageBox.Show("Seguro que deseas borrar el producto " + nombreProd.ToUpper() + " ?", "Borrar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dgv_productos.Rows.RemoveAt(posicion);
                }
            }
            else
            {
                if (MessageBox.Show("Seguro que deseas borrar " + seleccion + " productos ?", "Borrar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow fila in dgv_productos.SelectedRows)
                    {
                        dgv_productos.Rows.Remove(fila);
                    }


                    if (dgv_productos.Rows.Count != 0)
                    {
                        btn_exportCSV.Enabled = true;
                        exportarCSVToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        btn_exportCSV.Enabled = false;
                        exportarCSVToolStripMenuItem.Enabled = false;
                        modificarProductoToolStripMenuItem.Enabled = false;
                        borrarProductoToolStripMenuItem.Enabled = false;
                    }
                }
            }
            
        }
    }
}
