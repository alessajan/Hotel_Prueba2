namespace HotelSol2
{
    partial class AgregarUsuario
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtAp_paterno = new System.Windows.Forms.TextBox();
            this.TxtAp_materno = new System.Windows.Forms.TextBox();
            this.TxtTipo = new System.Windows.Forms.TextBox();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.BttnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido Paterno:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido Materno:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contraseña:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(120, 33);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(232, 22);
            this.TxtNombre.TabIndex = 5;
            // 
            // TxtAp_paterno
            // 
            this.TxtAp_paterno.Location = new System.Drawing.Point(172, 87);
            this.TxtAp_paterno.Name = "TxtAp_paterno";
            this.TxtAp_paterno.Size = new System.Drawing.Size(180, 22);
            this.TxtAp_paterno.TabIndex = 6;
            // 
            // TxtAp_materno
            // 
            this.TxtAp_materno.Location = new System.Drawing.Point(172, 136);
            this.TxtAp_materno.Name = "TxtAp_materno";
            this.TxtAp_materno.Size = new System.Drawing.Size(180, 22);
            this.TxtAp_materno.TabIndex = 7;
            // 
            // TxtTipo
            // 
            this.TxtTipo.Location = new System.Drawing.Point(102, 183);
            this.TxtTipo.Name = "TxtTipo";
            this.TxtTipo.Size = new System.Drawing.Size(250, 22);
            this.TxtTipo.TabIndex = 8;
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.Location = new System.Drawing.Point(139, 224);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.Size = new System.Drawing.Size(213, 22);
            this.TxtContraseña.TabIndex = 9;
            // 
            // BttnAgregar
            // 
            this.BttnAgregar.Location = new System.Drawing.Point(149, 284);
            this.BttnAgregar.Name = "BttnAgregar";
            this.BttnAgregar.Size = new System.Drawing.Size(84, 27);
            this.BttnAgregar.TabIndex = 10;
            this.BttnAgregar.Text = "Agregar";
            this.BttnAgregar.UseVisualStyleBackColor = true;
            this.BttnAgregar.Click += new System.EventHandler(this.BttnAgregar_Click);
            // 
            // AgregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 356);
            this.Controls.Add(this.BttnAgregar);
            this.Controls.Add(this.TxtContraseña);
            this.Controls.Add(this.TxtTipo);
            this.Controls.Add(this.TxtAp_materno);
            this.Controls.Add(this.TxtAp_paterno);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AgregarUsuario";
            this.Text = "AgregarUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtAp_paterno;
        private System.Windows.Forms.TextBox TxtAp_materno;
        private System.Windows.Forms.TextBox TxtTipo;
        private System.Windows.Forms.TextBox TxtContraseña;
        private System.Windows.Forms.Button BttnAgregar;
    }
}