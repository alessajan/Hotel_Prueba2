namespace HotelSol2
{
    partial class GenerarFactura
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
            this.bttnGenerarFac = new System.Windows.Forms.Button();
            this.DGVFactura = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnGenerarFac
            // 
            this.bttnGenerarFac.Location = new System.Drawing.Point(343, 384);
            this.bttnGenerarFac.Name = "bttnGenerarFac";
            this.bttnGenerarFac.Size = new System.Drawing.Size(86, 36);
            this.bttnGenerarFac.TabIndex = 1;
            this.bttnGenerarFac.Text = "Generar";
            this.bttnGenerarFac.UseVisualStyleBackColor = true;
            this.bttnGenerarFac.Click += new System.EventHandler(this.bttnGenerarFac_Click);
            // 
            // DGVFactura
            // 
            this.DGVFactura.AllowUserToOrderColumns = true;
            this.DGVFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVFactura.Location = new System.Drawing.Point(12, 12);
            this.DGVFactura.Name = "DGVFactura";
            this.DGVFactura.RowHeadersWidth = 51;
            this.DGVFactura.RowTemplate.Height = 24;
            this.DGVFactura.Size = new System.Drawing.Size(776, 336);
            this.DGVFactura.TabIndex = 2;
            // 
            // GenerarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 451);
            this.Controls.Add(this.DGVFactura);
            this.Controls.Add(this.bttnGenerarFac);
            this.Name = "GenerarFactura";
            this.Text = "Factura";
            ((System.ComponentModel.ISupportInitialize)(this.DGVFactura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bttnGenerarFac;
        private System.Windows.Forms.DataGridView DGVFactura;
    }
}