using System;
using System.Windows.Forms;
using Diseño;

namespace PresentacionSantoCamaron
{
    public partial class FrmLogin : Form
    {
        Animacion A;
        public FrmLogin()
        {
            InitializeComponent();
            A = new Animacion();
            A.IniciarMovimiento(PALogin);
            lblFrase.Text = ObtenerFraseDelDia();
        }

        private void btnGerente_Click(object sender, EventArgs e)
        {
            A.Mover(585, PALogin);
            txtUsuarioGE.Focus();
        }
        private void btnTrabajador_Click_2(object sender, EventArgs e)
        {
            A.Mover(0, PALogin);
            txtUsuarioTRA.Focus();
        }

        string ObtenerFraseDelDia()
        {
            string[] frases = {
            "Hoy es un buen \ndía para sonreír.",
            "Cada día es una \nnueva oportunidad para ser feliz.",
            "Si puedes soñarlo, \npuedes lograrlo.",
            "La felicidad no es \ntener lo que quieres, \nsino querer lo que tienes.",
            "El éxito es la suma de pequeños \n" +
            "esfuerzos repetidos \ndía tras día."
        };

            int indiceFrase = DateTime.Now.DayOfYear % frases.Length;
            return frases[indiceFrase];
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClose2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
