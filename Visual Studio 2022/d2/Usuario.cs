using System;
using System.Windows.Forms;

namespace d2
{
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var home = new Home();
            home.Show(this);
            this.Visible = false;
        }

        private void lbPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'd2Usuario.tb_Usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_UsuarioTableAdapter.Fill(this.d2Usuario.tb_Usuario);

        }
    }
}
