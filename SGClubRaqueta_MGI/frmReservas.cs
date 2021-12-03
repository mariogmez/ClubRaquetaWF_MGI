using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGClubRaqueta_MGI
{
    public partial class frmReservas : Form
    {
        dsBDTableAdapters.sociosTableAdapter tbSocios = new dsBDTableAdapters.sociosTableAdapter();
        dsBDTableAdapters.pistasTableAdapter tbPistas = new dsBDTableAdapters.pistasTableAdapter();
        dsBDTableAdapters.reservasTableAdapter tbReservas = new dsBDTableAdapters.reservasTableAdapter();
        public frmReservas()
        {
            InitializeComponent();
        }

        private void frmReservas_Load(object sender, EventArgs e)
        {
            cargarCbxSocios();
            cargarCbxPista();
            txtOculto.Visible = false;
            txtIdOculto.Visible = false;
            txtOcultoId.Visible = false;
            txtOcultoPrecio.Visible = false;
        }

        private void cargarCbxSocios()
        {

            tbSocios.Fill(dsBD1.socios);
            for (int i = 0; i < dsBD1.socios.Count; i++)
            {
                cbxSocio.Items.Add(dsBD1.socios[i].apellidos + " " + dsBD1.socios[i].nombre);
            }
        }

        private void cargaDtosSocios()
        {
            tbSocios.Fill(dsBD1.socios);
            lblDni.Text = dsBD1.socios[cbxSocio.SelectedIndex].DNI;
            txtApellidos.Text = dsBD1.socios[cbxSocio.SelectedIndex].apellidos;
            txtDireccion.Text = dsBD1.socios[cbxSocio.SelectedIndex].domicilio;
            txtEmail.Text = dsBD1.socios[cbxSocio.SelectedIndex].email;
            txtNombre.Text = dsBD1.socios[cbxSocio.SelectedIndex].nombre;
            mtxtCC.Text = dsBD1.socios[cbxSocio.SelectedIndex].cuentaCorriente;
            mtxtTelefono.Text = dsBD1.socios[cbxSocio.SelectedIndex].telefono;
        }

        private void cargarCbxPista()
        {
            tbPistas.FillByNomPista(dsBD1.pistas);
            for (int i = 0; i < dsBD1.pistas.Count; i++)
            {
                cbxPista.Items.Add(dsBD1.pistas[i].nombre);
            }
        }

        private void actPanelDos()
        {
            cbxPista.Enabled = true;
            dtpFecha.Enabled = true;
            numUDhora.Enabled = true;
            numUDminutos.Enabled = true;
            dtpFecha.MinDate = dtpFecha.Value;
        }

        private void tablaReservasSocios()
        {
            tbReservas.FillByResSoc(dsBD1.reservas, lblDni.Text);

            dtgvReserva.Rows.Clear();
            for (int x = 0; x < dsBD1.reservas.Count; x++)
            {
                if (dsBD1.reservas[x].fecha != null)
                {
                    dtgvReserva.Rows.Add("");
                    DateTime fecha = dsBD1.reservas[x].fecha;

                    dtgvReserva.Rows[x].Cells[0].Value = fecha.ToString("d");
                    dtgvReserva.Rows[x].Cells[1].Value = dsBD1.reservas[x].hora;
                    dtgvReserva.Rows[x].Cells[2].Value = dsBD1.reservas[x].pista;
                    dtgvReserva.Rows[x].Cells[3].Value = dsBD1.reservas[x].pagado;
                    dtgvReserva.Rows[x].Cells[4].Value = dsBD1.reservas[x].cantidad;

                }
            }
            btnPagar.Enabled = true;
        }

        private void cargarImagenReserva()
        {
            tbPistas.FillByNomPista(dsBD1.pistas);

            btnReserva.Enabled = true;

            txtOcultoPrecio.Text = dsBD1.pistas[cbxPista.SelectedIndex].precioHora.ToString();
            txtOcultoId.Text = dsBD1.pistas[cbxPista.SelectedIndex].idPista.ToString();

            try
            {
                byte[] foto = new byte[0];
                foto = (byte[])dsBD1.pistas[cbxPista.SelectedIndex].foto;
                MemoryStream ms = new MemoryStream(foto);
                pistaPicture.Image = Image.FromStream(ms);
            }
            catch (Exception)
            {
                pistaPicture.Image = null;
                MessageBox.Show("Esta pista no tiene foto");
            }
        }

        private void cbxSocio_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargaDtosSocios();
            actPanelDos();
            tablaReservasSocios();
        }

        private void cbxPista_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarImagenReserva();
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            DateTime fecha = dtpFecha.Value;

            int hora = int.Parse(numUDhora.Value.ToString());
            int minuto = int.Parse(numUDminutos.Value.ToString());
            TimeSpan horaInterface = new TimeSpan(hora, minuto, 00);

            if (compFechaHora() == true)
            {
                tbReservas.InsertQueryInsert(fecha.ToString("d"),horaInterface.ToString(), int.Parse(txtOcultoId.Text), lblDni.Text , "No",Decimal.Parse(txtOcultoPrecio.Text));
            }

            tablaReservasSocios();
        }

        private void dtgvReserva_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedRowCount =
      dtgvReserva.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();


                //obtienes el valor de la primer columna
                string valorPagadoCelda = dtgvReserva.Rows[e.RowIndex].Cells[3].Value.ToString();
                string valorFechaCelda = dtgvReserva.Rows[e.RowIndex].Cells[0].Value.ToString();
                string valorHoraCelda = dtgvReserva.Rows[e.RowIndex].Cells[1].Value.ToString();
                string valorPistaCelda = dtgvReserva.Rows[e.RowIndex].Cells[2].Value.ToString();
                int vlrpista = Int32.Parse(valorPistaCelda);
                txtOculto.Text = valorPagadoCelda;
                int num;
                num = (int)tbReservas.ScalarQueryObtenerIDReserva(valorFechaCelda, valorHoraCelda, vlrpista);
                txtIdOculto.Text = num.ToString();



            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            String txt = txtOculto.ToString();
            if (txtOculto != null && txt.Contains("No"))
            {
                int num;
                num = Int32.Parse(txtIdOculto.Text.ToString());

                tbReservas.UpdateQueryPago("Si",num);

                tablaReservasSocios();
            }
            else
            {
                if (txt.Contains("Si"))
                {
                    MessageBox.Show("Ya esta pagado");
                }
                else
                {
                    MessageBox.Show("No hay nada selecionado");
                }
                
            }
        }

        private bool compararHoras(TimeSpan horaBD, TimeSpan strHoraReserva)
        {
            bool boo_correcto;
            
            TimeSpan intervalo = strHoraReserva - horaBD;

            if ((Math.Abs(intervalo.Hours))<1)
            {
                boo_correcto = false;
            }else if ((Math.Abs(intervalo.Hours)) >= 2)
            {
                boo_correcto = true;
            }else if ((Math.Abs(intervalo.Minutes)) >= 30)
            {
                boo_correcto = true;
            }
            else
            {
                boo_correcto = false;
            }

            return boo_correcto;
        }

        private bool compFechaHora()
        {
          
            
            // Sacar el dato de la fecha con formato
            DateTime fecha = dtpFecha.Value;

            tbReservas.FillByReservasFechaId(dsBD1.reservas, int.Parse(txtOcultoId.Text), fecha.ToString("d"));
            Boolean filtroHora = true;

            // Si la consulta devuelve datos entra en el for comprobar si coinciden las horas
            if (dsBD1.reservas.Count > 0)
            {
                for (int x = 0; x < dsBD1.reservas.Count; x++)
                {
                    TimeSpan horaBD = dsBD1.reservas[x].hora;
                    int hora = int.Parse(numUDhora.Value.ToString());
                    int minuto = int.Parse(numUDminutos.Value.ToString());
                    TimeSpan horaInterface = new TimeSpan(hora, minuto, 00);


                    // Diferencia 1h.30min  de lo que devuelve la select a la hora puesta para reservar
                    if (!compararHoras(horaBD, horaInterface))
                    {
                        // El filtro esta en true si coincide con uno nada mas es suficiente para que no se cumpla
                        filtroHora = false;
                    }
                }
            }
            return filtroHora;
        }
    }
}
