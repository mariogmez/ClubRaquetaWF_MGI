
namespace SGClubRaqueta_MGI
{
    partial class frmPistas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label precioHoraLabel;
            System.Windows.Forms.Label ubicacionLabel;
            System.Windows.Forms.Label idPistaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPistas));
            this.pistasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.pistasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBD = new SGClubRaqueta_MGI.dsBD();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.pistasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.precioHoraTextBox = new System.Windows.Forms.TextBox();
            this.ubicacionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.idPistaLabel1 = new System.Windows.Forms.Label();
            this.pistasTableAdapter = new SGClubRaqueta_MGI.dsBDTableAdapters.pistasTableAdapter();
            this.tableAdapterManager = new SGClubRaqueta_MGI.dsBDTableAdapters.TableAdapterManager();
            this.reservasTableAdapter1 = new SGClubRaqueta_MGI.dsBDTableAdapters.reservasTableAdapter();
            this.btnFoto = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            nombreLabel = new System.Windows.Forms.Label();
            precioHoraLabel = new System.Windows.Forms.Label();
            ubicacionLabel = new System.Windows.Forms.Label();
            idPistaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pistasBindingNavigator)).BeginInit();
            this.pistasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pistasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(120, 192);
            nombreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(60, 17);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "nombre:";
            // 
            // precioHoraLabel
            // 
            precioHoraLabel.AutoSize = true;
            precioHoraLabel.Location = new System.Drawing.Point(120, 393);
            precioHoraLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            precioHoraLabel.Name = "precioHoraLabel";
            precioHoraLabel.Size = new System.Drawing.Size(86, 17);
            precioHoraLabel.TabIndex = 7;
            precioHoraLabel.Text = "precio Hora:";
            // 
            // ubicacionLabel
            // 
            ubicacionLabel.AutoSize = true;
            ubicacionLabel.Location = new System.Drawing.Point(120, 224);
            ubicacionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ubicacionLabel.Name = "ubicacionLabel";
            ubicacionLabel.Size = new System.Drawing.Size(72, 17);
            ubicacionLabel.TabIndex = 10;
            ubicacionLabel.Text = "ubicacion:";
            // 
            // idPistaLabel
            // 
            idPistaLabel.AutoSize = true;
            idPistaLabel.Location = new System.Drawing.Point(120, 151);
            idPistaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idPistaLabel.Name = "idPistaLabel";
            idPistaLabel.Size = new System.Drawing.Size(58, 17);
            idPistaLabel.TabIndex = 11;
            idPistaLabel.Text = "id Pista:";
            // 
            // pistasBindingNavigator
            // 
            this.pistasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pistasBindingNavigator.BindingSource = this.pistasBindingSource;
            this.pistasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pistasBindingNavigator.DeleteItem = null;
            this.pistasBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.pistasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pistasBindingNavigatorSaveItem});
            this.pistasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pistasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pistasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pistasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pistasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pistasBindingNavigator.Name = "pistasBindingNavigator";
            this.pistasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pistasBindingNavigator.Size = new System.Drawing.Size(1067, 27);
            this.pistasBindingNavigator.TabIndex = 0;
            this.pistasBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // pistasBindingSource
            // 
            this.pistasBindingSource.DataMember = "pistas";
            this.pistasBindingSource.DataSource = this.dsBD;
            // 
            // dsBD
            // 
            this.dsBD.DataSetName = "dsBD";
            this.dsBD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // pistasBindingNavigatorSaveItem
            // 
            this.pistasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pistasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pistasBindingNavigatorSaveItem.Image")));
            this.pistasBindingNavigatorSaveItem.Name = "pistasBindingNavigatorSaveItem";
            this.pistasBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.pistasBindingNavigatorSaveItem.Text = "Guardar datos";
            this.pistasBindingNavigatorSaveItem.Click += new System.EventHandler(this.pistasBindingNavigatorSaveItem_Click);
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pistasBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(215, 188);
            this.nombreTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(284, 22);
            this.nombreTextBox.TabIndex = 4;
            // 
            // precioHoraTextBox
            // 
            this.precioHoraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pistasBindingSource, "precioHora", true));
            this.precioHoraTextBox.Location = new System.Drawing.Point(215, 389);
            this.precioHoraTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.precioHoraTextBox.Name = "precioHoraTextBox";
            this.precioHoraTextBox.Size = new System.Drawing.Size(284, 22);
            this.precioHoraTextBox.TabIndex = 8;
            // 
            // ubicacionRichTextBox
            // 
            this.ubicacionRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pistasBindingSource, "ubicacion", true));
            this.ubicacionRichTextBox.Location = new System.Drawing.Point(215, 220);
            this.ubicacionRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ubicacionRichTextBox.Name = "ubicacionRichTextBox";
            this.ubicacionRichTextBox.Size = new System.Drawing.Size(284, 160);
            this.ubicacionRichTextBox.TabIndex = 11;
            this.ubicacionRichTextBox.Text = "";
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.pistasBindingSource, "foto", true));
            this.fotoPictureBox.Location = new System.Drawing.Point(576, 139);
            this.fotoPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(400, 242);
            this.fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoPictureBox.TabIndex = 10;
            this.fotoPictureBox.TabStop = false;
            // 
            // idPistaLabel1
            // 
            this.idPistaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pistasBindingSource, "idPista", true));
            this.idPistaLabel1.Location = new System.Drawing.Point(211, 151);
            this.idPistaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idPistaLabel1.Name = "idPistaLabel1";
            this.idPistaLabel1.Size = new System.Drawing.Size(133, 28);
            this.idPistaLabel1.TabIndex = 12;
            this.idPistaLabel1.Text = "label1";
            // 
            // pistasTableAdapter
            // 
            this.pistasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.pistasTableAdapter = this.pistasTableAdapter;
            this.tableAdapterManager.reservasTableAdapter = this.reservasTableAdapter1;
            this.tableAdapterManager.sociosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SGClubRaqueta_MGI.dsBDTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // reservasTableAdapter1
            // 
            this.reservasTableAdapter1.ClearBeforeFill = true;
            // 
            // btnFoto
            // 
            this.btnFoto.Location = new System.Drawing.Point(727, 386);
            this.btnFoto.Margin = new System.Windows.Forms.Padding(4);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(100, 28);
            this.btnFoto.TabIndex = 13;
            this.btnFoto.Text = "Nueva Foto";
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "ofdFoto";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // frmPistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(idPistaLabel);
            this.Controls.Add(this.idPistaLabel1);
            this.Controls.Add(ubicacionLabel);
            this.Controls.Add(this.ubicacionRichTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(precioHoraLabel);
            this.Controls.Add(this.precioHoraTextBox);
            this.Controls.Add(this.fotoPictureBox);
            this.Controls.Add(this.pistasBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPistas";
            this.Text = "frmPistas";
            this.Load += new System.EventHandler(this.frmPistas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pistasBindingNavigator)).EndInit();
            this.pistasBindingNavigator.ResumeLayout(false);
            this.pistasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pistasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dsBD dsBD;
        private System.Windows.Forms.BindingSource pistasBindingSource;
        private dsBDTableAdapters.pistasTableAdapter pistasTableAdapter;
        private dsBDTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pistasBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pistasBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox precioHoraTextBox;
        private System.Windows.Forms.RichTextBox ubicacionRichTextBox;
        private System.Windows.Forms.PictureBox fotoPictureBox;
        private System.Windows.Forms.Label idPistaLabel1;
        private dsBDTableAdapters.reservasTableAdapter reservasTableAdapter1;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}