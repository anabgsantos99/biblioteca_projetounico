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

namespace casdatrodefuncionaria
{
    public partial class frmCadatroFuncionaria : Form
    {
        MySqlConnection conexao;
        string data_source = "datasource=localhost; username=root; password=; database=sistemasdetarefas";

        string email;
        string nome;
        string senha;
        string confirmarSenha;
        object perguntaSeguranca;
        string respostaSeguranca;

        public frmCadatroFuncionaria()
        {
            InitializeComponent();
        }
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        { try

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

                frmCadastrodeAtividades frmAtividades = new frmCadastrodeAtividades("", "", "", "", "", "");
                frmAtividades.Show();
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
            frmTeladeLogin frmLogin = new frmTeladeLogin();
            frmLogin.Show();
        }


    }

    }



