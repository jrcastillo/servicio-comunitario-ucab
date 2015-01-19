namespace SistGestionAdministrativaConsultorioMedicoChuao.Vista
{
    partial class AgregarProductoInventario
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
            this.L_Agregarproducto = new System.Windows.Forms.Label();
            this.L_Aceptar = new System.Windows.Forms.Label();
            this.L_Cancelar = new System.Windows.Forms.Label();
            this.L_Cantidad = new System.Windows.Forms.Label();
            this.L_Producto = new System.Windows.Forms.Label();
            this.CB_Productos = new System.Windows.Forms.ComboBox();
            this.LL_AgregarProducto = new System.Windows.Forms.LinkLabel();
            this.TB_Cantidad = new System.Windows.Forms.TextBox();
            this.B_Aceptar = new System.Windows.Forms.Button();
            this.B_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // L_Agregarproducto
            // 
            this.L_Agregarproducto.AutoSize = true;
            this.L_Agregarproducto.Font = new System.Drawing.Font("Berlin Sans FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Agregarproducto.Location = new System.Drawing.Point(106, 9);
            this.L_Agregarproducto.Name = "L_Agregarproducto";
            this.L_Agregarproducto.Size = new System.Drawing.Size(291, 40);
            this.L_Agregarproducto.TabIndex = 1;
            this.L_Agregarproducto.Text = "Agregar producto";
            // 
            // L_Aceptar
            // 
            this.L_Aceptar.AutoSize = true;
            this.L_Aceptar.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Aceptar.Location = new System.Drawing.Point(103, 287);
            this.L_Aceptar.Name = "L_Aceptar";
            this.L_Aceptar.Size = new System.Drawing.Size(85, 18);
            this.L_Aceptar.TabIndex = 1;
            this.L_Aceptar.Text = "ACEPTAR";
            // 
            // L_Cancelar
            // 
            this.L_Cancelar.AutoSize = true;
            this.L_Cancelar.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Cancelar.Location = new System.Drawing.Point(314, 284);
            this.L_Cancelar.Name = "L_Cancelar";
            this.L_Cancelar.Size = new System.Drawing.Size(97, 18);
            this.L_Cancelar.TabIndex = 2;
            this.L_Cancelar.Text = "CANCELAR";
            // 
            // L_Cantidad
            // 
            this.L_Cantidad.AutoSize = true;
            this.L_Cantidad.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Cantidad.Location = new System.Drawing.Point(12, 83);
            this.L_Cantidad.Name = "L_Cantidad";
            this.L_Cantidad.Size = new System.Drawing.Size(96, 18);
            this.L_Cantidad.TabIndex = 3;
            this.L_Cantidad.Text = "CANTIDAD";
            // 
            // L_Producto
            // 
            this.L_Producto.AutoSize = true;
            this.L_Producto.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Producto.Location = new System.Drawing.Point(145, 83);
            this.L_Producto.Name = "L_Producto";
            this.L_Producto.Size = new System.Drawing.Size(101, 18);
            this.L_Producto.TabIndex = 4;
            this.L_Producto.Text = "PRODUCTO";
            // 
            // CB_Productos
            // 
            this.CB_Productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_Productos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Productos.FormattingEnabled = true;
            this.CB_Productos.Location = new System.Drawing.Point(148, 117);
            this.CB_Productos.Name = "CB_Productos";
            this.CB_Productos.Size = new System.Drawing.Size(339, 26);
            this.CB_Productos.TabIndex = 5;
            this.CB_Productos.Text = "Elija un producto";
            this.CB_Productos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CB_Productos_KeyPress);
            // 
            // LL_AgregarProducto
            // 
            this.LL_AgregarProducto.AutoSize = true;
            this.LL_AgregarProducto.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LL_AgregarProducto.Location = new System.Drawing.Point(145, 161);
            this.LL_AgregarProducto.Name = "LL_AgregarProducto";
            this.LL_AgregarProducto.Size = new System.Drawing.Size(342, 18);
            this.LL_AgregarProducto.TabIndex = 6;
            this.LL_AgregarProducto.TabStop = true;
            this.LL_AgregarProducto.Text = "AGREGAR PRODUCTO NUEVO A LA LISTA";
            // 
            // TB_Cantidad
            // 
            this.TB_Cantidad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Cantidad.Location = new System.Drawing.Point(15, 117);
            this.TB_Cantidad.Name = "TB_Cantidad";
            this.TB_Cantidad.Size = new System.Drawing.Size(93, 26);
            this.TB_Cantidad.TabIndex = 7;
            this.TB_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Cantidad_KeyPress);
            // 
            // B_Aceptar
            // 
            this.B_Aceptar.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.B_Aceptar.FlatAppearance.BorderSize = 0;
            this.B_Aceptar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.B_Aceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.B_Aceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.B_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Aceptar.Image = global::SistGestionAdministrativaConsultorioMedicoChuao.Properties.Resources.Aceptar;
            this.B_Aceptar.Location = new System.Drawing.Point(113, 218);
            this.B_Aceptar.Name = "B_Aceptar";
            this.B_Aceptar.Size = new System.Drawing.Size(75, 63);
            this.B_Aceptar.TabIndex = 8;
            this.B_Aceptar.UseVisualStyleBackColor = true;
            this.B_Aceptar.Click += new System.EventHandler(this.B_Aceptar_Click);
            // 
            // B_Cancelar
            // 
            this.B_Cancelar.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.B_Cancelar.FlatAppearance.BorderSize = 0;
            this.B_Cancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.B_Cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.B_Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.B_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Cancelar.Image = global::SistGestionAdministrativaConsultorioMedicoChuao.Properties.Resources.Cancelar;
            this.B_Cancelar.Location = new System.Drawing.Point(317, 215);
            this.B_Cancelar.Name = "B_Cancelar";
            this.B_Cancelar.Size = new System.Drawing.Size(80, 66);
            this.B_Cancelar.TabIndex = 9;
            this.B_Cancelar.UseVisualStyleBackColor = true;
            this.B_Cancelar.Click += new System.EventHandler(this.B_Cancelar_Click);
            // 
            // AgregarProductoInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(497, 332);
            this.ControlBox = false;
            this.Controls.Add(this.B_Cancelar);
            this.Controls.Add(this.B_Aceptar);
            this.Controls.Add(this.TB_Cantidad);
            this.Controls.Add(this.LL_AgregarProducto);
            this.Controls.Add(this.CB_Productos);
            this.Controls.Add(this.L_Producto);
            this.Controls.Add(this.L_Cantidad);
            this.Controls.Add(this.L_Cancelar);
            this.Controls.Add(this.L_Aceptar);
            this.Controls.Add(this.L_Agregarproducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarProductoInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarProductoInventario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_Agregarproducto;
        private System.Windows.Forms.Label L_Aceptar;
        private System.Windows.Forms.Label L_Cancelar;
        private System.Windows.Forms.Label L_Cantidad;
        private System.Windows.Forms.Label L_Producto;
        private System.Windows.Forms.LinkLabel LL_AgregarProducto;
        private System.Windows.Forms.TextBox TB_Cantidad;
        private System.Windows.Forms.Button B_Aceptar;
        private System.Windows.Forms.Button B_Cancelar;
        protected System.Windows.Forms.ComboBox CB_Productos;
    }
}