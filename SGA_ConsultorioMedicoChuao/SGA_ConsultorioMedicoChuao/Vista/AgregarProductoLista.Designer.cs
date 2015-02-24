namespace SGA_ConsultorioMedicoChuao.Vista
{
    partial class AgregarProductoLista
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
            this.L_AgregarProducto = new System.Windows.Forms.Label();
            this.TB_Nombre = new System.Windows.Forms.TextBox();
            this.B_Aceptar = new System.Windows.Forms.Button();
            this.L_NombreProducto = new System.Windows.Forms.Label();
            this.L_Cancelar = new System.Windows.Forms.Label();
            this.L_Aceptar = new System.Windows.Forms.Label();
            this.B_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // L_AgregarProducto
            // 
            this.L_AgregarProducto.AutoSize = true;
            this.L_AgregarProducto.Font = new System.Drawing.Font("Berlin Sans FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_AgregarProducto.Location = new System.Drawing.Point(42, 24);
            this.L_AgregarProducto.Name = "L_AgregarProducto";
            this.L_AgregarProducto.Size = new System.Drawing.Size(291, 40);
            this.L_AgregarProducto.TabIndex = 0;
            this.L_AgregarProducto.Text = "Agregar producto";
            // 
            // TB_Nombre
            // 
            this.TB_Nombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Nombre.Location = new System.Drawing.Point(14, 140);
            this.TB_Nombre.Name = "TB_Nombre";
            this.TB_Nombre.Size = new System.Drawing.Size(333, 26);
            this.TB_Nombre.TabIndex = 1;
            this.TB_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Nombre_KeyPress);
            // 
            // B_Aceptar
            // 
            this.B_Aceptar.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.B_Aceptar.FlatAppearance.BorderSize = 0;
            this.B_Aceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.B_Aceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.B_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Aceptar.Image = global::SGA_ConsultorioMedicoChuao.Properties.Resources.Aceptar;
            this.B_Aceptar.Location = new System.Drawing.Point(55, 211);
            this.B_Aceptar.Name = "B_Aceptar";
            this.B_Aceptar.Size = new System.Drawing.Size(81, 63);
            this.B_Aceptar.TabIndex = 2;
            this.B_Aceptar.UseVisualStyleBackColor = true;
            this.B_Aceptar.Click += new System.EventHandler(this.B_Aceptar_Click);
            // 
            // L_NombreProducto
            // 
            this.L_NombreProducto.AutoSize = true;
            this.L_NombreProducto.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_NombreProducto.Location = new System.Drawing.Point(12, 101);
            this.L_NombreProducto.Name = "L_NombreProducto";
            this.L_NombreProducto.Size = new System.Drawing.Size(212, 18);
            this.L_NombreProducto.TabIndex = 4;
            this.L_NombreProducto.Text = "NOMBRE DEL PRODUCTO";
            // 
            // L_Cancelar
            // 
            this.L_Cancelar.AutoSize = true;
            this.L_Cancelar.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Cancelar.Location = new System.Drawing.Point(204, 277);
            this.L_Cancelar.Name = "L_Cancelar";
            this.L_Cancelar.Size = new System.Drawing.Size(97, 18);
            this.L_Cancelar.TabIndex = 5;
            this.L_Cancelar.Text = "CANCELAR";
            // 
            // L_Aceptar
            // 
            this.L_Aceptar.AutoSize = true;
            this.L_Aceptar.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Aceptar.Location = new System.Drawing.Point(47, 277);
            this.L_Aceptar.Name = "L_Aceptar";
            this.L_Aceptar.Size = new System.Drawing.Size(85, 18);
            this.L_Aceptar.TabIndex = 6;
            this.L_Aceptar.Text = "ACEPTAR";
            // 
            // B_Cancelar
            // 
            this.B_Cancelar.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.B_Cancelar.FlatAppearance.BorderSize = 0;
            this.B_Cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.B_Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.B_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Cancelar.Image = global::SGA_ConsultorioMedicoChuao.Properties.Resources.Cancelar;
            this.B_Cancelar.Location = new System.Drawing.Point(211, 211);
            this.B_Cancelar.Name = "B_Cancelar";
            this.B_Cancelar.Size = new System.Drawing.Size(84, 63);
            this.B_Cancelar.TabIndex = 3;
            this.B_Cancelar.UseVisualStyleBackColor = true;
            this.B_Cancelar.Click += new System.EventHandler(this.B_Cancelar_Click);
            // 
            // AgregarProductoLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(362, 309);
            this.ControlBox = false;
            this.Controls.Add(this.L_Aceptar);
            this.Controls.Add(this.L_Cancelar);
            this.Controls.Add(this.L_NombreProducto);
            this.Controls.Add(this.B_Cancelar);
            this.Controls.Add(this.B_Aceptar);
            this.Controls.Add(this.TB_Nombre);
            this.Controls.Add(this.L_AgregarProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarProductoLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarProductoLista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_AgregarProducto;
        private System.Windows.Forms.TextBox TB_Nombre;
        private System.Windows.Forms.Button B_Aceptar;
        private System.Windows.Forms.Button B_Cancelar;
        private System.Windows.Forms.Label L_NombreProducto;
        private System.Windows.Forms.Label L_Cancelar;
        private System.Windows.Forms.Label L_Aceptar;
    }
}