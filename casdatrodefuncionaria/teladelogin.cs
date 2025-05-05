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

        MySqlConnection Conexao;

        public frmTeladeLogin()
        {
            InitializeComponent();

            if (txtSenha.Text != "Senha")
            {
                txtSenha.UseSystemPasswordChar = true;
            }


            txtEmail.KeyDown += textBox_KeyDown;
            txtSenha.KeyDown += textBox_KeyDown;


            txtSenha.GotFocus += txtSenha_GotFocus;


        }


        private void txtSenha_GotFocus(object sender, EventArgs e)
        {
            if (txtSenha.Text == "Senha")
            {
                txtSenha.Text = "";
                txtSenha.UseSystemPasswordChar = true;
            }
        }



        //int tentativas = 0; // Pode declarar isso como variável de classe se quiser controlar fora do método

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

                            frmPerguntadeSeguranca.navegabilidade(new frmTeladeAtividade(), this);

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


        private void lblCriarConta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPerguntadeSeguranca.navegabilidade(new frmCadastroFuncionaria(), this);

        }

        private void lblEsqueciasenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPerguntadeSeguranca.navegabilidade(new frmPerguntadeSeguranca(), this);

        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            frmPerguntadeSeguranca.limpartxt(txtEmail, "E-mail");
        }

        private void txtSenha_Click(object sender, EventArgs e)
        {
            
            frmPerguntadeSeguranca.limpartxt(txtSenha, "Senha");

        }


        private void rbLembreme_CheckedChanged(object sender, EventArgs e)
        {
            string data_source = "datasource=localhost; username=root; password=; database=sistemasdetarefas";
            string emailDigitado = txtEmail.Text.Trim();
            bool opcaoLembrese = rbLembreme.Checked;

            try
            {

                if (rbLembreme.Checked)
                {
                    Conexao = new MySqlConnection(data_source);
                    Conexao.Open();

                    //Teste de abertura de banco
                    //MessageBox.Show("Conexão aberta com sucesso");

                    //Comando SQL para inserir um novo cliente no banco de dados
                    MySqlCommand cmd = new MySqlCommand
                    {
                        Connection = Conexao
                    };

                    cmd.Prepare();

                    cmd.CommandText = $"UPDATE `funcionaria` SET " +
                                    $"lembrar_senha = @lembrar_senha " +
                                    $"WHERE email = @email";
                    cmd.Parameters.AddWithValue("@email", emailDigitado);
                    cmd.Parameters.AddWithValue("@lembrar_senha", opcaoLembrese ? 1 : 0);

                    cmd.ExecuteNonQuery();

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
                if (Conexao != null && Conexao.State == ConnectionState.Open)
                {
                    Conexao.Close();
                }
            }

        }



        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = null; // Declaração da conexão FORA do try

            string emailDigitado = txtEmail.Text.Trim();

            try
            {
                string data_source = "datasource=localhost; username=root; password=; database=sistemasdetarefas";

                conexao = new MySqlConnection(data_source);

                conexao.Open();

                string sql = "SELECT senha, lembrar_senha FROM funcionaria WHERE email = @email";

                MySqlCommand cmd = new MySqlCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@email", emailDigitado);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string senhaBanco = reader.GetString("senha");
                        bool opcaoLembrese = reader.GetBoolean("lembrar_senha");

                        if (opcaoLembrese)
                        {
                            txtSenha.UseSystemPasswordChar = true;
                            txtSenha.Text = senhaBanco;
                        }

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


        private void pbMostrar_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionaria.visibilidade_senha(txtSenha, pbMostrar, pbEsconder);
        }

        private void pbEsconder_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionaria.visibilidade_senha(txtSenha, pbMostrar, pbEsconder);
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita o som "beep"
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void frmTeladeLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }

}




           