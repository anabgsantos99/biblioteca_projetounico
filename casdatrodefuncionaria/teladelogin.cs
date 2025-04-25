using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using telaatividades;
using casdatrodefuncionaria;

namespace teladelogin
{
    public partial class frmTeladeLogin : Form
    {

        public frmTeladeLogin()
        {
            InitializeComponent();
        }

        int tentativas = 0; // Pode declarar isso como variável de classe se quiser controlar fora do método

        private void btnLogin_Click(object sender, EventArgs e)
        {
           

            MySqlConnection conexao = null; // Declaração da conexão FORA do try

            string emailDigitado = txtEmail.Text.Trim();

            string senhaDigitada = txtSenha.Text.Trim();

            try

            {

                string data_source = "datasource=localhost; username=root; password=; database=sistemasdetarefas";

                conexao = new MySqlConnection(data_source);

                conexao.Open();

                string sql = "SELECT senha FROM funcionaria WHERE email = @email";

                MySqlCommand cmd = new MySqlCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@email", emailDigitado);

                using (MySqlDataReader reader = cmd.ExecuteReader())

                {

                    if (reader.Read())

                    {

                        string senhaBanco = reader["senha"].ToString();

                        if (senhaDigitada == senhaBanco)

                        {

                            MessageBox.Show("Login realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Lógica após login bem-sucedido

                        }

                        else

                        {

                            MessageBox.Show("Senha incorreta. Tente novamente.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            // Lógica para tentativas de login falhas

                        }

                    }

                    else

                    {

                        MessageBox.Show("Email não encontrado.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                }

                frmTeladeAtividade frmAtividades = new frmTeladeAtividade();
                frmAtividades.Show();
                this.Hide();

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


        private void rbLembreme_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblCriarConta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCadastroFuncionaria frmCadastroFuncionaria = new frmCadastroFuncionaria();
            frmCadastroFuncionaria.Show();
            this.Hide();
        }

        private void lblEsqueciasenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPerguntadeSegurança frmPergunta = new frmPerguntadeSegurança();
            frmPergunta.Show();
            this.Hide();
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            frmPerguntadeSegurança.limpartxt(txtEmail, "E-mail");
        }

        private void txtSenha_Click(object sender, EventArgs e)
        {
            frmPerguntadeSegurança.limpartxt(txtSenha, "Senha");
        }

    }
}




           