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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerarFactura));
            this.bttnGenerarFac = new System.Windows.Forms.Button();
            this.DGVFactura = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSBttnAgregar = new System.Windows.Forms.ToolStripButton();
            this.TSBttnEliminar = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFactura)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttnGenerarFac
            // 
            this.bttnGenerarFac.Location = new System.Drawing.Point(353, 437);
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
            this.DGVFactura.Location = new System.Drawing.Point(12, 48);
            this.DGVFactura.Name = "DGVFactura";
            this.DGVFactura.RowHeadersWidth = 51;
            this.DGVFactura.RowTemplate.Height = 24;
            this.DGVFactura.Size = new System.Drawing.Size(776, 336);
            this.DGVFactura.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSBttnAgregar,
            this.TSBttnEliminar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(805, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TSBttnAgregar
            // 
            this.TSBttnAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBttnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("TSBttnAgregar.Image")));
            this.TSBttnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBttnAgregar.Name = "TSBttnAgregar";
            this.TSBttnAgregar.Size = new System.Drawing.Size(29, 24);
            this.TSBttnAgregar.Text = "Agregar";
            this.TSBttnAgregar.Click += new System.EventHandler(this.TSBttnAgregar_Click);
            // 
            // TSBttnEliminar
            // 
            this.TSBttnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBttnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("TSBttnEliminar.Image")));
            this.TSBttnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBttnEliminar.Name = "TSBttnEliminar";
            this.TSBttnEliminar.Size = new System.Drawing.Size(29, 24);
            this.TSBttnEliminar.Text = "Eliminar";
            this.TSBttnEliminar.Click += new System.EventHandler(this.TSBttnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Generar Factura";
            // 
            // GenerarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 499);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.DGVFactura);
            this.Controls.Add(this.bttnGenerarFac);
            this.Name = "GenerarFactura";
            this.Text = "Factura";
            ((System.ComponentModel.ISupportInitialize)(this.DGVFactura)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bttnGenerarFac;
        private System.Windows.Forms.DataGridView DGVFactura;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSBttnAgregar;
        private System.Windows.Forms.ToolStripButton TSBttnEliminar;
        private System.Windows.Forms.Label label1;
    }
}