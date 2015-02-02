namespace SistGestionAdministrativaConsultorioMedicoChuao.Vista
{
    partial class ModificarProductoInventario
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
            this.label1 = new System.Windows.Forms.Label();
            this.L_Guardar = new System.Windows.Forms.Label();
            this.l_Cancelar = new System.Windows.Forms.Label();
            this.L_Producto = new System.Windows.Forms.Label();
            this.L_Cantidad = new System.Windows.Forms.Label();
            this.TB_Producto = new System.Windows.Forms.TextBox();
            this.TB_Cantidad = new System.Windows.Forms.TextBox();
            this.B_Guardar = new System.Windows.Forms.Button();
            this.B_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(621, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modificación de producto del inventario";
            // 
            // L_Guardar
            // 
            this.L_Guardar.AutoSize = true;
            this.L_Guardar.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Guardar.Location = new System.Drawing.Point(203, 294);
            this.L_Guardar.Name = "L_Guardar";
            this.L_Guardar.Size = new System.Drawing.Size(91, 18);
            this.L_Guardar.TabIndex = 1;
            this.L_Guardar.Text = "GUARDAR";
            // 
            // l_Cancelar
            // 
            this.l_Cancelar.AutoSize = true;
            this.l_Cancelar.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Cancelar.Location = new System.Drawing.Point(396, 294);
            this.l_Cancelar.Name = "l_Cancelar";
            this.l_Cancelar.Size = new System.Drawing.Size(97, 18);
            this.l_Cancelar.TabIndex = 2;
            this.l_Cancelar.Text = "CANCELAR";
            // 
            // L_Producto
            // 
            this.L_Producto.AutoSize = true;
            this.L_Producto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Producto.Location = new System.Drawing.Point(12, 102);
            this.L_Producto.Name = "L_Producto";
            this.L_Producto.Size = new System.Drawing.Size(90, 19);
            this.L_Producto.TabIndex = 3;
            this.L_Producto.Text = "Producto: ";
            // 
            // L_Cantidad
            // 
            this.L_Cantidad.AutoSize = true;
            this.L_Cantidad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Cantidad.Location = new System.Drawing.Point(12, 173);
            this.L_Cantidad.Name = "L_Cantidad";
            this.L_Cantidad.Size = new System.Drawing.Size(88, 19);
            this.L_Cantidad.TabIndex = 4;
            this.L_Cantidad.Text = "Cantidad: ";
            // 
            // TB_Producto
            // 
            this.TB_Producto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Producto.Location = new System.Drawing.Point(106, 99);
            this.TB_Producto.Name = "TB_Producto";
            this.TB_Producto.Size = new System.Drawing.Size(308, 26);
            this.TB_Producto.TabIndex = 5;
            this.TB_Producto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Producto_KeyPress);
            // 
            // TB_Cantidad
            // 
            this.TB_Cantidad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Cantidad.Location = new System.Drawing.Point(106, 170);
            this.TB_Cantidad.Name = "TB_Cantidad";
            this.TB_Cantidad.Size = new System.Drawing.Size(65, 26);
            this.TB_Cantidad.TabIndex = 6;
            this.TB_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Cantidad_KeyPress);
            // 
            // B_Guardar
            // 
            this.B_Guardar.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.B_Guardar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.B_Guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.B_Guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.B_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Guardar.Image = global::SistGestionAdministrativaConsultorioMedicoChuao.Properties.Resources.Guardar;
            this.B_Guardar.Location = new System.Drawing.Point(202, 228);
            this.B_Guardar.Name = "B_Guardar";
            this.B_Guardar.Size = new System.Drawing.Size(85, 56);
            this.B_Guardar.TabIndex = 7;
            this.B_Guardar.UseVisualStyleBackColor = true;
            this.B_Guardar.Click += new System.EventHandler(this.B_Guardar_Click);
            // 
            // B_Cancelar
            // 
            this.B_Cancelar.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.B_Cancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.B_Cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.B_Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.B_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Cancelar.Image = global::SistGestionAdministrativaConsultorioMedicoChuao.Properties.Resources.Cancelar;
            this.B_Cancelar.Location = new System.Drawing.Point(402, 228);
            this.B_Cancelar.Name = "B_Cancelar";
            this.B_Cancelar.Size = new System.Drawing.Size(85, 56);
            this.B_Cancelar.TabIndex = 8;
            this.B_Cancelar.UseVisualStyleBackColor = true;
            this.B_Cancelar.Click += new System.EventHandler(this.B_Cancelar_Click);
            // 
            // ModificarProductoInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(689, 332);
            this.ControlBox = false;
            this.Controls.Add(this.B_Cancelar);
            this.Controls.Add(this.B_Guardar);
            this.Controls.Add(this.TB_Cantidad);
            this.Controls.Add(this.TB_Producto);
            this.Controls.Add(this.L_Cantidad);
            this.Controls.Add(this.L_Producto);
            this.Controls.Add(this.l_Cancelar);
            this.Controls.Add(this.L_Guardar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificarProductoInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarProductoInventario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label L_Guardar;
        private System.Windows.Forms.Label l_Cancelar;
        private System.Windows.Forms.Label L_Producto;
        private System.Windows.Forms.Label L_Cantidad;
        private System.Windows.Forms.TextBox TB_Producto;
        private System.Windows.Forms.TextBox TB_Cantidad;
        private System.Windows.Forms.Button B_Guardar;
        private System.Windows.Forms.Button B_Cancelar;
    }
}