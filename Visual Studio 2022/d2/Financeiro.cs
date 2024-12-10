using System;
using System.Windows.Forms;

namespace d2
{
    public partial class Financeiro : Form
    {
        public Financeiro()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var home = new Home();
            home.Show(this);
            this.Visible = false;
        }

        private void Financeiro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'd2Financeiro.tb_Financeiro'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_FinanceiroTableAdapter.Fill(this.d2Financeiro.tb_Financeiro);

        }
    }
}
