
namespace SGClubRaqueta_MGI
{
    partial class frmReservas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxSocio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtOcultoId = new System.Windows.Forms.Label();
            this.txtOcultoPrecio = new System.Windows.Forms.Label();
            this.pistaPicture = new System.Windows.Forms.PictureBox();
            this.numUDminutos = new System.Windows.Forms.NumericUpDown();
            this.numUDhora = new System.Windows.Forms.NumericUpDown();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnReserva = new System.Windows.Forms.Button();
            this.cbxPista = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtIdOculto = new System.Windows.Forms.TextBox();
            this.txtOculto = new System.Windows.Forms.TextBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.dtgvReserva = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pagado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsBD1 = new SGClubRaqueta_MGI.dsBD();
            this.mtxtCC = new System.Windows.Forms.TextBox();
            this.mtxtTelefono = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pistaPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDminutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDhora)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReserva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBD1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.mtxtTelefono);
            this.panel1.Controls.Add(this.mtxtCC);
            this.panel1.Controls.Add(this.txtApellidos);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(16, 63);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1140, 160);
            this.panel1.TabIndex = 22;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(635, 23);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.ReadOnly = true;
            this.txtApellidos.Size = new System.Drawing.Size(412, 22);
            this.txtApellidos.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(635, 110);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(412, 22);
            this.txtEmail.TabIndex = 11;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(144, 65);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(299, 22);
            this.txtDireccion.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(144, 22);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(299, 22);
            this.txtNombre.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(51, 22);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Nombre:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(51, 66);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Direccion:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 111);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Teléfono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(520, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(520, 71);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "CCC:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(520, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Apellidos:";
            // 
            // cbxSocio
            // 
            this.cbxSocio.FormattingEnabled = true;
            this.cbxSocio.Location = new System.Drawing.Point(175, 15);
            this.cbxSocio.Margin = new System.Windows.Forms.Padding(4);
            this.cbxSocio.Name = "cbxSocio";
            this.cbxSocio.Size = new System.Drawing.Size(284, 24);
            this.cbxSocio.TabIndex = 24;
            this.cbxSocio.SelectedIndexChanged += new System.EventHandler(this.cbxSocio_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Elige al socio";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(601, 16);
            this.lblDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(0, 18);
            this.lblDni.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(491, 16);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 18);
            this.label10.TabIndex = 26;
            this.label10.Text = "DNI Socio:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.txtOcultoId);
            this.panel2.Controls.Add(this.txtOcultoPrecio);
            this.panel2.Controls.Add(this.pistaPicture);
            this.panel2.Controls.Add(this.numUDminutos);
            this.panel2.Controls.Add(this.numUDhora);
            this.panel2.Controls.Add(this.dtpFecha);
            this.panel2.Controls.Add(this.btnReserva);
            this.panel2.Controls.Add(this.cbxPista);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Location = new System.Drawing.Point(16, 230);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1140, 203);
            this.panel2.TabIndex = 28;
            // 
            // txtOcultoId
            // 
            this.txtOcultoId.AutoSize = true;
            this.txtOcultoId.Location = new System.Drawing.Point(596, 33);
            this.txtOcultoId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtOcultoId.Name = "txtOcultoId";
            this.txtOcultoId.Size = new System.Drawing.Size(0, 17);
            this.txtOcultoId.TabIndex = 24;
            // 
            // txtOcultoPrecio
            // 
            this.txtOcultoPrecio.AutoSize = true;
            this.txtOcultoPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOcultoPrecio.Location = new System.Drawing.Point(549, 75);
            this.txtOcultoPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtOcultoPrecio.Name = "txtOcultoPrecio";
            this.txtOcultoPrecio.Size = new System.Drawing.Size(0, 18);
            this.txtOcultoPrecio.TabIndex = 22;
            // 
            // pistaPicture
            // 
            this.pistaPicture.Location = new System.Drawing.Point(799, 27);
            this.pistaPicture.Margin = new System.Windows.Forms.Padding(4);
            this.pistaPicture.Name = "pistaPicture";
            this.pistaPicture.Size = new System.Drawing.Size(228, 142);
            this.pistaPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pistaPicture.TabIndex = 21;
            this.pistaPicture.TabStop = false;
            // 
            // numUDminutos
            // 
            this.numUDminutos.Enabled = false;
            this.numUDminutos.Increment = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numUDminutos.Location = new System.Drawing.Point(239, 127);
            this.numUDminutos.Margin = new System.Windows.Forms.Padding(4);
            this.numUDminutos.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numUDminutos.Name = "numUDminutos";
            this.numUDminutos.Size = new System.Drawing.Size(49, 22);
            this.numUDminutos.TabIndex = 20;
            // 
            // numUDhora
            // 
            this.numUDhora.Enabled = false;
            this.numUDhora.Location = new System.Drawing.Point(164, 127);
            this.numUDhora.Margin = new System.Windows.Forms.Padding(4);
            this.numUDhora.Maximum = new decimal(new int[] {
            22,
            0,
            0,
            0});
            this.numUDhora.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numUDhora.Name = "numUDhora";
            this.numUDhora.Size = new System.Drawing.Size(49, 22);
            this.numUDhora.TabIndex = 19;
            this.numUDhora.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "";
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(164, 75);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFecha.MinDate = new System.DateTime(2021, 11, 27, 14, 20, 8, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(191, 22);
            this.dtpFecha.TabIndex = 18;
            this.dtpFecha.Value = new System.DateTime(2021, 11, 27, 14, 20, 8, 0);
            // 
            // btnReserva
            // 
            this.btnReserva.Enabled = false;
            this.btnReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserva.Location = new System.Drawing.Point(493, 144);
            this.btnReserva.Margin = new System.Windows.Forms.Padding(4);
            this.btnReserva.Name = "btnReserva";
            this.btnReserva.Size = new System.Drawing.Size(137, 41);
            this.btnReserva.TabIndex = 17;
            this.btnReserva.Text = "RESERVAR";
            this.btnReserva.UseVisualStyleBackColor = true;
            this.btnReserva.Click += new System.EventHandler(this.btnReserva_Click);
            // 
            // cbxPista
            // 
            this.cbxPista.Enabled = false;
            this.cbxPista.FormattingEnabled = true;
            this.cbxPista.Location = new System.Drawing.Point(164, 23);
            this.cbxPista.Margin = new System.Windows.Forms.Padding(4);
            this.cbxPista.Name = "cbxPista";
            this.cbxPista.Size = new System.Drawing.Size(312, 24);
            this.cbxPista.TabIndex = 16;
            this.cbxPista.SelectedIndexChanged += new System.EventHandler(this.cbxPista_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pista:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(808, 169);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(154, 18);
            this.label13.TabIndex = 12;
            this.label13.Text = "Duracion 1h 30 min";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(51, 127);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 18);
            this.label14.TabIndex = 13;
            this.label14.Text = "Hora Inicio:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.txtIdOculto);
            this.panel3.Controls.Add(this.txtOculto);
            this.panel3.Controls.Add(this.btnPagar);
            this.panel3.Controls.Add(this.dtgvReserva);
            this.panel3.Location = new System.Drawing.Point(16, 441);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1140, 299);
            this.panel3.TabIndex = 29;
            // 
            // txtIdOculto
            // 
            this.txtIdOculto.Location = new System.Drawing.Point(5, 239);
            this.txtIdOculto.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdOculto.Name = "txtIdOculto";
            this.txtIdOculto.Size = new System.Drawing.Size(132, 22);
            this.txtIdOculto.TabIndex = 20;
            // 
            // txtOculto
            // 
            this.txtOculto.Location = new System.Drawing.Point(5, 271);
            this.txtOculto.Margin = new System.Windows.Forms.Padding(4);
            this.txtOculto.Name = "txtOculto";
            this.txtOculto.Size = new System.Drawing.Size(132, 22);
            this.txtOculto.TabIndex = 19;
            // 
            // btnPagar
            // 
            this.btnPagar.Enabled = false;
            this.btnPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.Location = new System.Drawing.Point(493, 186);
            this.btnPagar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(137, 41);
            this.btnPagar.TabIndex = 18;
            this.btnPagar.Text = "PAGAR";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // dtgvReserva
            // 
            this.dtgvReserva.AllowUserToAddRows = false;
            this.dtgvReserva.AllowUserToDeleteRows = false;
            this.dtgvReserva.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvReserva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Hora,
            this.Pista,
            this.Pagado,
            this.Cantidad});
            this.dtgvReserva.Location = new System.Drawing.Point(144, 23);
            this.dtgvReserva.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvReserva.MultiSelect = false;
            this.dtgvReserva.Name = "dtgvReserva";
            this.dtgvReserva.ReadOnly = true;
            this.dtgvReserva.RowHeadersWidth = 51;
            this.dtgvReserva.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvReserva.Size = new System.Drawing.Size(843, 155);
            this.dtgvReserva.TabIndex = 0;
            this.dtgvReserva.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvReserva_CellContentClick);
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.MinimumWidth = 6;
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            // 
            // Pista
            // 
            this.Pista.HeaderText = "Pista";
            this.Pista.MinimumWidth = 6;
            this.Pista.Name = "Pista";
            this.Pista.ReadOnly = true;
            // 
            // Pagado
            // 
            this.Pagado.HeaderText = "Pagado";
            this.Pagado.MinimumWidth = 6;
            this.Pagado.Name = "Pagado";
            this.Pagado.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Precio";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // dsBD1
            // 
            this.dsBD1.DataSetName = "dsBD";
            this.dsBD1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mtxtCC
            // 
            this.mtxtCC.Location = new System.Drawing.Point(635, 70);
            this.mtxtCC.Name = "mtxtCC";
            this.mtxtCC.Size = new System.Drawing.Size(412, 22);
            this.mtxtCC.TabIndex = 16;
            // 
            // mtxtTelefono
            // 
            this.mtxtTelefono.Location = new System.Drawing.Point(144, 109);
            this.mtxtTelefono.Name = "mtxtTelefono";
            this.mtxtTelefono.Size = new System.Drawing.Size(299, 22);
            this.mtxtTelefono.TabIndex = 17;
            // 
            // frmReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1172, 767);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbxSocio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmReservas";
            this.Text = "frmReservas";
            this.Load += new System.EventHandler(this.frmReservas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pistaPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDminutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDhora)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReserva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBD1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxSocio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label label10;
        private dsBD dsBD1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label txtOcultoId;
        private System.Windows.Forms.Label txtOcultoPrecio;
        private System.Windows.Forms.PictureBox pistaPicture;
        private System.Windows.Forms.NumericUpDown numUDminutos;
        private System.Windows.Forms.NumericUpDown numUDhora;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnReserva;
        private System.Windows.Forms.ComboBox cbxPista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.DataGridView dtgvReserva;
        private System.Windows.Forms.TextBox txtOculto;
        private System.Windows.Forms.TextBox txtIdOculto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pagado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.TextBox mtxtCC;
        private System.Windows.Forms.TextBox mtxtTelefono;
    }
}