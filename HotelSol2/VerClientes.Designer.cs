namespace HotelSol2
{
    partial class VerClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerClientes));
            this.DGVClientes = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSBttnAgregar = new System.Windows.Forms.ToolStripButton();
            this.TSBttnEliminar = new System.Windows.Forms.ToolStripButton();
            this.TSBttnModificar = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGVClientes)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVClientes
            // 
            this.DGVClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVClientes.Location = new System.Drawing.Point(13, 61);
            this.DGVClientes.Name = "DGVClientes";
            this.DGVClientes.RowHeadersWidth = 51;
            this.DGVClientes.RowTemplate.Height = 24;
            this.DGVClientes.Size = new System.Drawing.Size(733, 377);
            this.DGVClientes.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSBttnAgregar,
            this.TSBttnEliminar,
            this.TSBttnModificar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(758, 27);
            this.toolStrip1.TabIndex = 1;
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
            // TSBttnModificar
            // 
            this.TSBttnModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBttnModificar.Image = ((System.Drawing.Image)(resources.GetObject("TSBttnModificar.Image")));
            this.TSBttnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBttnModificar.Name = "TSBttnModificar";
            this.TSBttnModificar.Size = new System.Drawing.Size(29, 24);
            this.TSBttnModificar.Text = "Modificar";
            this.TSBttnModificar.Click += new System.EventHandler(this.TSBttnModificar_Click);
            // 
            // VerClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.DGVClientes);
            this.Name = "VerClientes";
            this.Text = "VerClientes";
            ((System.ComponentModel.ISupportInitialize)(this.DGVClientes)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVClientes;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSBttnAgregar;
        private System.Windows.Forms.ToolStripButton TSBttnEliminar;
        private System.Windows.Forms.ToolStripButton TSBttnModificar;
    }
}