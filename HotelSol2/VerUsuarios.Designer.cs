﻿namespace HotelSol2
{
    partial class VerUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerUsuarios));
            this.TSAcciones = new System.Windows.Forms.ToolStrip();
            this.TSBttnAgregar = new System.Windows.Forms.ToolStripButton();
            this.TSBttnEliminar = new System.Windows.Forms.ToolStripButton();
            this.TSBttnModificar = new System.Windows.Forms.ToolStripButton();
            this.DGVUsers = new System.Windows.Forms.DataGridView();
            this.TSAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // TSAcciones
            // 
            this.TSAcciones.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TSAcciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSBttnAgregar,
            this.TSBttnEliminar,
            this.TSBttnModificar});
            this.TSAcciones.Location = new System.Drawing.Point(0, 0);
            this.TSAcciones.Name = "TSAcciones";
            this.TSAcciones.Size = new System.Drawing.Size(785, 27);
            this.TSAcciones.TabIndex = 0;
            this.TSAcciones.Text = "toolStrip1";
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
            // DGVUsers
            // 
            this.DGVUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUsers.Location = new System.Drawing.Point(12, 34);
            this.DGVUsers.Name = "DGVUsers";
            this.DGVUsers.RowHeadersWidth = 51;
            this.DGVUsers.RowTemplate.Height = 24;
            this.DGVUsers.Size = new System.Drawing.Size(761, 393);
            this.DGVUsers.TabIndex = 4;
            // 
            // VerUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 450);
            this.Controls.Add(this.DGVUsers);
            this.Controls.Add(this.TSAcciones);
            this.Name = "VerUsuarios";
            this.Text = "VerUsuarios";
            this.TSAcciones.ResumeLayout(false);
            this.TSAcciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip TSAcciones;
        private System.Windows.Forms.ToolStripButton TSBttnAgregar;
        private System.Windows.Forms.ToolStripButton TSBttnEliminar;
        private System.Windows.Forms.ToolStripButton TSBttnModificar;
        private System.Windows.Forms.DataGridView DGVUsers;
    }
}