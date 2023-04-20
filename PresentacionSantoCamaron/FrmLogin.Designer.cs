namespace PresentacionSantoCamaron
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.PALogin = new System.Windows.Forms.Panel();
            this.lblFrase = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PaSesion = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtContraseñaTRA = new System.Windows.Forms.TextBox();
            this.txtUsuarioTRA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLoginGE = new System.Windows.Forms.Button();
            this.txtContraseñaGE = new System.Windows.Forms.TextBox();
            this.txtUsuarioGE = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PicLogin = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnGerente = new System.Windows.Forms.Button();
            this.btnTrabajador = new System.Windows.Forms.Button();
            this.btnClose2 = new System.Windows.Forms.Button();
            this.PALogin.SuspendLayout();
            this.PaSesion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // PALogin
            // 
            this.PALogin.Controls.Add(this.lblFrase);
            this.PALogin.Controls.Add(this.PicLogin);
            this.PALogin.Location = new System.Drawing.Point(0, 0);
            this.PALogin.Name = "PALogin";
            this.PALogin.Size = new System.Drawing.Size(668, 573);
            this.PALogin.TabIndex = 0;
            // 
            // lblFrase
            // 
            this.lblFrase.AutoSize = true;
            this.lblFrase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(197)))), ((int)(((byte)(19)))));
            this.lblFrase.Font = new System.Drawing.Font("RomanC", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrase.Location = new System.Drawing.Point(51, 455);
            this.lblFrase.Name = "lblFrase";
            this.lblFrase.Size = new System.Drawing.Size(78, 34);
            this.lblFrase.TabIndex = 8;
            this.lblFrase.Text = "Hola";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("RomanC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inicio de Sesion";
            // 
            // PaSesion
            // 
            this.PaSesion.BackColor = System.Drawing.Color.Transparent;
            this.PaSesion.Controls.Add(this.btnClose);
            this.PaSesion.Controls.Add(this.label8);
            this.PaSesion.Controls.Add(this.label3);
            this.PaSesion.Controls.Add(this.label2);
            this.PaSesion.Controls.Add(this.button1);
            this.PaSesion.Controls.Add(this.txtContraseñaTRA);
            this.PaSesion.Controls.Add(this.txtUsuarioTRA);
            this.PaSesion.Controls.Add(this.label1);
            this.PaSesion.Controls.Add(this.btnGerente);
            this.PaSesion.Location = new System.Drawing.Point(662, 1);
            this.PaSesion.Name = "PaSesion";
            this.PaSesion.Size = new System.Drawing.Size(591, 573);
            this.PaSesion.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("RomanC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(127, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(347, 34);
            this.label8.TabIndex = 7;
            this.label8.Text = "Bienvenido Trabajador";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("RomanC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("RomanC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usuario:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtContraseñaTRA
            // 
            this.txtContraseñaTRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaTRA.Location = new System.Drawing.Point(73, 354);
            this.txtContraseñaTRA.Name = "txtContraseñaTRA";
            this.txtContraseñaTRA.PasswordChar = '*';
            this.txtContraseñaTRA.Size = new System.Drawing.Size(470, 29);
            this.txtContraseñaTRA.TabIndex = 4;
            this.txtContraseñaTRA.UseSystemPasswordChar = true;
            // 
            // txtUsuarioTRA
            // 
            this.txtUsuarioTRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioTRA.Location = new System.Drawing.Point(73, 225);
            this.txtUsuarioTRA.Name = "txtUsuarioTRA";
            this.txtUsuarioTRA.Size = new System.Drawing.Size(470, 29);
            this.txtUsuarioTRA.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("RomanC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 28);
            this.label4.TabIndex = 13;
            this.label4.Text = "Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("RomanC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 28);
            this.label5.TabIndex = 12;
            this.label5.Text = "Usuario:";
            // 
            // btnLoginGE
            // 
            this.btnLoginGE.Location = new System.Drawing.Point(244, 437);
            this.btnLoginGE.Name = "btnLoginGE";
            this.btnLoginGE.Size = new System.Drawing.Size(75, 35);
            this.btnLoginGE.TabIndex = 10;
            this.btnLoginGE.Text = "Login";
            this.btnLoginGE.UseVisualStyleBackColor = true;
            // 
            // txtContraseñaGE
            // 
            this.txtContraseñaGE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaGE.Location = new System.Drawing.Point(57, 380);
            this.txtContraseñaGE.Name = "txtContraseñaGE";
            this.txtContraseñaGE.PasswordChar = '*';
            this.txtContraseñaGE.Size = new System.Drawing.Size(470, 29);
            this.txtContraseñaGE.TabIndex = 11;
            this.txtContraseñaGE.UseSystemPasswordChar = true;
            // 
            // txtUsuarioGE
            // 
            this.txtUsuarioGE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioGE.Location = new System.Drawing.Point(57, 251);
            this.txtUsuarioGE.Name = "txtUsuarioGE";
            this.txtUsuarioGE.Size = new System.Drawing.Size(470, 29);
            this.txtUsuarioGE.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("RomanC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(159, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(256, 34);
            this.label6.TabIndex = 8;
            this.label6.Text = "Inicio de Sesion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("RomanC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(138, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(303, 34);
            this.label7.TabIndex = 14;
            this.label7.Text = "Bienvenido Gerente";
            // 
            // PicLogin
            // 
            this.PicLogin.Image = global::PresentacionSantoCamaron.Properties.Resources.Santo;
            this.PicLogin.Location = new System.Drawing.Point(0, 0);
            this.PicLogin.Name = "PicLogin";
            this.PicLogin.Size = new System.Drawing.Size(668, 571);
            this.PicLogin.TabIndex = 0;
            this.PicLogin.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::PresentacionSantoCamaron.Properties.Resources._10354930_close_ui_web_icon__1_;
            this.btnClose.Location = new System.Drawing.Point(534, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(51, 43);
            this.btnClose.TabIndex = 8;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnGerente
            // 
            this.btnGerente.FlatAppearance.BorderSize = 0;
            this.btnGerente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerente.Image = ((System.Drawing.Image)(resources.GetObject("btnGerente.Image")));
            this.btnGerente.Location = new System.Drawing.Point(25, 515);
            this.btnGerente.Name = "btnGerente";
            this.btnGerente.Size = new System.Drawing.Size(51, 43);
            this.btnGerente.TabIndex = 1;
            this.btnGerente.UseVisualStyleBackColor = true;
            this.btnGerente.Click += new System.EventHandler(this.btnGerente_Click);
            // 
            // btnTrabajador
            // 
            this.btnTrabajador.FlatAppearance.BorderSize = 0;
            this.btnTrabajador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrabajador.Image = ((System.Drawing.Image)(resources.GetObject("btnTrabajador.Image")));
            this.btnTrabajador.Location = new System.Drawing.Point(497, 514);
            this.btnTrabajador.Name = "btnTrabajador";
            this.btnTrabajador.Size = new System.Drawing.Size(75, 47);
            this.btnTrabajador.TabIndex = 15;
            this.btnTrabajador.UseVisualStyleBackColor = true;
            this.btnTrabajador.Click += new System.EventHandler(this.btnTrabajador_Click_2);
            // 
            // btnClose2
            // 
            this.btnClose2.FlatAppearance.BorderSize = 0;
            this.btnClose2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose2.Image = global::PresentacionSantoCamaron.Properties.Resources._10354930_close_ui_web_icon__1_;
            this.btnClose2.Location = new System.Drawing.Point(521, 6);
            this.btnClose2.Name = "btnClose2";
            this.btnClose2.Size = new System.Drawing.Size(51, 43);
            this.btnClose2.TabIndex = 16;
            this.btnClose2.UseVisualStyleBackColor = true;
            this.btnClose2.Click += new System.EventHandler(this.btnClose2_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1253, 571);
            this.Controls.Add(this.PALogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLoginGE);
            this.Controls.Add(this.txtContraseñaGE);
            this.Controls.Add(this.txtUsuarioGE);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PaSesion);
            this.Controls.Add(this.btnTrabajador);
            this.Controls.Add(this.btnClose2);
            this.Controls.Add(this.label7);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.PALogin.ResumeLayout(false);
            this.PALogin.PerformLayout();
            this.PaSesion.ResumeLayout(false);
            this.PaSesion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PALogin;
        private System.Windows.Forms.Button btnGerente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PaSesion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtContraseñaTRA;
        private System.Windows.Forms.TextBox txtUsuarioTRA;
        private System.Windows.Forms.PictureBox PicLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLoginGE;
        private System.Windows.Forms.TextBox txtContraseñaGE;
        private System.Windows.Forms.TextBox txtUsuarioGE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTrabajador;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblFrase;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClose2;
    }
}