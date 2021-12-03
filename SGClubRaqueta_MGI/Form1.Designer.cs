
namespace SGClubRaqueta_MGI
{
    partial class frmPrincipal
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
            this.tlsPrincipal = new System.Windows.Forms.MenuStrip();
            this.aDMINISTRARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsSocios = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsPistas = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsReservas = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsInformes = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlsPrincipal
            // 
            this.tlsPrincipal.AutoSize = false;
            this.tlsPrincipal.BackColor = System.Drawing.SystemColors.Control;
            this.tlsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDMINISTRARToolStripMenuItem,
            this.tlsReservas,
            this.tlsInformes,
            this.tlsSalir});
            this.tlsPrincipal.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tlsPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlsPrincipal.Name = "tlsPrincipal";
            this.tlsPrincipal.Size = new System.Drawing.Size(879, 24);
            this.tlsPrincipal.TabIndex = 2;
            this.tlsPrincipal.Text = "menuStrip1";
            // 
            // aDMINISTRARToolStripMenuItem
            // 
            this.aDMINISTRARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsSocios,
            this.tlsPistas});
            this.aDMINISTRARToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.aDMINISTRARToolStripMenuItem.Name = "aDMINISTRARToolStripMenuItem";
            this.aDMINISTRARToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.aDMINISTRARToolStripMenuItem.Text = "ADMINISTRAR";
            // 
            // tlsSocios
            // 
            this.tlsSocios.Name = "tlsSocios";
            this.tlsSocios.Size = new System.Drawing.Size(108, 22);
            this.tlsSocios.Text = "Socios";
            this.tlsSocios.Click += new System.EventHandler(this.tlsSocios_Click);
            // 
            // tlsPistas
            // 
            this.tlsPistas.Name = "tlsPistas";
            this.tlsPistas.Size = new System.Drawing.Size(108, 22);
            this.tlsPistas.Text = "Pistas";
            this.tlsPistas.Click += new System.EventHandler(this.tlsPistas_Click);
            // 
            // tlsReservas
            // 
            this.tlsReservas.Name = "tlsReservas";
            this.tlsReservas.Size = new System.Drawing.Size(71, 20);
            this.tlsReservas.Text = "RESERVAS";
            this.tlsReservas.Click += new System.EventHandler(this.tlsReservas_Click);
            // 
            // tlsInformes
            // 
            this.tlsInformes.Name = "tlsInformes";
            this.tlsInformes.Size = new System.Drawing.Size(76, 20);
            this.tlsInformes.Text = "INFORMES";
            this.tlsInformes.Click += new System.EventHandler(this.tlsInformes_Click);
            // 
            // tlsSalir
            // 
            this.tlsSalir.Name = "tlsSalir";
            this.tlsSalir.Size = new System.Drawing.Size(49, 20);
            this.tlsSalir.Text = "SALIR";
            this.tlsSalir.Click += new System.EventHandler(this.tlsSalir_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 652);
            this.Controls.Add(this.tlsPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.tlsPrincipal.ResumeLayout(false);
            this.tlsPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip tlsPrincipal;
        private System.Windows.Forms.ToolStripMenuItem aDMINISTRARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tlsSocios;
        private System.Windows.Forms.ToolStripMenuItem tlsPistas;
        private System.Windows.Forms.ToolStripMenuItem tlsReservas;
        private System.Windows.Forms.ToolStripMenuItem tlsInformes;
        private System.Windows.Forms.ToolStripMenuItem tlsSalir;
    }
}

