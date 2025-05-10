namespace HotelSol2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.BttnLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "USER:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "PASSWORD:";
            // 
            // TxtUser
            // 
            this.TxtUser.Location = new System.Drawing.Point(191, 78);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(194, 22);
            this.TxtUser.TabIndex = 2;
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.Location = new System.Drawing.Point(206, 120);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.Size = new System.Drawing.Size(194, 22);
            this.TxtContraseña.TabIndex = 3;
            // 
            // BttnLogin
            // 
            this.BttnLogin.Location = new System.Drawing.Point(206, 172);
            this.BttnLogin.Name = "BttnLogin";
            this.BttnLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BttnLogin.Size = new System.Drawing.Size(103, 28);
            this.BttnLogin.TabIndex = 4;
            this.BttnLogin.Text = "LOGIN";
            this.BttnLogin.UseVisualStyleBackColor = true;
            this.BttnLogin.Click += new System.EventHandler(this.BttnLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(171, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hotel El Sol";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 236);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BttnLogin);
            this.Controls.Add(this.TxtContraseña);
            this.Controls.Add(this.TxtUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "LOGIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.TextBox TxtContraseña;
        private System.Windows.Forms.Button BttnLogin;
        private System.Windows.Forms.Label label3;
    }
}

