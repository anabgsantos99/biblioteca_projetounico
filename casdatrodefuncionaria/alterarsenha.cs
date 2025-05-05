using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
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

        private string email;
        public frmRedefinirSenha(string emailDigitado)
        {
            email = emailDigitado;
            InitializeComponent();

            if (txtNovaSenha.Text != "Nova Senha")
            { 
            txtNovaSenha.UseSystemPasswordChar = true;
            }

            if (txtConfirmarSenha.Text != "Confirme a senha")
            {
                txtConfirmarSenha.UseSystemPasswordChar = true;
            }

            txtNovaSenha.KeyDown += textBox_KeyDown;
            txtConfirmarSenha.KeyDown += textBox_KeyDown;
            
            txtConfirmarSenha.GotFocus += txtSenha_GotFocus;


        }


    private void txtSenha_GotFocus(object sender, EventArgs e)
    {
        if (txtConfirmarSenha.Text == "Confirme a senha")
        {
            txtConfirmarSenha.Text = "";
            txtConfirmarSenha.UseSystemPasswordChar = true;
        }
    }


    private void txtNovaSenha_Click(object sender, EventArgs e)
        {
            frmPerguntadeSeguranca.limpartxt(txtNovaSenha, "Nova Senha");
            txtNovaSenha.UseSystemPasswordChar = true;
        }

        private void txtConfirmarSenha_Click(object sender, EventArgs e)
        {
            frmPerguntadeSeguranca.limpartxt(txtConfirmarSenha, "Confirme a senha");
            txtConfirmarSenha.UseSystemPasswordChar = true;
        }

        private void lblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPerguntadeSeguranca.navegabilidade(new frmTeladeLogin(), this);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string novaSenha = txtNovaSenha.Text.Trim();
            string confirmaSenha = txtConfirmarSenha.Text.Trim();
            string senhaDigitada = txtNovaSenha.Text.Trim();

            string data_source = "datasource=localhost; username=root; password=; database=sistemasdetarefas";


            using (MySqlConnection conexao = new MySqlConnection(data_source))
            {
                try
                {
                    conexao.Open();

                    string sql = "SELECT senha FROM funcionaria WHERE email = @email";
                    MySqlCommand cmdSelect = new MySqlCommand(sql, conexao);
                    cmdSelect.Parameters.AddWithValue("@email", email);

                    string senhaBanco = "";

                    using (MySqlDataReader reader = cmdSelect.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            senhaBanco = reader["senha"].ToString();
                        }
                    }

                    if (senhaDigitada == senhaBanco && senhaDigitada == confirmaSenha)
                    {
                        MessageBox.Show("A senha não pode ser igual a anterior", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        
                    }
                    else
                    {
                        string atualizar = $"UPDATE `funcionaria` SET " +
                                            $"senha = @senha " +
                                            $"WHERE email = @email";
                        MySqlCommand cmdUpdate = new MySqlCommand(atualizar, conexao);
                        cmdUpdate.Parameters.AddWithValue("@email", email);
                        cmdUpdate.Parameters.AddWithValue("@senha", senhaDigitada);
                        cmdUpdate.ExecuteNonQuery();

                        MessageBox.Show($"A senha com o email: {email} foi alterada com Sucesso!",
                                        "Sucesso",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                        frmPerguntadeSeguranca.navegabilidade(new frmTeladeLogin(), this);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Erro MySQL {ex.Number}: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally

                {
                    // Agora 'conexao' deve estar acessível aqui
                    if (conexao != null && conexao.State == ConnectionState.Open)
                    {
                        conexao.Close();
                    }
                }
            }

        }

        private void pbMostrar_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionaria.visibilidade_senha(txtNovaSenha, pbMostrar, pbEsconder);
        }

        private void pbEsconder_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionaria.visibilidade_senha(txtNovaSenha, pbMostrar, pbEsconder);
        }

        private void pbMostrar2_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionaria.visibilidade_senha(txtConfirmarSenha, pbMostrar2, pbEsconder2);
        }

        private void pbEsconder2_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionaria.visibilidade_senha(txtConfirmarSenha, pbMostrar2, pbEsconder2);
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita o som "beep"
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void frmRedefinirSenha_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
