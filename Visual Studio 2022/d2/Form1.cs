using System;
using System.Windows.Forms;

namespace d2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            var home = new Home();
            home.Show(this);
            this.Visible = false;
        }
    }
}
