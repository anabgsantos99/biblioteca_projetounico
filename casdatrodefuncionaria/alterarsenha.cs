using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using teladelogin;

namespace casdatrodefuncionaria
{
    public partial class frmRedefinirSenha : Form
    {
        public frmRedefinirSenha()
        {
            InitializeComponent();
        }


        private void txtNovaSenha_Click(object sender, EventArgs e)
        {
            frmPerguntadeSegurança.limpartxt(txtNovaSenha, "Nova Senha");
        }

        private void txtConfirmarSenha_Click(object sender, EventArgs e)
        {
            frmPerguntadeSegurança.limpartxt(txtConfirmarSenha, "Confirme a senha");
        }

        private void lblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmTeladeLogin frmLogin = new frmTeladeLogin();
            frmLogin.Show();
            this.Hide();
        }
    }
}
