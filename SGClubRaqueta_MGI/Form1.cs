using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGClubRaqueta_MGI
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void tlsSocios_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "frmSocios")
                {
                    this.MdiChildren[0].Close();

                    frmSocios s = new frmSocios();
                    s.MdiParent = this;
                    s.Dock = DockStyle.Fill;
                    s.Show();
                }

            }
            else
            {
                frmSocios s = new frmSocios();
                s.MdiParent = this;
                s.Dock = DockStyle.Fill;
                s.Show();
            }

        }

        private void tlsPistas_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "frmPistas")
                {
                    this.MdiChildren[0].Close();

                    frmPistas p = new frmPistas();
                    p.MdiParent = this;
                    p.Dock = DockStyle.Fill;
                    p.Show();
                }

            }
            else
            {
                frmPistas p = new frmPistas();
                p.MdiParent = this;
                p.Dock = DockStyle.Fill;
                p.Show();
            }
        }

        private void tlsReservas_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "frmReservas")
                {
                    this.MdiChildren[0].Close();

                    frmReservas r = new frmReservas();
                    r.MdiParent = this;
                    r.Dock = DockStyle.Fill;
                    r.Show();
                }

            }
            else
            {
                frmReservas r = new frmReservas();
                r.MdiParent = this;
                r.Dock = DockStyle.Fill;
                r.Show();
            }

        }

        private void tlsInformes_Click(object sender, EventArgs e)
        {

        }

        private void tlsSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "frmReservas")
                {
                    this.MdiChildren[0].Close();

                    frmReservas r = new frmReservas();
                    r.MdiParent = this;
                    r.Dock = DockStyle.Fill;
                    r.Show();
                }

            }
            else
            {
                frmReservas r = new frmReservas();
                r.MdiParent = this;
                r.Dock = DockStyle.Fill;
                r.Show();
            }
        }
    }
}
