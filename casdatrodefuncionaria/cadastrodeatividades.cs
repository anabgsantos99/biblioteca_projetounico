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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using telaatividades;
using casdatrodefuncionaria;
using teladelogin;


namespace cadastrodeatividades

{

    public partial class frmCadastrodeAtividades : Form

    {

        public string codigo { get; set; }

        string  ano, atividade, semana, mes, funcionaria;

        MySqlConnection conexao;

        string data_source = "datasource=localhost; username=root; password=; database=sistemasdetarefas";

        private void frmCadastrodeAtividades_Load(object sender, EventArgs e)

        {

            //Preenchendo os campo com os dados da ListView

            comboBoxAno.Text = ano;

            comboBoxAtividade.Text = atividade;

            comboBoxSemana.Text = semana;

            comboBoxMes.Text = mes;

            comboBoxFuncionaria.Text = funcionaria;

        }

        private void pbSaida_Click(object sender, EventArgs e)
        {
            frmPerguntadeSeguranca.navegabilidade(new frmTeladeLogin(), this);
        }

        private void pbTelaAtividade_Click(object sender, EventArgs e)
        {
            frmPerguntadeSeguranca.navegabilidade(new frmTeladeAtividade(), this);

        }

        public frmCadastrodeAtividades(string codigo, string ano, string atividade, string semana, string mes, string funcionaria)

        {

            InitializeComponent();

            //Preenchendo os campo com os dados da ListView

            this.codigo = codigo;

            this.ano = ano;

            this.atividade = atividade;

            this.semana = semana;

            this.mes = mes;

            this.funcionaria = funcionaria;


            comboBoxFuncionaria.KeyDown += textBox_KeyDown;
            comboBoxAno.KeyDown += textBox_KeyDown;
            comboBoxMes.KeyDown += textBox_KeyDown;
            comboBoxSemana.KeyDown += textBox_KeyDown;
            comboBoxAtividade.KeyDown += textBox_KeyDown;

        }

        private void frmCadastrodeAtividades_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void limparBotao()

        {

            comboBoxFuncionaria.Text = null;

            comboBoxAno.Text = null;

            comboBoxMes.Text = null;

            comboBoxSemana.Text = null;

            comboBoxAtividade.Text = null;

        }


        public void btnSalvar_Click(object sender, EventArgs e)

        {

            try

            {

                if (string.IsNullOrEmpty(comboBoxFuncionaria.Text.Trim()) ||

                    string.IsNullOrEmpty(comboBoxAno.Text.Trim()) ||

                    string.IsNullOrEmpty(comboBoxMes.Text.Trim()) ||

                    string.IsNullOrEmpty(comboBoxSemana.Text.Trim()) ||

                    string.IsNullOrEmpty(comboBoxAtividade.Text.Trim()))

                {

                    MessageBox.Show("Todos os campos devem ser preenchidos.",

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

                //è necessário puxar o código para o formulário atual pois é com ele que vamos controlar qual atividade está sendo alterada

                if (string.IsNullOrEmpty(codigo))
                {
                    

                    cmd.CommandText = "INSERT INTO tarefa (ano, atividade, semana, mes, nomefuncionaria) " +

                        "VALUES (@ano, @atividade, @semana, @mes, @nomefuncionaria)";

                    cmd.Parameters.AddWithValue("@ano", comboBoxAno.Text.Trim());

                    cmd.Parameters.AddWithValue("@atividade", comboBoxAtividade.Text.Trim());

                    cmd.Parameters.AddWithValue("@semana", comboBoxSemana.Text.Trim());

                    cmd.Parameters.AddWithValue("@mes", comboBoxMes.Text.Trim());

                    cmd.Parameters.AddWithValue("@nomefuncionaria", comboBoxFuncionaria.Text.Trim());

                    // Executar o comando de inserção no banco

                    cmd.ExecuteNonQuery();

                    // Menssagem de sucesso

                    MessageBox.Show("Cadastro realizado com Sucesso!",

                        "Sucesso",

                        MessageBoxButtons.OK,

                        MessageBoxIcon.Information);

                }

                else

                {

                    //UPDATE

                    cmd.CommandText = $"UPDATE `tarefa` SET " +

                        $"ano = @ano, " +

                        $"atividade = @atividade, " +

                        $"semana = @semana, " +

                        $"mes = @mes, " +

                        $"nomefuncionaria = @nomefuncionaria " +

                        $"WHERE id = @codigo";

                    cmd.Parameters.AddWithValue("@ano", comboBoxAno.Text.Trim());

                    cmd.Parameters.AddWithValue("@atividade", comboBoxAtividade.Text.Trim());

                    cmd.Parameters.AddWithValue("@semana", comboBoxSemana.Text.Trim());

                    cmd.Parameters.AddWithValue("@mes", comboBoxMes.Text.Trim());

                    cmd.Parameters.AddWithValue("@nomefuncionaria", comboBoxFuncionaria.Text.Trim());

                    cmd.Parameters.AddWithValue("@codigo", codigo);

                    //Executa o comando de alteração no banco

                    cmd.ExecuteNonQuery();

                    //Mensagem de sucesso

                    MessageBox.Show($"Os dados com o código {codigo} foram alterados com Sucesso!",

                        "Sucesso",

                        MessageBoxButtons.OK,

                        MessageBoxIcon.Information);

                }

                limparBotao();

                codigo = null;

                frmPerguntadeSeguranca.navegabilidade(new frmTeladeAtividade(), this);

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

        public void btnCancelar_Click(object sender, EventArgs e)

        {

            try

            {
                codigo = null; 

                if ((comboBoxFuncionaria.Text != null) ||

                   (comboBoxAno.Text != null) ||

                   (comboBoxMes.Text != null) ||

                   (comboBoxSemana.Text != null) ||

                   (comboBoxAtividade.Text != null))

                {

                    limparBotao();

                }

                MessageBox.Show("Cancelado com sucesso ",

                    "Sucesso",

                    MessageBoxButtons.OK,

                    MessageBoxIcon.Information);

            }

            catch (Exception ex)

            {

                //Trata outros tipos de erro

                MessageBox.Show("Ocorreu: " + ex.Message,

                    "Erro",

                    MessageBoxButtons.OK,

                    MessageBoxIcon.Error);

            }

        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);

            }
        }

    }

}

