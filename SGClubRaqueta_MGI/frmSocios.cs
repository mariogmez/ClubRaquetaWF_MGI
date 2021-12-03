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
    public partial class frmSocios : Form
    {
        public frmSocios()
        {
            InitializeComponent();

        }

        private void activarCampos()
        {
            txtDni.ReadOnly = false;
            txtNombre.ReadOnly = false;
            txtApellidos.ReadOnly = false;
            txtDomicilio.ReadOnly = false;
            txtTelefono.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtCta.ReadOnly = false;
        }

        private void desactivarCampos()
        {
            txtDni.ReadOnly = true;
            txtNombre.ReadOnly = true;
            txtApellidos.ReadOnly = true;
            txtDomicilio.ReadOnly = true;
            txtTelefono.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtCta.ReadOnly = true;
        }

        private void mostrarSocios()
        {
            using (clubraquetaEntities objBD = new clubraquetaEntities())
            {
                var consultaSocios = from soc in objBD.socios
                                     orderby soc.apellidos
                                     select new { soc.DNI, soc.nombre, soc.apellidos, soc.telefono, soc.email };

                var lista = consultaSocios.ToList();
                dgvSocios.DataSource = lista;
            }
        }


        private void aniadirSocio()
        {
            using (clubraquetaEntities objBD = new clubraquetaEntities())
            {
                socios objSocios = objBD.socios.Create();
                if (txtDni.TextLength == 10 && txtDni.Text != objSocios.DNI)
                {
                    objSocios.DNI = txtDni.Text;
                }

                if (!txtNombre.Text.Trim().Equals(""))
                {
                    objSocios.nombre = txtNombre.Text;
                }

                if (!txtApellidos.Text.Trim().Equals(""))
                {
                    objSocios.apellidos = txtApellidos.Text;
                }

                if (txtCta.TextLength >= 24)
                {
                    objSocios.cuentaCorriente = txtCta.Text;
                }

                if (txtTelefono.TextLength >= 11)
                {
                    objSocios.telefono = txtTelefono.Text;
                }

                if (!txtEmail.Text.Trim().Equals(""))
                {
                    objSocios.email = txtEmail.Text;
                }

                if (!txtDomicilio.Text.Trim().Equals(""))
                {
                    objSocios.domicilio = txtDomicilio.Text;
                }
                try
                {
                   
                    objBD.socios.Add(objSocios);
                    objBD.SaveChanges();
                    MessageBox.Show("Socio añadido");
                    txtDni.Text = "";
                    txtNombre.Text = "";
                    txtApellidos.Text = "";
                    txtCta.Text = "";
                    txtTelefono.Text = "";
                    txtDomicilio.Text = "";
                    txtEmail.Text = "";
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error campos incorrectos o incompletos");
                }
            }
        }

        private void modificarSocio()
        {
            using (clubraquetaEntities objBD = new clubraquetaEntities())
            {

                socios objSocios = objBD.socios.Find(txtDni.Text);

                if (!txtNombre.Text.Trim().Equals(""))
                {
                    objSocios.nombre = txtNombre.Text;
                }

                if (!txtApellidos.Text.Trim().Equals(""))
                {
                    objSocios.apellidos = txtApellidos.Text;
                }
                if (txtCta.TextLength >= 24 || !txtCta.Text.Trim().Equals(""))
                {              
                    objSocios.cuentaCorriente = txtCta.Text;                                  
                }

                if (txtTelefono.TextLength >= 11)
                {
                    objSocios.telefono = txtTelefono.Text;
                }

                if (!txtEmail.Text.Trim().Equals(""))
                {
                    objSocios.email = txtEmail.Text;
                }

                if (!txtDomicilio.Text.Trim().Equals(""))
                {
                    objSocios.domicilio = txtDomicilio.Text;
                }

                try
                {
                    objBD.SaveChanges();
                    MessageBox.Show("Socio modificado");
                }
                catch (Exception a)
                {
                    MessageBox.Show("No se a podido modificar");
                }
            }
        }

        private void eliminarSocio()
        {
            using (clubraquetaEntities objBD = new clubraquetaEntities())
            {
                var consulta1 = from res in objBD.reservas
                                where res.socio == txtDni.Text
                                select new { res.idReserva, res.fecha, res.hora, res.pista, res.socio, res.pagado, res.cantidad };
                var lista = consulta1.Distinct().ToList();
                if (lista.Count <= 0)
                {

                    socios objSocios = objBD.socios.Find(txtDni.Text);
                    if (objSocios == null)
                    {
                        MessageBox.Show("El campo DNI esta vacio");
                    }
                    else
                    {
                        objBD.socios.Remove(objSocios);
                        objBD.SaveChanges();
                        MessageBox.Show("Socio eliminado");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Este socio aun tiene reservas");
                }
            }
        }

        private void btnAniadir_Click(object sender, EventArgs e)
        {
            aniadirSocio();

            txtDni.Text = "";
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtCta.Text = "";
            txtTelefono.Text = "";
            txtDomicilio.Text = "";
            txtEmail.Text = "";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificarSocio();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarSocio();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            mostrarSocios();
        }

        private void btnAniadirOCT_Click(object sender, EventArgs e)
        {
            aniadirSocio();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void dgvSocios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtCta_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void frmSocios_Load(object sender, EventArgs e)
        {

        }
    }
}
