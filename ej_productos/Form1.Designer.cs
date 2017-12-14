namespace ej_productos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgv_productos = new System.Windows.Forms.DataGridView();
            this.Cod_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Borrar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_anyadir = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_exportCSV = new System.Windows.Forms.Button();
            this.btn_importCSV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_productos
            // 
            this.dgv_productos.AllowUserToAddRows = false;
            this.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod_prod,
            this.Nombre,
            this.Descripción,
            this.Tipo,
            this.Cantidad,
            this.Precio,
            this.Modificar,
            this.Borrar});
            this.dgv_productos.Location = new System.Drawing.Point(12, 27);
            this.dgv_productos.Name = "dgv_productos";
            this.dgv_productos.Size = new System.Drawing.Size(844, 193);
            this.dgv_productos.TabIndex = 0;
            this.dgv_productos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_productos_CellContentClick);
            // 
            // Cod_prod
            // 
            this.Cod_prod.Frozen = true;
            this.Cod_prod.HeaderText = "Cod_prod";
            this.Cod_prod.Name = "Cod_prod";
            // 
            // Nombre
            // 
            this.Nombre.Frozen = true;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Descripción
            // 
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.Name = "Descripción";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Modificar
            // 
            this.Modificar.HeaderText = "";
            this.Modificar.Image = ((System.Drawing.Image)(resources.GetObject("Modificar.Image")));
            this.Modificar.Name = "Modificar";
            // 
            // Borrar
            // 
            this.Borrar.HeaderText = "";
            this.Borrar.Image = global::ej_productos.Properties.Resources.borrar;
            this.Borrar.Name = "Borrar";
            // 
            // btn_anyadir
            // 
            this.btn_anyadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_anyadir.Location = new System.Drawing.Point(722, 236);
            this.btn_anyadir.Name = "btn_anyadir";
            this.btn_anyadir.Size = new System.Drawing.Size(135, 42);
            this.btn_anyadir.TabIndex = 1;
            this.btn_anyadir.Text = "AÑADIR";
            this.btn_anyadir.UseVisualStyleBackColor = true;
            this.btn_anyadir.Click += new System.EventHandler(this.btn_anyadir_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.productosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(872, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarCSVToolStripMenuItem,
            this.importarCSVToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // exportarCSVToolStripMenuItem
            // 
            this.exportarCSVToolStripMenuItem.Enabled = false;
            this.exportarCSVToolStripMenuItem.Name = "exportarCSVToolStripMenuItem";
            this.exportarCSVToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportarCSVToolStripMenuItem.Text = "Exportar CSV";
            this.exportarCSVToolStripMenuItem.Click += new System.EventHandler(this.btn_exportCSV_Click);
            // 
            // importarCSVToolStripMenuItem
            // 
            this.importarCSVToolStripMenuItem.Name = "importarCSVToolStripMenuItem";
            this.importarCSVToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.importarCSVToolStripMenuItem.Text = "Importar CSV";
            this.importarCSVToolStripMenuItem.Click += new System.EventHandler(this.btn_importCSV_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirProductoToolStripMenuItem,
            this.modificarProductoToolStripMenuItem,
            this.borrarProductoToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // añadirProductoToolStripMenuItem
            // 
            this.añadirProductoToolStripMenuItem.Name = "añadirProductoToolStripMenuItem";
            this.añadirProductoToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.añadirProductoToolStripMenuItem.Text = "Añadir producto";
            this.añadirProductoToolStripMenuItem.Click += new System.EventHandler(this.btn_anyadir_Click);
            // 
            // modificarProductoToolStripMenuItem
            // 
            this.modificarProductoToolStripMenuItem.Enabled = false;
            this.modificarProductoToolStripMenuItem.Name = "modificarProductoToolStripMenuItem";
            this.modificarProductoToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.modificarProductoToolStripMenuItem.Text = "Modificar producto";
            this.modificarProductoToolStripMenuItem.Click += new System.EventHandler(this.modificarProductoToolStripMenuItem_Click);
            // 
            // borrarProductoToolStripMenuItem
            // 
            this.borrarProductoToolStripMenuItem.Enabled = false;
            this.borrarProductoToolStripMenuItem.Name = "borrarProductoToolStripMenuItem";
            this.borrarProductoToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.borrarProductoToolStripMenuItem.Text = "Borrar producto";
            this.borrarProductoToolStripMenuItem.Click += new System.EventHandler(this.borrarProductoToolStripMenuItem_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Modificar";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Borrar";
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // btn_exportCSV
            // 
            this.btn_exportCSV.Enabled = false;
            this.btn_exportCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exportCSV.Location = new System.Drawing.Point(13, 236);
            this.btn_exportCSV.Name = "btn_exportCSV";
            this.btn_exportCSV.Size = new System.Drawing.Size(135, 42);
            this.btn_exportCSV.TabIndex = 3;
            this.btn_exportCSV.Text = "EXPORTAR CSV";
            this.btn_exportCSV.UseVisualStyleBackColor = true;
            this.btn_exportCSV.Click += new System.EventHandler(this.btn_exportCSV_Click);
            // 
            // btn_importCSV
            // 
            this.btn_importCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_importCSV.Location = new System.Drawing.Point(180, 236);
            this.btn_importCSV.Name = "btn_importCSV";
            this.btn_importCSV.Size = new System.Drawing.Size(135, 42);
            this.btn_importCSV.TabIndex = 4;
            this.btn_importCSV.Text = "IMPORTAR CSV";
            this.btn_importCSV.UseVisualStyleBackColor = true;
            this.btn_importCSV.Click += new System.EventHandler(this.btn_importCSV_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 290);
            this.Controls.Add(this.btn_importCSV);
            this.Controls.Add(this.btn_exportCSV);
            this.Controls.Add(this.btn_anyadir);
            this.Controls.Add(this.dgv_productos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_productos;
        private System.Windows.Forms.Button btn_anyadir;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarProductoToolStripMenuItem;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewImageColumn Modificar;
        private System.Windows.Forms.DataGridViewImageColumn Borrar;
        private System.Windows.Forms.Button btn_exportCSV;
        private System.Windows.Forms.Button btn_importCSV;
    }
}

