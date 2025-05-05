using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
using cadastrodeatividades;
using teladelogin;
using telaatividades;

namespace casdatrodefuncionaria
{
    public partial class frmCadastroFuncionaria : Form
    {
        MySqlConnection conexao;
        string data_source = "datasource=localhost; username=root; password=; database=sistemasdetarefas";

        public frmCadastroFuncionaria()
        {
            InitializeComponent();

            txtSenha.UseSystemPasswordChar = true;
            txtConfirmarSenha.UseSystemPasswordChar = true;


            txtEmail.KeyDown += textBox_KeyDown;
            txtNome.KeyDown += textBox_KeyDown;
            txtSenha.KeyDown += textBox_KeyDown;
            txtConfirmarSenha.KeyDown += textBox_KeyDown;
            comboBoxPerguntaSeguranca.KeyDown += textBox_KeyDown;
            txtRespostaSeguranca.KeyDown += textBox_KeyDown;
        }

        public static void visibilidade_senha(TextBox textBox, PictureBox showIcon, PictureBox hideIcon)
        {
            if (textBox.UseSystemPasswordChar)
            {
                textBox.UseSystemPasswordChar = false;
                hideIcon.BringToFront();
            }
            else
            {
                textBox.UseSystemPasswordChar = true;
                showIcon.BringToFront();
            }
        }

        private void pbMostrar_Click(object sender, EventArgs e)
        {
            visibilidade_senha(txtSenha, pbMostrar, pbEsconder);
        }

        private void pbEsconder_Click(object sender, EventArgs e)
        {
            visibilidade_senha(txtSenha, pbMostrar, pbEsconder);
        }

        private void pbMostrar2_Click(object sender, EventArgs e)
        {
            visibilidade_senha(txtConfirmarSenha, pbMostrar2, pbEsconder2);
        }

        private void pbEsconder2_Click(object sender, EventArgs e)
        {
            visibilidade_senha(txtConfirmarSenha, pbMostrar2, pbEsconder2);
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }


        private bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try

            {
                if (string.IsNullOrEmpty(txtEmail.Text.Trim()) ||
                 string.IsNullOrEmpty(txtNome.Text.Trim()) ||
                 string.IsNullOrEmpty(txtSenha.Text.Trim()) ||
                 string.IsNullOrEmpty(txtConfirmarSenha.Text.Trim()) ||
                 string.IsNullOrEmpty(comboBoxPerguntaSeguranca.Text.Trim()) ||
                 string.IsNullOrEmpty(txtRespostaSeguranca.Text.Trim()))
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos.",
                                    "Validação",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                // Validação do E-mail

                string email = txtEmail.Text.Trim();
                if (!IsValidEmail(email))
                {
                    MessageBox.Show("E-mail inválido. Certifique-se de que o E-mail está no formato correto.",
                                    "Validação",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                if (txtConfirmarSenha.Text != txtSenha.Text)
                {
                    MessageBox.Show("Certifique-se de que as senhas sejam compátiveis",
                        "Validação",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;

                }
                // cria a conexão com o banco de dados
                conexao = new MySqlConnection(data_source);
                conexao.Open();



                // Comando SQL para inserir um novo cliente no banco de dados
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conexao
                };
                cmd.Prepare();

                cmd.CommandText = "INSERT INTO funcionaria (email, nomecompleto, senha, perguntadeseguranca, resposta) " +
                    "VALUES (@email, @nomecompleto, @senha, @perguntadeseguranca, @resposta)";
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@nomecompleto", txtNome.Text.Trim());
                cmd.Parameters.AddWithValue("@senha", txtSenha.Text.Trim());
                cmd.Parameters.AddWithValue("@perguntadeseguranca", comboBoxPerguntaSeguranca.Text.Trim());
                cmd.Parameters.AddWithValue("@resposta", txtRespostaSeguranca.Text.Trim());

                // Executar o comando de inserção no banco

                cmd.ExecuteNonQuery();

                // Menssagem de sucesso
                MessageBox.Show("Cadastro realizado com sucesso: ",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                frmPerguntadeSeguranca.navegabilidade(new frmTeladeLogin(), this);

            }

            catch (MySqlException ex)
            {
                // Trata erros relacionados ao MySQL

                MessageBox.Show("Erro. " + ex.Number + "Ocorreu: " + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);


            }

            catch (Exception ex)
            {
                //Trata outros tipos de erro

                MessageBox.Show("Ocorreu: " + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            finally
            {
                // Garante que a conexão com o banco de dados será fechada, mesmo se ocorrer erro

                if (conexao != null && conexao.State == ConnectionState.Open)
                {
                    conexao.Close();


                }
            }


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPerguntadeSeguranca.navegabilidade(new frmTeladeLogin(), this);

        }

        private void frmCadastroFuncionaria_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}



