namespace PresentacionSantoCamaron
{
    partial class FrmMesa
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.lblReloj = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblPantalla = new System.Windows.Forms.Label();
            this.lblNOMesa = new System.Windows.Forms.Label();
            this.PaPedido = new System.Windows.Forms.Panel();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.PaToma = new System.Windows.Forms.Panel();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblPreci = new System.Windows.Forms.Label();
            this.lblCanti = new System.Windows.Forms.Label();
            this.lblPla = new System.Windows.Forms.Label();
            this.lblNUMPe = new System.Windows.Forms.Label();
            this.lblMesa = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNOPedido = new System.Windows.Forms.Label();
            this.lblNombreMe = new System.Windows.Forms.Label();
            this.btnMesa20 = new System.Windows.Forms.Button();
            this.btnMesa18 = new System.Windows.Forms.Button();
            this.btnMesa19 = new System.Windows.Forms.Button();
            this.btnMesa17 = new System.Windows.Forms.Button();
            this.btnMesa16 = new System.Windows.Forms.Button();
            this.btnMesa15 = new System.Windows.Forms.Button();
            this.btnMesa13 = new System.Windows.Forms.Button();
            this.btnMesa14 = new System.Windows.Forms.Button();
            this.btnMesa12 = new System.Windows.Forms.Button();
            this.btnMesa11 = new System.Windows.Forms.Button();
            this.btnMesa10 = new System.Windows.Forms.Button();
            this.btnMesa8 = new System.Windows.Forms.Button();
            this.btnMesa9 = new System.Windows.Forms.Button();
            this.btnMesa7 = new System.Windows.Forms.Button();
            this.btnMesa6 = new System.Windows.Forms.Button();
            this.btnMesa5 = new System.Windows.Forms.Button();
            this.btnMesa3 = new System.Windows.Forms.Button();
            this.btnMesa4 = new System.Windows.Forms.Button();
            this.btnMesa2 = new System.Windows.Forms.Button();
            this.btnMesa1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TReloj = new System.Windows.Forms.Timer(this.components);
            this.dtgPedidos = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.PaPedido.SuspendLayout();
            this.PaToma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(197)))), ((int)(((byte)(19)))));
            this.panel1.Controls.Add(this.btnPedidos);
            this.panel1.Controls.Add(this.lblReloj);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.LblUsuario);
            this.panel1.Controls.Add(this.LblFecha);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 1080);
            this.panel1.TabIndex = 0;
            // 
            // btnPedidos
            // 
            this.btnPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(72)))), ((int)(((byte)(30)))));
            this.btnPedidos.Location = new System.Drawing.Point(213, 867);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(155, 45);
            this.btnPedidos.TabIndex = 5;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.UseVisualStyleBackColor = false;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // lblReloj
            // 
            this.lblReloj.AutoSize = true;
            this.lblReloj.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReloj.Location = new System.Drawing.Point(207, 706);
            this.lblReloj.Name = "lblReloj";
            this.lblReloj.Size = new System.Drawing.Size(82, 33);
            this.lblReloj.TabIndex = 4;
            this.lblReloj.Text = "Reloj";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(72)))), ((int)(((byte)(30)))));
            this.btnSalir.Location = new System.Drawing.Point(213, 948);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(155, 45);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(94, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(439, 333);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Location = new System.Drawing.Point(263, 491);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(116, 31);
            this.LblUsuario.TabIndex = 1;
            this.LblUsuario.Text = "Usuario:";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.Location = new System.Drawing.Point(207, 655);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(96, 33);
            this.LblFecha.TabIndex = 0;
            this.LblFecha.Text = "Fecha";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(72)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.LblPantalla);
            this.panel2.Location = new System.Drawing.Point(610, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1311, 163);
            this.panel2.TabIndex = 1;
            // 
            // LblPantalla
            // 
            this.LblPantalla.AutoSize = true;
            this.LblPantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPantalla.Location = new System.Drawing.Point(463, 44);
            this.LblPantalla.Name = "LblPantalla";
            this.LblPantalla.Size = new System.Drawing.Size(437, 55);
            this.LblPantalla.TabIndex = 0;
            this.LblPantalla.Text = "B I E N V E N I D O";
            // 
            // lblNOMesa
            // 
            this.lblNOMesa.AutoSize = true;
            this.lblNOMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNOMesa.Location = new System.Drawing.Point(120, 62);
            this.lblNOMesa.Name = "lblNOMesa";
            this.lblNOMesa.Size = new System.Drawing.Size(122, 29);
            this.lblNOMesa.TabIndex = 3;
            this.lblNOMesa.Text = "No. Mesa:";
            // 
            // PaPedido
            // 
            this.PaPedido.BackColor = System.Drawing.Color.White;
            this.PaPedido.Controls.Add(this.lblBuscar);
            this.PaPedido.Controls.Add(this.txtBuscar);
            this.PaPedido.Controls.Add(this.btnRegresar);
            this.PaPedido.Controls.Add(this.btnAgregar);
            this.PaPedido.Controls.Add(this.PaToma);
            this.PaPedido.Controls.Add(this.lblSubtotal);
            this.PaPedido.Controls.Add(this.lblPreci);
            this.PaPedido.Controls.Add(this.lblCanti);
            this.PaPedido.Controls.Add(this.lblPla);
            this.PaPedido.Controls.Add(this.lblNUMPe);
            this.PaPedido.Controls.Add(this.lblMesa);
            this.PaPedido.Controls.Add(this.lblNombre);
            this.PaPedido.Controls.Add(this.lblNOPedido);
            this.PaPedido.Controls.Add(this.lblNombreMe);
            this.PaPedido.Controls.Add(this.lblNOMesa);
            this.PaPedido.Location = new System.Drawing.Point(612, 162);
            this.PaPedido.Name = "PaPedido";
            this.PaPedido.Size = new System.Drawing.Size(1302, 898);
            this.PaPedido.TabIndex = 2;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(8, 14);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(54, 41);
            this.btnRegresar.TabIndex = 15;
            this.btnRegresar.Text = "←";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(80, 215);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(54, 41);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // PaToma
            // 
            this.PaToma.BackColor = System.Drawing.Color.DarkGray;
            this.PaToma.Controls.Add(this.dtgPedidos);
            this.PaToma.Location = new System.Drawing.Point(153, 298);
            this.PaToma.Name = "PaToma";
            this.PaToma.Size = new System.Drawing.Size(1011, 584);
            this.PaToma.TabIndex = 13;
            this.PaToma.Paint += new System.Windows.Forms.PaintEventHandler(this.PaToma_Paint);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(1009, 220);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(107, 29);
            this.lblSubtotal.TabIndex = 12;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // lblPreci
            // 
            this.lblPreci.AutoSize = true;
            this.lblPreci.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreci.Location = new System.Drawing.Point(770, 220);
            this.lblPreci.Name = "lblPreci";
            this.lblPreci.Size = new System.Drawing.Size(89, 29);
            this.lblPreci.TabIndex = 11;
            this.lblPreci.Text = "Precio:";
            // 
            // lblCanti
            // 
            this.lblCanti.AutoSize = true;
            this.lblCanti.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCanti.Location = new System.Drawing.Point(503, 220);
            this.lblCanti.Name = "lblCanti";
            this.lblCanti.Size = new System.Drawing.Size(115, 29);
            this.lblCanti.TabIndex = 10;
            this.lblCanti.Text = "Cantidad:";
            // 
            // lblPla
            // 
            this.lblPla.AutoSize = true;
            this.lblPla.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPla.Location = new System.Drawing.Point(176, 220);
            this.lblPla.Name = "lblPla";
            this.lblPla.Size = new System.Drawing.Size(170, 29);
            this.lblPla.TabIndex = 9;
            this.lblPla.Text = "Platillo/Bebida";
            // 
            // lblNUMPe
            // 
            this.lblNUMPe.AutoSize = true;
            this.lblNUMPe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNUMPe.Location = new System.Drawing.Point(1070, 116);
            this.lblNUMPe.Name = "lblNUMPe";
            this.lblNUMPe.Size = new System.Drawing.Size(64, 29);
            this.lblNUMPe.TabIndex = 8;
            this.lblNUMPe.Text = "XXX";
            // 
            // lblMesa
            // 
            this.lblMesa.AutoSize = true;
            this.lblMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesa.Location = new System.Drawing.Point(148, 116);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(64, 29);
            this.lblMesa.TabIndex = 7;
            this.lblMesa.Text = "XXX";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(634, 116);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 29);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "XXX";
            // 
            // lblNOPedido
            // 
            this.lblNOPedido.AutoSize = true;
            this.lblNOPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNOPedido.Location = new System.Drawing.Point(1034, 62);
            this.lblNOPedido.Name = "lblNOPedido";
            this.lblNOPedido.Size = new System.Drawing.Size(141, 29);
            this.lblNOPedido.TabIndex = 5;
            this.lblNOPedido.Text = "No. Pedido:";
            // 
            // lblNombreMe
            // 
            this.lblNombreMe.AutoSize = true;
            this.lblNombreMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMe.Location = new System.Drawing.Point(560, 62);
            this.lblNombreMe.Name = "lblNombreMe";
            this.lblNombreMe.Size = new System.Drawing.Size(235, 29);
            this.lblNombreMe.TabIndex = 4;
            this.lblNombreMe.Text = "Nombre del Mesero:";
            // 
            // btnMesa20
            // 
            this.btnMesa20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(72)))), ((int)(((byte)(30)))));
            this.btnMesa20.Location = new System.Drawing.Point(1625, 901);
            this.btnMesa20.Name = "btnMesa20";
            this.btnMesa20.Size = new System.Drawing.Size(150, 110);
            this.btnMesa20.TabIndex = 45;
            this.btnMesa20.Text = "20";
            this.btnMesa20.UseVisualStyleBackColor = false;
            this.btnMesa20.Click += new System.EventHandler(this.btnMesa20_Click);
            // 
            // btnMesa18
            // 
            this.btnMesa18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(72)))), ((int)(((byte)(30)))));
            this.btnMesa18.Location = new System.Drawing.Point(1200, 901);
            this.btnMesa18.Name = "btnMesa18";
            this.btnMesa18.Size = new System.Drawing.Size(150, 110);
            this.btnMesa18.TabIndex = 44;
            this.btnMesa18.Text = "18";
            this.btnMesa18.UseVisualStyleBackColor = false;
            this.btnMesa18.Click += new System.EventHandler(this.btnMesa18_Click);
            // 
            // btnMesa19
            // 
            this.btnMesa19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(72)))), ((int)(((byte)(30)))));
            this.btnMesa19.Location = new System.Drawing.Point(1411, 901);
            this.btnMesa19.Name = "btnMesa19";
            this.btnMesa19.Size = new System.Drawing.Size(150, 110);
            this.btnMesa19.TabIndex = 43;
            this.btnMesa19.Text = "19";
            this.btnMesa19.UseVisualStyleBackColor = false;
            this.btnMesa19.Click += new System.EventHandler(this.btnMesa19_Click);
            // 
            // btnMesa17
            // 
            this.btnMesa17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(72)))), ((int)(((byte)(30)))));
            this.btnMesa17.Location = new System.Drawing.Point(999, 901);
            this.btnMesa17.Name = "btnMesa17";
            this.btnMesa17.Size = new System.Drawing.Size(150, 110);
            this.btnMesa17.TabIndex = 42;
            this.btnMesa17.Text = "17";
            this.btnMesa17.UseVisualStyleBackColor = false;
            this.btnMesa17.Click += new System.EventHandler(this.btnMesa17_Click);
            // 
            // btnMesa16
            // 
            this.btnMesa16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(72)))), ((int)(((byte)(30)))));
            this.btnMesa16.Location = new System.Drawing.Point(809, 901);
            this.btnMesa16.Name = "btnMesa16";
            this.btnMesa16.Size = new System.Drawing.Size(150, 110);
            this.btnMesa16.TabIndex = 41;
            this.btnMesa16.Text = "16";
            this.btnMesa16.UseVisualStyleBackColor = false;
            this.btnMesa16.Click += new System.EventHandler(this.btnMesa16_Click);
            // 
            // btnMesa15
            // 
            this.btnMesa15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(72)))), ((int)(((byte)(30)))));
            this.btnMesa15.Location = new System.Drawing.Point(1625, 706);
            this.btnMesa15.Name = "btnMesa15";
            this.btnMesa15.Size = new System.Drawing.Size(150, 110);
            this.btnMesa15.TabIndex = 40;
            this.btnMesa15.Text = "15";
            this.btnMesa15.UseVisualStyleBackColor = false;
            this.btnMesa15.Click += new System.EventHandler(this.btnMesa15_Click);
            // 
            // btnMesa13
            // 
            this.btnMesa13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(72)))), ((int)(((byte)(30)))));
            this.btnMesa13.Location = new System.Drawing.Point(1200, 706);
            this.btnMesa13.Name = "btnMesa13";
            this.btnMesa13.Size = new System.Drawing.Size(150, 110);
            this.btnMesa13.TabIndex = 39;
            this.btnMesa13.Text = "13";
            this.btnMesa13.UseVisualStyleBackColor = false;
            this.btnMesa13.Click += new System.EventHandler(this.btnMesa13_Click);
            // 
            // btnMesa14
            // 
            this.btnMesa14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(72)))), ((int)(((byte)(30)))));
            this.btnMesa14.Location = new System.Drawing.Point(1411, 706);
            this.btnMesa14.Name = "btnMesa14";
            this.btnMesa14.Size = new System.Drawing.Size(150, 110);
            this.btnMesa14.TabIndex = 38;
            this.btnMesa14.Text = "14";
            this.btnMesa14.UseVisualStyleBackColor = false;
            this.btnMesa14.Click += new System.EventHandler(this.btnMesa14_Click);
            // 
            // btnMesa12
            // 
            this.btnMesa12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(72)))), ((int)(((byte)(30)))));
            this.btnMesa12.Location = new System.Drawing.Point(999, 706);
            this.btnMesa12.Name = "btnMesa12";
            this.btnMesa12.Size = new System.Drawing.Size(150, 110);
            this.btnMesa12.TabIndex = 37;
            this.btnMesa12.Text = "12";
            this.btnMesa12.UseVisualStyleBackColor = false;
            this.btnMesa12.Click += new System.EventHandler(this.btnMesa12_Click);
            // 
            // btnMesa11
            // 
            this.btnMesa11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(72)))), ((int)(((byte)(30)))));
            this.btnMesa11.Location = new System.Drawing.Point(809, 706);
            this.btnMesa11.Name = "btnMesa11";
            this.btnMesa11.Size = new System.Drawing.Size(150, 110);
            this.btnMesa11.TabIndex = 36;
            this.btnMesa11.Text = "11";
            this.btnMesa11.UseVisualStyleBackColor = false;
            this.btnMesa11.Click += new System.EventHandler(this.btnMesa11_Click);
            // 
            // btnMesa10
            // 
            this.btnMesa10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(72)))), ((int)(((byte)(30)))));
            this.btnMesa10.Location = new System.Drawing.Point(1625, 503);
            this.btnMesa10.Name = "btnMesa10";
            this.btnMesa10.Size = new System.Drawing.Size(150, 110);
            this.btnMesa10.TabIndex = 35;
            this.btnMesa10.Text = "10";
            this.btnMesa10.UseVisualStyleBackColor = false;
            this.btnMesa10.Click += new System.EventHandler(this.btnMesa10_Click);
            // 
            // btnMesa8
            // 
            this.btnMesa8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(72)))), ((int)(((byte)(30)))));
            this.btnMesa8.Location = new System.Drawing.Point(1200, 503);
            this.btnMesa8.Name = "btnMesa8";
            this.btnMesa8.Size = new System.Drawing.Size(150, 110);
            this.btnMesa8.TabIndex = 34;
            this.btnMesa8.Text = "8";
            this.btnMesa8.UseVisualStyleBackColor = false;
            this.btnMesa8.Click += new System.EventHandler(this.btnMesa8_Click);
            // 
            // btnMesa9
            // 
            this.btnMesa9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(72)))), ((int)(((byte)(30)))));
            this.btnMesa9.Location = new System.Drawing.Point(1411, 503);
            this.btnMesa9.Name = "btnMesa9";
            this.btnMesa9.Size = new System.Drawing.Size(150, 110);
            this.btnMesa9.TabIndex = 33;
            this.btnMesa9.Text = "9";
            this.btnMesa9.UseVisualStyleBackColor = false;
            this.btnMesa9.Click += new System.EventHandler(this.btnMesa9_Click);
            // 
            // btnMesa7
            // 
            this.btnMesa7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(72)))), ((int)(((byte)(30)))));
            this.btnMesa7.Location = new System.Drawing.Point(999, 503);
            this.btnMesa7.Name = "btnMesa7";
            this.btnMesa7.Size = new System.Drawing.Size(150, 110);
            this.btnMesa7.TabIndex = 32;
            this.btnMesa7.Text = "7";
            this.btnMesa7.UseVisualStyleBackColor = false;
            this.btnMesa7.Click += new System.EventHandler(this.btnMesa7_Click);
            // 
            // btnMesa6
            // 
            this.btnMesa6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(72)))), ((int)(((byte)(30)))));
            this.btnMesa6.Location = new System.Drawing.Point(809, 503);
            this.btnMesa6.Name = "btnMesa6";
            this.btnMesa6.Size = new System.Drawing.Size(150, 110);
            this.btnMesa6.TabIndex = 31;
            this.btnMesa6.Text = "6";
            this.btnMesa6.UseVisualStyleBackColor = false;
            this.btnMesa6.Click += new System.EventHandler(this.btnMesa6_Click);
            // 
            // btnMesa5
            // 
            this.btnMesa5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(72)))), ((int)(((byte)(30)))));
            this.btnMesa5.Location = new System.Drawing.Point(1625, 301);
            this.btnMesa5.Name = "btnMesa5";
            this.btnMesa5.Size = new System.Drawing.Size(150, 110);
            this.btnMesa5.TabIndex = 30;
            this.btnMesa5.Text = "5";
            this.btnMesa5.UseVisualStyleBackColor = false;
            this.btnMesa5.Click += new System.EventHandler(this.btnMesa5_Click);
            // 
            // btnMesa3
            // 
            this.btnMesa3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(72)))), ((int)(((byte)(30)))));
            this.btnMesa3.Location = new System.Drawing.Point(1200, 301);
            this.btnMesa3.Name = "btnMesa3";
            this.btnMesa3.Size = new System.Drawing.Size(150, 110);
            this.btnMesa3.TabIndex = 29;
            this.btnMesa3.Text = "3";
            this.btnMesa3.UseVisualStyleBackColor = false;
            this.btnMesa3.Click += new System.EventHandler(this.btnMesa3_Click);
            // 
            // btnMesa4
            // 
            this.btnMesa4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(72)))), ((int)(((byte)(30)))));
            this.btnMesa4.Location = new System.Drawing.Point(1411, 301);
            this.btnMesa4.Name = "btnMesa4";
            this.btnMesa4.Size = new System.Drawing.Size(150, 110);
            this.btnMesa4.TabIndex = 28;
            this.btnMesa4.Text = "4";
            this.btnMesa4.UseVisualStyleBackColor = false;
            this.btnMesa4.Click += new System.EventHandler(this.btnMesa4_Click);
            // 
            // btnMesa2
            // 
            this.btnMesa2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(72)))), ((int)(((byte)(30)))));
            this.btnMesa2.Location = new System.Drawing.Point(999, 301);
            this.btnMesa2.Name = "btnMesa2";
            this.btnMesa2.Size = new System.Drawing.Size(150, 110);
            this.btnMesa2.TabIndex = 27;
            this.btnMesa2.Text = "2";
            this.btnMesa2.UseVisualStyleBackColor = false;
            this.btnMesa2.Click += new System.EventHandler(this.btnMesa2_Click);
            // 
            // btnMesa1
            // 
            this.btnMesa1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(72)))), ((int)(((byte)(30)))));
            this.btnMesa1.Location = new System.Drawing.Point(809, 301);
            this.btnMesa1.Name = "btnMesa1";
            this.btnMesa1.Size = new System.Drawing.Size(150, 110);
            this.btnMesa1.TabIndex = 26;
            this.btnMesa1.Text = "1";
            this.btnMesa1.UseVisualStyleBackColor = false;
            this.btnMesa1.Click += new System.EventHandler(this.btnMesa1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1170, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 31);
            this.label4.TabIndex = 25;
            this.label4.Text = "Selecciona Mesa:";
            // 
            // TReloj
            // 
            this.TReloj.Enabled = true;
            this.TReloj.Interval = 1000;
            this.TReloj.Tick += new System.EventHandler(this.TReloj_Tick);
            // 
            // dtgPedidos
            // 
            this.dtgPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPedidos.Location = new System.Drawing.Point(0, 0);
            this.dtgPedidos.Name = "dtgPedidos";
            this.dtgPedidos.Size = new System.Drawing.Size(1011, 584);
            this.dtgPedidos.TabIndex = 16;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(311, 179);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(852, 31);
            this.txtBuscar.TabIndex = 17;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(176, 179);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(93, 29);
            this.lblBuscar.TabIndex = 18;
            this.lblBuscar.Text = "Buscar:";
            // 
            // FrmMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 1061);
            this.Controls.Add(this.PaPedido);
            this.Controls.Add(this.btnMesa20);
            this.Controls.Add(this.btnMesa18);
            this.Controls.Add(this.btnMesa19);
            this.Controls.Add(this.btnMesa17);
            this.Controls.Add(this.btnMesa16);
            this.Controls.Add(this.btnMesa15);
            this.Controls.Add(this.btnMesa13);
            this.Controls.Add(this.btnMesa14);
            this.Controls.Add(this.btnMesa12);
            this.Controls.Add(this.btnMesa11);
            this.Controls.Add(this.btnMesa10);
            this.Controls.Add(this.btnMesa8);
            this.Controls.Add(this.btnMesa9);
            this.Controls.Add(this.btnMesa7);
            this.Controls.Add(this.btnMesa6);
            this.Controls.Add(this.btnMesa5);
            this.Controls.Add(this.btnMesa3);
            this.Controls.Add(this.btnMesa4);
            this.Controls.Add(this.btnMesa2);
            this.Controls.Add(this.btnMesa1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FrmMesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMesa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.PaPedido.ResumeLayout(false);
            this.PaPedido.PerformLayout();
            this.PaToma.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblPantalla;
        private System.Windows.Forms.Label lblReloj;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblNOMesa;
        private System.Windows.Forms.Panel PaPedido;
        private System.Windows.Forms.Label lblNUMPe;
        private System.Windows.Forms.Label lblMesa;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNOPedido;
        private System.Windows.Forms.Label lblNombreMe;
        private System.Windows.Forms.Button btnMesa20;
        private System.Windows.Forms.Button btnMesa18;
        private System.Windows.Forms.Button btnMesa19;
        private System.Windows.Forms.Button btnMesa17;
        private System.Windows.Forms.Button btnMesa16;
        private System.Windows.Forms.Button btnMesa15;
        private System.Windows.Forms.Button btnMesa13;
        private System.Windows.Forms.Button btnMesa14;
        private System.Windows.Forms.Button btnMesa12;
        private System.Windows.Forms.Button btnMesa11;
        private System.Windows.Forms.Button btnMesa10;
        private System.Windows.Forms.Button btnMesa8;
        private System.Windows.Forms.Button btnMesa9;
        private System.Windows.Forms.Button btnMesa7;
        private System.Windows.Forms.Button btnMesa6;
        private System.Windows.Forms.Button btnMesa5;
        private System.Windows.Forms.Button btnMesa3;
        private System.Windows.Forms.Button btnMesa4;
        private System.Windows.Forms.Button btnMesa2;
        private System.Windows.Forms.Button btnMesa1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel PaToma;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblPreci;
        private System.Windows.Forms.Label lblCanti;
        private System.Windows.Forms.Label lblPla;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Timer TReloj;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dtgPedidos;
    }
}