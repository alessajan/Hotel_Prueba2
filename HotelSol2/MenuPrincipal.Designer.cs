namespace HotelSol2
{
    partial class MenuPrincipal
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
            this.BttnVer1 = new System.Windows.Forms.Button();
            this.btnhabitacion2 = new System.Windows.Forms.Button();
            this.btnUsuarios2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFactura = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservar Habitación";
            // 
            // BttnVer1
            // 
            this.BttnVer1.Location = new System.Drawing.Point(193, 207);
            this.BttnVer1.Name = "BttnVer1";
            this.BttnVer1.Size = new System.Drawing.Size(75, 28);
            this.BttnVer1.TabIndex = 1;
            this.BttnVer1.Text = "Ver";
            this.BttnVer1.UseVisualStyleBackColor = true;
            this.BttnVer1.Click += new System.EventHandler(this.BttnVer1_Click);
            // 
            // btnhabitacion2
            // 
            this.btnhabitacion2.Location = new System.Drawing.Point(193, 135);
            this.btnhabitacion2.Name = "btnhabitacion2";
            this.btnhabitacion2.Size = new System.Drawing.Size(75, 23);
            this.btnhabitacion2.TabIndex = 2;
            this.btnhabitacion2.Text = "OK";
            this.btnhabitacion2.UseVisualStyleBackColor = true;
            // 
            // btnUsuarios2
            // 
            this.btnUsuarios2.Location = new System.Drawing.Point(193, 73);
            this.btnUsuarios2.Name = "btnUsuarios2";
            this.btnUsuarios2.Size = new System.Drawing.Size(75, 23);
            this.btnUsuarios2.TabIndex = 3;
            this.btnUsuarios2.Text = "Ver";
            this.btnUsuarios2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ver Habitacion";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Usuarios";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Factura";
            // 
            // btnFactura
            // 
            this.btnFactura.Location = new System.Drawing.Point(193, 277);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(75, 23);
            this.btnFactura.TabIndex = 8;
            this.btnFactura.Text = "OK";
            this.btnFactura.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFactura);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUsuarios2);
            this.Controls.Add(this.btnhabitacion2);
            this.Controls.Add(this.BttnVer1);
            this.Controls.Add(this.label1);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BttnVer1;
        private System.Windows.Forms.Button btnhabitacion2;
        private System.Windows.Forms.Button btnUsuarios2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFactura;
    }
}