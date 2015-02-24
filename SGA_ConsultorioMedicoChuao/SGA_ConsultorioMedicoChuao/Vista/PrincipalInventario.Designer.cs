namespace SGA_ConsultorioMedicoChuao.Vista
{
    partial class PrincipalInventario
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
            this.L_PrincipalInventario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.L_Quitar = new System.Windows.Forms.Label();
            this.L_Modificar = new System.Windows.Forms.Label();
            this.L_Salir = new System.Windows.Forms.Label();
            this.LB_Inventario = new System.Windows.Forms.ListBox();
            this.B_Modificar = new System.Windows.Forms.Button();
            this.B_Salir = new System.Windows.Forms.Button();
            this.B_Quitar = new System.Windows.Forms.Button();
            this.B_Agregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // L_PrincipalInventario
            // 
            this.L_PrincipalInventario.AutoSize = true;
            this.L_PrincipalInventario.Font = new System.Drawing.Font("Berlin Sans FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_PrincipalInventario.Location = new System.Drawing.Point(540, 7);
            this.L_PrincipalInventario.Name = "L_PrincipalInventario";
            this.L_PrincipalInventario.Size = new System.Drawing.Size(179, 40);
            this.L_PrincipalInventario.TabIndex = 0;
            this.L_PrincipalInventario.Text = "Inventario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 549);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "AGREGAR PRODUCTO(S)";
            // 
            // L_Quitar
            // 
            this.L_Quitar.AutoSize = true;
            this.L_Quitar.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Quitar.Location = new System.Drawing.Point(446, 549);
            this.L_Quitar.Name = "L_Quitar";
            this.L_Quitar.Size = new System.Drawing.Size(189, 18);
            this.L_Quitar.TabIndex = 2;
            this.L_Quitar.Text = "QUITAR PRODUCTO(S)";
            // 
            // L_Modificar
            // 
            this.L_Modificar.AutoSize = true;
            this.L_Modificar.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Modificar.Location = new System.Drawing.Point(709, 551);
            this.L_Modificar.Name = "L_Modificar";
            this.L_Modificar.Size = new System.Drawing.Size(200, 18);
            this.L_Modificar.TabIndex = 3;
            this.L_Modificar.Text = "MODIFICAR PRODUCTO";
            // 
            // L_Salir
            // 
            this.L_Salir.AutoSize = true;
            this.L_Salir.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Salir.Location = new System.Drawing.Point(983, 549);
            this.L_Salir.Name = "L_Salir";
            this.L_Salir.Size = new System.Drawing.Size(55, 18);
            this.L_Salir.TabIndex = 4;
            this.L_Salir.Text = "SALIR";
            // 
            // LB_Inventario
            // 
            this.LB_Inventario.BackColor = System.Drawing.Color.MediumTurquoise;
            this.LB_Inventario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Inventario.FormattingEnabled = true;
            this.LB_Inventario.ItemHeight = 19;
            this.LB_Inventario.Location = new System.Drawing.Point(12, 51);
            this.LB_Inventario.Name = "LB_Inventario";
            this.LB_Inventario.Size = new System.Drawing.Size(1233, 422);
            this.LB_Inventario.TabIndex = 5;
            // 
            // B_Modificar
            // 
            this.B_Modificar.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.B_Modificar.FlatAppearance.BorderSize = 0;
            this.B_Modificar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.B_Modificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.B_Modificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.B_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Modificar.Image = global::SGA_ConsultorioMedicoChuao.Properties.Resources.Modificar;
            this.B_Modificar.Location = new System.Drawing.Point(757, 489);
            this.B_Modificar.Name = "B_Modificar";
            this.B_Modificar.Size = new System.Drawing.Size(97, 59);
            this.B_Modificar.TabIndex = 8;
            this.B_Modificar.UseVisualStyleBackColor = true;
            this.B_Modificar.Click += new System.EventHandler(this.B_Modificar_Click);
            // 
            // B_Salir
            // 
            this.B_Salir.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.B_Salir.FlatAppearance.BorderSize = 0;
            this.B_Salir.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.B_Salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.B_Salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.B_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Salir.Image = global::SGA_ConsultorioMedicoChuao.Properties.Resources.Cancelar;
            this.B_Salir.Location = new System.Drawing.Point(960, 489);
            this.B_Salir.Name = "B_Salir";
            this.B_Salir.Size = new System.Drawing.Size(97, 55);
            this.B_Salir.TabIndex = 9;
            this.B_Salir.UseVisualStyleBackColor = true;
            this.B_Salir.Click += new System.EventHandler(this.B_Salir_Click);
            // 
            // B_Quitar
            // 
            this.B_Quitar.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.B_Quitar.FlatAppearance.BorderSize = 0;
            this.B_Quitar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.B_Quitar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.B_Quitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.B_Quitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Quitar.Image = global::SGA_ConsultorioMedicoChuao.Properties.Resources.Quitar;
            this.B_Quitar.Location = new System.Drawing.Point(489, 497);
            this.B_Quitar.Name = "B_Quitar";
            this.B_Quitar.Size = new System.Drawing.Size(104, 47);
            this.B_Quitar.TabIndex = 7;
            this.B_Quitar.UseVisualStyleBackColor = true;
            this.B_Quitar.Click += new System.EventHandler(this.B_Quitar_Click);
            // 
            // B_Agregar
            // 
            this.B_Agregar.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.B_Agregar.FlatAppearance.BorderSize = 0;
            this.B_Agregar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.B_Agregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.B_Agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.B_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Agregar.Image = global::SGA_ConsultorioMedicoChuao.Properties.Resources.Agregar;
            this.B_Agregar.Location = new System.Drawing.Point(198, 483);
            this.B_Agregar.Name = "B_Agregar";
            this.B_Agregar.Size = new System.Drawing.Size(100, 61);
            this.B_Agregar.TabIndex = 6;
            this.B_Agregar.UseVisualStyleBackColor = true;
            this.B_Agregar.Click += new System.EventHandler(this.B_Agregar_Click);
            // 
            // PrincipalInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1256, 576);
            this.ControlBox = false;
            this.Controls.Add(this.B_Salir);
            this.Controls.Add(this.B_Modificar);
            this.Controls.Add(this.B_Quitar);
            this.Controls.Add(this.B_Agregar);
            this.Controls.Add(this.LB_Inventario);
            this.Controls.Add(this.L_Salir);
            this.Controls.Add(this.L_Modificar);
            this.Controls.Add(this.L_Quitar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.L_PrincipalInventario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrincipalInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrincipalInventario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_PrincipalInventario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label L_Quitar;
        private System.Windows.Forms.Label L_Modificar;
        private System.Windows.Forms.Label L_Salir;
        private System.Windows.Forms.ListBox LB_Inventario;
        private System.Windows.Forms.Button B_Agregar;
        private System.Windows.Forms.Button B_Quitar;
        private System.Windows.Forms.Button B_Modificar;
        private System.Windows.Forms.Button B_Salir;
    }
}