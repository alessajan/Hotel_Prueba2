namespace HotelSol2
{
    partial class IngresarHabitacion
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
            this.label12 = new System.Windows.Forms.Label();
            this.CBEstado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNumHab = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CBTipoHabit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BttnGuardarHabi = new System.Windows.Forms.Button();
            this.BttnCancelar1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 24);
            this.label12.TabIndex = 42;
            this.label12.Text = "HABITACIÓN";
            // 
            // CBEstado
            // 
            this.CBEstado.FormattingEnabled = true;
            this.CBEstado.Items.AddRange(new object[] {
            "Libre",
            "Ocupada"});
            this.CBEstado.Location = new System.Drawing.Point(189, 161);
            this.CBEstado.Name = "CBEstado";
            this.CBEstado.Size = new System.Drawing.Size(121, 24);
            this.CBEstado.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 40;
            this.label9.Text = "Estado:";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(189, 128);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(121, 22);
            this.TxtPrecio.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Precio:\r\n";
            // 
            // TxtNumHab
            // 
            this.TxtNumHab.Location = new System.Drawing.Point(189, 91);
            this.TxtNumHab.Name = "TxtNumHab";
            this.TxtNumHab.Size = new System.Drawing.Size(121, 22);
            this.TxtNumHab.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Número Habitación:";
            // 
            // CBTipoHabit
            // 
            this.CBTipoHabit.FormattingEnabled = true;
            this.CBTipoHabit.Items.AddRange(new object[] {
            "Sencilla",
            "Doble",
            "Suite"});
            this.CBTipoHabit.Location = new System.Drawing.Point(189, 51);
            this.CBTipoHabit.Name = "CBTipoHabit";
            this.CBTipoHabit.Size = new System.Drawing.Size(121, 24);
            this.CBTipoHabit.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Tipo de Habitación:";
            // 
            // BttnGuardarHabi
            // 
            this.BttnGuardarHabi.Location = new System.Drawing.Point(388, 73);
            this.BttnGuardarHabi.Name = "BttnGuardarHabi";
            this.BttnGuardarHabi.Size = new System.Drawing.Size(102, 33);
            this.BttnGuardarHabi.TabIndex = 43;
            this.BttnGuardarHabi.Text = "Guardar";
            this.BttnGuardarHabi.UseVisualStyleBackColor = true;
            this.BttnGuardarHabi.Click += new System.EventHandler(this.BttnGuardarHabi_Click);
            // 
            // BttnCancelar1
            // 
            this.BttnCancelar1.Location = new System.Drawing.Point(388, 142);
            this.BttnCancelar1.Name = "BttnCancelar1";
            this.BttnCancelar1.Size = new System.Drawing.Size(102, 33);
            this.BttnCancelar1.TabIndex = 44;
            this.BttnCancelar1.Text = "Cancelar";
            this.BttnCancelar1.UseVisualStyleBackColor = true;
            // 
            // IngresarHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 231);
            this.Controls.Add(this.BttnCancelar1);
            this.Controls.Add(this.BttnGuardarHabi);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.CBEstado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNumHab);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBTipoHabit);
            this.Controls.Add(this.label1);
            this.Name = "IngresarHabitacion";
            this.Text = "IngresarHabitacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox CBEstado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNumHab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBTipoHabit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BttnGuardarHabi;
        private System.Windows.Forms.Button BttnCancelar1;
    }
}