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
using telaatividades;
using MySql.Data.MySqlClient;
using System.Runtime.CompilerServices;

namespace casdatrodefuncionaria
{
    public partial class frmPerguntadeSegurança : Form
    {
        public frmPerguntadeSegurança()
        {
            InitializeComponent();
        }


        private void lblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            navegabilidade(new frmTeladeLogin(), this);
        }


        public static void limpartxt(TextBox textBox, string textoBase)
        {
            if (textBox.Text == textoBase)
            {
                textBox.Text = null;
            }
        }

        public static void navegabilidade(Form formulario, Form principal)
        {
            formulario.Show();
            principal.Hide();
        }

        private void txtDigiteSeuEmail_Click(object sender, EventArgs e)
        {
            limpartxt(txtDigiteSeuEmail, "Digite seu e-mail");
        }

        private void txtResposta_Click(object sender, EventArgs e)
        {
            limpartxt(txtResposta, "Resposta");
        }

        private void btnRedefinirSenha_Click(object sender, EventArgs e)
        {

            MySqlConnection conexao = null; // Declaração da conexão FORA do try

            string emailDigitado = txtDigiteSeuEmail.Text.Trim();
            string pergunta = comboBoxPerguntaSeguranca.Text.Trim();
            string resposta = txtResposta.Text.Trim();

            try
            {
                string data_source = "datasource=localhost; username=root; password=; database=sistemasdetarefas";

                conexao = new MySqlConnection(data_source);

                conexao.Open();

                string sql = "SELECT perguntadeseguranca, resposta FROM funcionaria WHERE email = @email";

                MySqlCommand cmd = new MySqlCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@email", emailDigitado);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {

                    if (reader.Read())
                    {

                        string perguntaBanco = reader["perguntadeseguranca"].ToString();
                        string respostaBanco = reader["resposta"].ToString();

                        if (pergunta == perguntaBanco && resposta == respostaBanco)
                        {

                            MessageBox.Show("Dados de recuperação de senha estão corretos!",
                                            "Sucesso",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);

                            // Lógica após informações corretas bem-sucedido

                            navegabilidade(new frmRedefinirSenha(emailDigitado), this);

                            //frmRedefinirSenha frmSenha = new frmRedefinirSenha();
                            //frmSenha.Show();
                            //this.Hide();

                        }

                        else

                        {

                            MessageBox.Show("A pergunta ou a resposta está incorreta!",
                                            "Erro",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);

                            // Lógica para tentativas de login falhas

                        }

                    }

                    else

                    {

                        MessageBox.Show("Email não encontrado.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

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
}
