using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diseño;

namespace PresentacionSantoCamaron
{
    public partial class FrmMesa : Form
    {
        Redondo re;
        Animacion A;
        public FrmMesa()
        {
            InitializeComponent();
            re = new Redondo();
            A = new Animacion();
            PaPedido.Location = new Point(2000,167);
            A.IniciarMovimiento(PaPedido);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PaToma_Paint(object sender, PaintEventArgs e)
        {
            re.Panel(PaToma);
        }
        private void btnMesa1_Click_1(object sender, EventArgs e)
        {
            LblPantalla.Text = "Toma de Pedido";
            lblMesa.Text = "1";
            A.Mover(610, PaPedido);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            LblPantalla.Text = "B I E N V E N I D O";
            A.Mover(2000, PaPedido);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CrearTextBox();
        }

        void CrearTextBox()
        {
            TextBox textBox = new TextBox();
            TextBox textBox2 = new TextBox();
            TextBox textBox1 = new TextBox();
            TextBox textBox3 = new TextBox();

            textBox.Location = new Point(28, 35);
            textBox1.Location = new Point(332, 35);
            textBox2.Location = new Point(583, 35);
            textBox3.Location = new Point(827, 35);

        }
    }
}
