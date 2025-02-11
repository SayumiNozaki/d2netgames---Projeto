using System;
using System.Drawing;
using System.Windows.Forms;

namespace d2
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente();
            cliente.Show(this);
            this.Visible = false;
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            var estoque = new Estoque();
            estoque.Show(this);
            this.Visible = false;
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            var financeiro = new Financeiro();
            financeiro.Show(this);
            this.Visible = false;
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario();
            usuario.Show(this);
            this.Visible = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Você deseja se desconectar?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (resultado == DialogResult.OK)
            {
                var login = new Form1();
                login.Show(this);
                this.Visible = false;
            }
        }

        private void btnSair_Enter(object sender, EventArgs e)
        {
            btnSair.BackColor = Color.Red;
        }

        private void btnSair_Leave(object sender, EventArgs e)
        {
            btnSair.BackColor = Color.Silver;
        }

        private void btnCliente_Enter(object sender, EventArgs e)
        {
            btnCliente.BackColor = Color.LightGreen;
        }

        private void btnCliente_Leave(object sender, EventArgs e)
        {
            btnCliente.BackColor = Color.Silver;
        }

        private void btnEstoque_Enter(object sender, EventArgs e)
        {
            btnEstoque.BackColor = Color.LightGreen;
        }

        private void btnEstoque_Leave(object sender, EventArgs e)
        {
            btnEstoque.BackColor= Color.Silver;
        }

        private void btnFinanceiro_Enter(object sender, EventArgs e)
        {
            btnFinanceiro.BackColor = Color.LightGreen;
        }

        private void btnFinanceiro_Leave(object sender, EventArgs e)
        {
            btnFinanceiro.BackColor= Color.Silver;
        }

        private void btnUsuario_Enter(object sender, EventArgs e)
        {
            btnUsuario.BackColor = Color.LightGreen;
        }

        private void btnUsuario_Leave(object sender, EventArgs e)
        {
            btnUsuario.BackColor = Color.Silver;
        }
    }
}
