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
    public partial class frmPistas : Form
    {
        public frmPistas()
        {
            InitializeComponent();
 
            // TODO: esta línea de código carga datos en la tabla 'dsBD.pistas' Puede moverla o quitarla según sea necesario.
            this.pistasTableAdapter.Fill(this.dsBD.pistas);
        }

        private void pistasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pistasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsBD);

        }

        private void frmPistas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsBD.pistas' Puede moverla o quitarla según sea necesario.
            this.pistasTableAdapter.Fill(this.dsBD.pistas);
            this.reservasTableAdapter1.Fill(this.dsBD.reservas);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("¿Esta seguro de querer eliminar esta pista?", "BORRAR", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (resp == DialogResult.Yes)
            {
                this.reservasTableAdapter1.FillByReserva(dsBD.reservas, int.Parse(idPistaLabel1.Text));
                if (dsBD.reservas.Count > 0)
                {
                    MessageBox.Show("No puede eliminarse esta pista porque tiene una reserva", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    pistasTableAdapter.Delete(int.Parse(idPistaLabel1.Text));
                    MessageBox.Show("Pista eliminada correctamente", "BORRADA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dsBD.pistas.Clear();
                    pistasTableAdapter.Fill(dsBD.pistas);
                }
            }
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            anadirFoto();
        }

        private void anadirFoto()
        {
            string miCarpetaOrigen = System.IO.Path.Combine(Application.StartupPath, "fotos\\");
            openFileDialog1.InitialDirectory = miCarpetaOrigen;

            openFileDialog1.Filter = "image files|*.jpg;*.png;*.gif;*.ico;.*;";

            DialogResult dres = openFileDialog1.ShowDialog();

            if (dres == DialogResult.Abort)
                return;
            if (dres == DialogResult.Cancel)
                return;

            //Se muestra la imagen en el PictureBox directamente de la ruta devuelta por el OpenFileDialog
            fotoPictureBox.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
