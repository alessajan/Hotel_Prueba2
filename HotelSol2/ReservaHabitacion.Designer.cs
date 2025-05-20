namespace HotelSol2
{
    partial class ReservaHabitacion
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
            this.label10 = new System.Windows.Forms.Label();
            this.BttnRegistrar = new System.Windows.Forms.Button();
            this.BttnCancelar = new System.Windows.Forms.Button();
            this.BttnRegresar = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.DTPIngreso = new System.Windows.Forms.DateTimePicker();
            this.DTPSalida = new System.Windows.Forms.DateTimePicker();
            this.DGVHabi = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.DVGCliente = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTotalPagar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DGVUsers = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.CMBTipoPago = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVHabi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DVGCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(615, 341);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Fecha de Ingreso:";
            // 
            // BttnRegistrar
            // 
            this.BttnRegistrar.Location = new System.Drawing.Point(280, 532);
            this.BttnRegistrar.Name = "BttnRegistrar";
            this.BttnRegistrar.Size = new System.Drawing.Size(84, 32);
            this.BttnRegistrar.TabIndex = 20;
            this.BttnRegistrar.Text = "Registrar";
            this.BttnRegistrar.UseVisualStyleBackColor = true;
            this.BttnRegistrar.Click += new System.EventHandler(this.BttnRegistrar_Click);
            // 
            // BttnCancelar
            // 
            this.BttnCancelar.BackColor = System.Drawing.Color.Brown;
            this.BttnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BttnCancelar.Location = new System.Drawing.Point(748, 532);
            this.BttnCancelar.Name = "BttnCancelar";
            this.BttnCancelar.Size = new System.Drawing.Size(84, 32);
            this.BttnCancelar.TabIndex = 21;
            this.BttnCancelar.Text = "Cancelar";
            this.BttnCancelar.UseVisualStyleBackColor = false;
            // 
            // BttnRegresar
            // 
            this.BttnRegresar.Location = new System.Drawing.Point(518, 532);
            this.BttnRegresar.Name = "BttnRegresar";
            this.BttnRegresar.Size = new System.Drawing.Size(84, 32);
            this.BttnRegresar.TabIndex = 22;
            this.BttnRegresar.Text = "Regresar";
            this.BttnRegresar.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(615, 386);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 16);
            this.label14.TabIndex = 27;
            this.label14.Text = "Fecha de Salida:";
            // 
            // DTPIngreso
            // 
            this.DTPIngreso.Location = new System.Drawing.Point(748, 336);
            this.DTPIngreso.Name = "DTPIngreso";
            this.DTPIngreso.Size = new System.Drawing.Size(315, 22);
            this.DTPIngreso.TabIndex = 28;
            // 
            // DTPSalida
            // 
            this.DTPSalida.Location = new System.Drawing.Point(748, 381);
            this.DTPSalida.Name = "DTPSalida";
            this.DTPSalida.Size = new System.Drawing.Size(315, 22);
            this.DTPSalida.TabIndex = 29;
            // 
            // DGVHabi
            // 
            this.DGVHabi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVHabi.Location = new System.Drawing.Point(33, 61);
            this.DGVHabi.Name = "DGVHabi";
            this.DGVHabi.RowHeadersWidth = 51;
            this.DGVHabi.RowTemplate.Height = 24;
            this.DGVHabi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVHabi.Size = new System.Drawing.Size(525, 168);
            this.DGVHabi.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(29, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 24);
            this.label12.TabIndex = 43;
            this.label12.Text = "HABITACIÓN";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(28, 248);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 26);
            this.label11.TabIndex = 44;
            this.label11.Text = "CLIENTE";
            // 
            // DVGCliente
            // 
            this.DVGCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DVGCliente.Location = new System.Drawing.Point(33, 277);
            this.DVGCliente.Name = "DVGCliente";
            this.DVGCliente.RowHeadersWidth = 51;
            this.DVGCliente.RowTemplate.Height = 24;
            this.DVGCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DVGCliente.Size = new System.Drawing.Size(525, 168);
            this.DVGCliente.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(615, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 46;
            this.label1.Text = "Total a pagar:";
            // 
            // TxtTotalPagar
            // 
            this.TxtTotalPagar.Location = new System.Drawing.Point(712, 428);
            this.TxtTotalPagar.Name = "TxtTotalPagar";
            this.TxtTotalPagar.Size = new System.Drawing.Size(194, 22);
            this.TxtTotalPagar.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(596, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 48;
            this.label2.Text = "Usuario";
            // 
            // DGVUsers
            // 
            this.DGVUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUsers.Location = new System.Drawing.Point(600, 61);
            this.DGVUsers.Name = "DGVUsers";
            this.DGVUsers.RowHeadersWidth = 51;
            this.DGVUsers.RowTemplate.Height = 24;
            this.DGVUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVUsers.Size = new System.Drawing.Size(525, 168);
            this.DGVUsers.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(615, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 50;
            this.label3.Text = "Tipo pago:";
            // 
            // CMBTipoPago
            // 
            this.CMBTipoPago.FormattingEnabled = true;
            this.CMBTipoPago.Items.AddRange(new object[] {
            "Tarjeta",
            "Efectivo"});
            this.CMBTipoPago.Location = new System.Drawing.Point(711, 290);
            this.CMBTipoPago.Name = "CMBTipoPago";
            this.CMBTipoPago.Size = new System.Drawing.Size(195, 24);
            this.CMBTipoPago.TabIndex = 51;
            // 
            // ReservaHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 647);
            this.Controls.Add(this.CMBTipoPago);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DGVUsers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtTotalPagar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DVGCliente);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.DGVHabi);
            this.Controls.Add(this.DTPSalida);
            this.Controls.Add(this.DTPIngreso);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.BttnRegresar);
            this.Controls.Add(this.BttnCancelar);
            this.Controls.Add(this.BttnRegistrar);
            this.Controls.Add(this.label10);
            this.Name = "ReservaHabitacion";
            this.Text = "ReservaHabitacion";
            ((System.ComponentModel.ISupportInitialize)(this.DGVHabi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DVGCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BttnRegistrar;
        private System.Windows.Forms.Button BttnCancelar;
        private System.Windows.Forms.Button BttnRegresar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker DTPIngreso;
        private System.Windows.Forms.DateTimePicker DTPSalida;
        private System.Windows.Forms.DataGridView DGVHabi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView DVGCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTotalPagar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGVUsers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CMBTipoPago;
    }
}