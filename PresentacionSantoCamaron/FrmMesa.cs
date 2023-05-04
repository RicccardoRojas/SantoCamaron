using System;
using System.Drawing;
using System.Windows.Forms;
using Diseño;

namespace PresentacionSantoCamaron
{
    public partial class FrmMesa : Form
    {
        Redondo re;
        Animacion A;
        int CONT = 1, X = 28, Y = 29;
        public FrmMesa()
        {
            InitializeComponent();
            re = new Redondo();
            A = new Animacion();
            PaPedido.Location = new Point(2000,167);
            A.IniciarMovimiento(PaPedido);
            LblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            Pedido(false);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PaToma_Paint(object sender, PaintEventArgs e)
        {
            re.Panel(PaToma);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CrearTextBox();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            LblPantalla.Text = "B I E N V E N I D O";
            A.Mover(2000, PaPedido);
        }
        #region Botones_Mesa
        private void btnMesa1_Click_1(object sender, EventArgs e)
        {
            Mesa(1);
            Pedido(false);
        }

        private void btnMesa2_Click(object sender, EventArgs e)
        {
            Mesa(2);
            Pedido(false);
        }


        private void btnMesa3_Click(object sender, EventArgs e)
        {
            Mesa(3);
            Pedido(false);
        }

        private void btnMesa4_Click(object sender, EventArgs e)
        {
            Mesa(4);
            Pedido(false);
        }

        private void btnMesa5_Click(object sender, EventArgs e)
        {
            Mesa(5);
            Pedido(false);
        }

        private void btnMesa6_Click(object sender, EventArgs e)
        {
            Mesa(6);
            Pedido(false);
        }

        private void btnMesa7_Click(object sender, EventArgs e)
        {
            Mesa(7);
            Pedido(false);
        }

        private void btnMesa8_Click(object sender, EventArgs e)
        {
            Mesa(8);
            Pedido(false);
        }

        private void btnMesa9_Click(object sender, EventArgs e)
        {
            Mesa(9);
            Pedido(false);
        }

        private void btnMesa10_Click(object sender, EventArgs e)
        {
            Mesa(10);
            Pedido(false);
        }

        private void btnMesa11_Click(object sender, EventArgs e)
        {
            Mesa(11);
            Pedido(false);
        }

        private void btnMesa12_Click(object sender, EventArgs e)
        {
            Mesa(12);
            Pedido(false);
        }

        private void btnMesa13_Click(object sender, EventArgs e)
        {
            Mesa(13);
            Pedido(false);
        }

        private void btnMesa14_Click(object sender, EventArgs e)
        {
            Mesa(14);
            Pedido(false);
        }

        private void btnMesa15_Click(object sender, EventArgs e)
        {
            Mesa(15);
            Pedido(false);
        }

        private void btnMesa16_Click(object sender, EventArgs e)
        {
            Mesa(16);
            Pedido(false);
        }

        private void btnMesa17_Click(object sender, EventArgs e)
        {
            Mesa(17);
            Pedido(false);
        }

        private void btnMesa18_Click(object sender, EventArgs e)
        {
            Mesa(18);
            Pedido(false);
        }

        private void btnMesa19_Click(object sender, EventArgs e)
        {
            Mesa(19);
            Pedido(false);
        }

        private void btnMesa20_Click(object sender, EventArgs e)
        {
            Mesa(20);
            Pedido(false);
        }

        #endregion

        #region Metodos
        void CrearTextBox()
        {

            for (int i = 0; i < 5; i++)
            {
                ComboBox combo = new ComboBox();
                TextBox tex = new TextBox();

                if (i==1)
                {
                    combo.Name = "txtPla"+CONT;
                    combo.DropDownStyle = ComboBoxStyle.DropDownList;
                    combo.Location = new Point(28, Y);
                    combo.Size = new Size(202, 31);
                    PaToma.Controls.Add(combo);
                }
                if (i==2)
                {
                    tex.Name = "txtCant" + CONT;
                    tex.Location = new Point(332, Y);
                    tex.Size = new Size(154, 31);
                    PaToma.Controls.Add(tex);
                }
                if (i==3)
                {
                    tex.Name = "txtPrec" + CONT;
                    tex.Location = new Point(583, Y);
                    tex.Size = new Size(154, 31);
                    PaToma.Controls.Add(tex);
                }
                if (i==4)
                {
                    tex.Name = "txtSubtota" + CONT;
                    tex.Location = new Point(827, Y);
                    tex.Size = new Size(154, 31);
                    PaToma.Controls.Add(tex);
                }
            }
            CONT += 1;
            Y += 80;
        }

       

        void Mesa(int Num)
        {
            LblPantalla.Text = "Toma de Pedido";
            lblMesa.Text = Num.ToString();
            Y = 29;
            PaToma.Controls.Clear();
            A.Mover(610, PaPedido);
        }

        void Pedido(bool A)
        {
            if (A)
            {
                dtgPedidos.Visible = true;
                lblBuscar.Visible = true;
                txtBuscar.Visible = true;
                lblNOMesa.Visible = false;
                lblNombreMe.Visible = false;
                lblNOPedido.Visible = false;
                lblMesa.Visible = false;
                lblNombre.Visible = false;
                lblNUMPe.Visible = false;
                lblPla.Visible = false;
                lblCanti.Visible = false;
                lblPreci.Visible = false;
                lblSubtotal.Visible = false;
                btnAgregar.Visible = false;
            }
            if (A == false)
            {
                dtgPedidos.Visible = false;
                lblBuscar.Visible = false;
                txtBuscar.Visible = false;
                lblNOMesa.Visible = true;
                lblNombreMe.Visible = true;
                lblNOPedido.Visible = true;
                lblMesa.Visible = true;
                lblNombre.Visible = true;
                lblNUMPe.Visible = true;
                lblPla.Visible = true;
                lblCanti.Visible = true;
                lblPreci.Visible = true;
                lblSubtotal.Visible = true;
                btnAgregar.Visible = true;
            }
        }
        #endregion

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            LblPantalla.Text = "P E D I D O S";
            Pedido(true);
            A.Mover(622, PaPedido);

        }

        private void TReloj_Tick(object sender, EventArgs e)
        {
            lblReloj.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

       
        //610, 167
    }
}
