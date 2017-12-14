namespace ej_productos
{
    partial class Frm_Prod_modal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.txtB_codigoProd = new System.Windows.Forms.TextBox();
            this.txtB_descripcion = new System.Windows.Forms.TextBox();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.txtB_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbox_tipo = new System.Windows.Forms.ComboBox();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.nud_cantidad = new System.Windows.Forms.NumericUpDown();
            this.nud_precio = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_precio)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(12, 13);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(74, 13);
            this.lbl_codigo.TabIndex = 0;
            this.lbl_codigo.Text = "Cod. producto";
            // 
            // txtB_codigoProd
            // 
            this.txtB_codigoProd.Location = new System.Drawing.Point(117, 10);
            this.txtB_codigoProd.Name = "txtB_codigoProd";
            this.txtB_codigoProd.Size = new System.Drawing.Size(155, 20);
            this.txtB_codigoProd.TabIndex = 1;
            // 
            // txtB_descripcion
            // 
            this.txtB_descripcion.Location = new System.Drawing.Point(117, 66);
            this.txtB_descripcion.Name = "txtB_descripcion";
            this.txtB_descripcion.Size = new System.Drawing.Size(155, 20);
            this.txtB_descripcion.TabIndex = 3;
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Location = new System.Drawing.Point(12, 69);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(63, 13);
            this.lbl_descripcion.TabIndex = 2;
            this.lbl_descripcion.Text = "Descripción";
            // 
            // txtB_nombre
            // 
            this.txtB_nombre.Location = new System.Drawing.Point(117, 38);
            this.txtB_nombre.Name = "txtB_nombre";
            this.txtB_nombre.Size = new System.Drawing.Size(155, 20);
            this.txtB_nombre.TabIndex = 2;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(12, 41);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre.TabIndex = 4;
            this.lbl_nombre.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tipo";
            // 
            // cmbox_tipo
            // 
            this.cmbox_tipo.FormattingEnabled = true;
            this.cmbox_tipo.Items.AddRange(new object[] {
            "Elige una Tipo",
            "Consumibles",
            "Placas Base",
            "Graficas",
            "Memoria RAM"});
            this.cmbox_tipo.Location = new System.Drawing.Point(117, 94);
            this.cmbox_tipo.Name = "cmbox_tipo";
            this.cmbox_tipo.Size = new System.Drawing.Size(155, 21);
            this.cmbox_tipo.TabIndex = 4;
            this.cmbox_tipo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Location = new System.Drawing.Point(12, 126);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(49, 13);
            this.lbl_cantidad.TabIndex = 8;
            this.lbl_cantidad.Text = "Cantidad";
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Location = new System.Drawing.Point(12, 154);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(37, 13);
            this.lbl_precio.TabIndex = 10;
            this.lbl_precio.Text = "Precio";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(15, 193);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(112, 36);
            this.btn_cancelar.TabIndex = 8;
            this.btn_cancelar.Text = "CANCELAR";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.Location = new System.Drawing.Point(160, 192);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(112, 36);
            this.btn_aceptar.TabIndex = 7;
            this.btn_aceptar.Text = "ACEPTAR";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // nud_cantidad
            // 
            this.nud_cantidad.Location = new System.Drawing.Point(117, 122);
            this.nud_cantidad.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nud_cantidad.Name = "nud_cantidad";
            this.nud_cantidad.Size = new System.Drawing.Size(155, 20);
            this.nud_cantidad.TabIndex = 5;
            // 
            // nud_precio
            // 
            this.nud_precio.DecimalPlaces = 2;
            this.nud_precio.Increment = new decimal(new int[] {
            15,
            0,
            0,
            131072});
            this.nud_precio.Location = new System.Drawing.Point(117, 146);
            this.nud_precio.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nud_precio.Name = "nud_precio";
            this.nud_precio.Size = new System.Drawing.Size(155, 20);
            this.nud_precio.TabIndex = 6;
            // 
            // Frm_Prod_modal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.nud_precio);
            this.Controls.Add(this.nud_cantidad);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.lbl_precio);
            this.Controls.Add(this.lbl_cantidad);
            this.Controls.Add(this.cmbox_tipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtB_nombre);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.txtB_descripcion);
            this.Controls.Add(this.lbl_descripcion);
            this.Controls.Add(this.txtB_codigoProd);
            this.Controls.Add(this.lbl_codigo);
            this.Name = "Frm_Prod_modal";
            this.Text = "Frm_Prod_modal";
            this.Load += new System.EventHandler(this.Frm_Prod_modal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_precio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.TextBox txtB_codigoProd;
        private System.Windows.Forms.TextBox txtB_descripcion;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.TextBox txtB_nombre;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbox_tipo;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.NumericUpDown nud_cantidad;
        private System.Windows.Forms.NumericUpDown nud_precio;
    }
}