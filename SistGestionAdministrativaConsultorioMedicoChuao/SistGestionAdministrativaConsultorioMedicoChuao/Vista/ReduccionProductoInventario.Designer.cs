namespace SistGestionAdministrativaConsultorioMedicoChuao.Vista
{
    partial class ReduccionProductoInventario
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
            this.L_DisminucionInventario = new System.Windows.Forms.Label();
            this.L_ProductoActual = new System.Windows.Forms.Label();
            this.L_CantidadActual = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_Cantidad = new System.Windows.Forms.TextBox();
            this.B_Aceptar = new System.Windows.Forms.Button();
            this.B_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // L_DisminucionInventario
            // 
            this.L_DisminucionInventario.AutoSize = true;
            this.L_DisminucionInventario.Font = new System.Drawing.Font("Berlin Sans FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_DisminucionInventario.Location = new System.Drawing.Point(71, 22);
            this.L_DisminucionInventario.Name = "L_DisminucionInventario";
            this.L_DisminucionInventario.Size = new System.Drawing.Size(414, 40);
            this.L_DisminucionInventario.TabIndex = 0;
            this.L_DisminucionInventario.Text = "Disminución en inventario";
            // 
            // L_ProductoActual
            // 
            this.L_ProductoActual.AutoSize = true;
            this.L_ProductoActual.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_ProductoActual.Location = new System.Drawing.Point(12, 94);
            this.L_ProductoActual.Name = "L_ProductoActual";
            this.L_ProductoActual.Size = new System.Drawing.Size(0, 22);
            this.L_ProductoActual.TabIndex = 1;
            // 
            // L_CantidadActual
            // 
            this.L_CantidadActual.AutoSize = true;
            this.L_CantidadActual.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_CantidadActual.Location = new System.Drawing.Point(12, 156);
            this.L_CantidadActual.Name = "L_CantidadActual";
            this.L_CantidadActual.Size = new System.Drawing.Size(0, 22);
            this.L_CantidadActual.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(380, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Introduzca la cantidad que desea quitar ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(146, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "ACEPTAR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(326, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "CANCELAR";
            // 
            // TB_Cantidad
            // 
            this.TB_Cantidad.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Cantidad.Location = new System.Drawing.Point(391, 213);
            this.TB_Cantidad.Name = "TB_Cantidad";
            this.TB_Cantidad.Size = new System.Drawing.Size(71, 29);
            this.TB_Cantidad.TabIndex = 6;
            this.TB_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Cantidad_KeyPress);
            // 
            // B_Aceptar
            // 
            this.B_Aceptar.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.B_Aceptar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.B_Aceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.B_Aceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.B_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Aceptar.Image = global::SistGestionAdministrativaConsultorioMedicoChuao.Properties.Resources.Aceptar;
            this.B_Aceptar.Location = new System.Drawing.Point(152, 279);
            this.B_Aceptar.Name = "B_Aceptar";
            this.B_Aceptar.Size = new System.Drawing.Size(81, 60);
            this.B_Aceptar.TabIndex = 7;
            this.B_Aceptar.UseVisualStyleBackColor = true;
            this.B_Aceptar.Click += new System.EventHandler(this.B_Aceptar_Click);
            // 
            // B_Cancelar
            // 
            this.B_Cancelar.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.B_Cancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.B_Cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.B_Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.B_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Cancelar.Image = global::SistGestionAdministrativaConsultorioMedicoChuao.Properties.Resources.Cancelar;
            this.B_Cancelar.Location = new System.Drawing.Point(331, 279);
            this.B_Cancelar.Name = "B_Cancelar";
            this.B_Cancelar.Size = new System.Drawing.Size(81, 60);
            this.B_Cancelar.TabIndex = 8;
            this.B_Cancelar.UseVisualStyleBackColor = true;
            this.B_Cancelar.Click += new System.EventHandler(this.B_Cancelar_Click);
            // 
            // ReduccionProductoInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(554, 386);
            this.ControlBox = false;
            this.Controls.Add(this.B_Cancelar);
            this.Controls.Add(this.B_Aceptar);
            this.Controls.Add(this.TB_Cantidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.L_CantidadActual);
            this.Controls.Add(this.L_ProductoActual);
            this.Controls.Add(this.L_DisminucionInventario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReduccionProductoInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReduccionProductoInventario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_DisminucionInventario;
        private System.Windows.Forms.Label L_ProductoActual;
        private System.Windows.Forms.Label L_CantidadActual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_Cantidad;
        private System.Windows.Forms.Button B_Aceptar;
        private System.Windows.Forms.Button B_Cancelar;
    }
}