using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using cadastrodeatividades;
using casdatrodefuncionaria;
using teladelogin;
using System.Runtime.InteropServices;


namespace telaatividades
{
    public partial class frmTeladeAtividade : Form
    {
        public string codigo;


        //Conexão com o banco de dados MySQL
        MySqlConnection Conexao;
        string data_source = "datasource=localhost; username=root; password=; database=sistemasdetarefas";


        public frmTeladeAtividade()
        {
            InitializeComponent();

            //Configuração inicial de ListView para exibição dos dados dos clientes
            lstAtividades.View = View.Details;       //Define a visualização como "Detalhes"
            lstAtividades.LabelEdit = true;          //Permite editar os títulos das colunas
            lstAtividades.AllowColumnReorder = true; //Permite reordenar as colunas
            lstAtividades.FullRowSelect = true;      //Seleciona a linha inteira ao clicar
            lstAtividades.GridLines = true;          //Exibe as linhas de grade no ListView


            //Definindo as colunas do ListView
            lstAtividades.Columns.Add("Código", 100, HorizontalAlignment.Center); //Coluna codigo
            lstAtividades.Columns.Add("Ano", 100, HorizontalAlignment.Center); //Coluna ano
            lstAtividades.Columns.Add("Atividade", 700, HorizontalAlignment.Center); //Coluna atividade
            lstAtividades.Columns.Add("Semana", 100, HorizontalAlignment.Center); //Coluna semana
            lstAtividades.Columns.Add("Mês", 100, HorizontalAlignment.Center); //Coluna mes
            lstAtividades.Columns.Add("Status", 200, HorizontalAlignment.Center); //Coluna situacao
            lstAtividades.Columns.Add("Funcionária", 200, HorizontalAlignment.Center); //Coluna nomefuncionaria

            //Carrega os dados dos clientes na interface
            carregar_atividades();

        }


        protected void carregar_atividade_com_query(string query)
        {
            try
            {
                //cria a conexão com o banco de dados
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                //Executa a consulta SQL fornecida
                MySqlCommand cmd = new MySqlCommand(query, Conexao);

                //Se a consulta contém o parâmetro @q, adiciona o valor da caixa de pesquisa 
                if (query.Contains("@q"))
                {
                    cmd.Parameters.AddWithValue("@q", "%" + txtBuscar.Text + "%");
                }

                //Executa o comando e obtém os resultados
                MySqlDataReader reader = cmd.ExecuteReader();

                //Limpa os itens exixtentes no ListView antes de adicionar novos
                lstAtividades.Items.Clear();

                //Preenche o ListView com os dados dos clientes
                while (reader.Read())
                {
                    //Cria uma linha para cada cliente com os dados retornados da consulta
                    string[] row =
                    {
                        Convert.ToString(reader.GetInt32(0)),
                        reader.GetString(1),
                        reader.GetString(2),
                        Convert.ToString(reader.GetInt32(3)),
                        reader.GetString(4),
                        reader.GetString(5),
                        reader.GetString(6)
                    };


                    //Adiciona a linha ao ListView
                    lstAtividades.Items.Add(new ListViewItem(row));
                }

            }
            catch (MySqlException ex)
            {
                //Trata erros relacionados ao MySQL
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message,
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
                //Garante que a conexão com o banco de dados será fechada, mesmo se ocorrer erro
                if (Conexao != null && Conexao.State == ConnectionState.Open)
                {
                    Conexao.Close();

                    //Teste de fechamento de banco
                    //MessageBox.Show("Conexão fechada com sucesso");
                }
            }
        }

        private void carregar_atividades()
        {
            string query = "SELECT * FROM tarefa ORDER BY id DESC";
            carregar_atividade_com_query(query);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM tarefa WHERE ano LIKE @q OR atividade LIKE @q OR semana LIKE @q OR mes LIKE @q OR situacao LIKE @q OR nomefuncionaria LIKE @q ORDER BY id DESC";
            carregar_atividade_com_query(query);
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {


                if (lstAtividades.SelectedItems.Count > 0) // Verifica se há uma linha selecionada
                {

                    // Obtendo os dados da atividade selecionada
                    string codigo = lstAtividades.SelectedItems[0].SubItems[0].Text;
                    string ano = lstAtividades.SelectedItems[0].SubItems[1].Text;
                    string atividade = lstAtividades.SelectedItems[0].SubItems[2].Text;
                    string semana = lstAtividades.SelectedItems[0].SubItems[3].Text;
                    string mes = lstAtividades.SelectedItems[0].SubItems[4].Text;
                    string funcionaria = lstAtividades.SelectedItems[0].SubItems[6].Text;


                    //Exibir uma MessageBox com o código do cliente
                    DialogResult opcaoEscolhida = MessageBox.Show("Tem certeza que deseja editar a atividade com o código: " + codigo,
                                            "Tem certeza?",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Warning);

                    if (opcaoEscolhida == DialogResult.Yes)
                    {
                        frmCadastrodeAtividades frmCadastro = new frmCadastrodeAtividades(codigo, ano, atividade, semana, mes, funcionaria);
                        frmCadastro.codigo = codigo;
                        frmCadastro.Show();
                    }

                    
                }
                else
                {
                    MessageBox.Show("Selecione a atividade que deseja fazer a edição: ",
                        "Edição",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);

                }
            }
            catch (Exception ex)
            {
                // Exibe mensagem de erro caso não consiga abrir o formulário
                MessageBox.Show("Ocorreu um erro ao abrir o formulário: " + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void btnAlterarStatus_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (lstAtividades.SelectedItems.Count > 0) // Verifica se há uma linha selecionada
                {


                    // Obtendo os dados da atividade selecionada
                    string codigo = lstAtividades.SelectedItems[0].SubItems[0].Text;
                    string status = lstAtividades.SelectedItems[0].SubItems[5].Text;
                    string situacao = "Finalizado";
                    string pendencia = "Pendente";
                    
                    DialogResult opcaoDigitada = MessageBox.Show("Tem certeza que deseja alterar o status com o código: " + codigo,
                                            "Tem certeza?",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Warning);

                    if (opcaoDigitada == DialogResult.Yes)
                    {
                        Conexao = new MySqlConnection(data_source);

                        Conexao.Open();

                        // Comando SQL para inserir um novo cliente no banco de dados

                        MySqlCommand cmd = new MySqlCommand
                        {

                            Connection = Conexao

                        };

                        cmd.Prepare();

                        if (status == pendencia)
                        {
  
                            //Update 

                            cmd.CommandText = $"UPDATE `tarefa` SET " +

                                $"situacao = @situacao " +

                                $"WHERE id = @codigo";

                            cmd.Parameters.AddWithValue("@codigo", codigo);

                            cmd.Parameters.AddWithValue("@situacao", situacao);


                            MessageBox.Show($"O status com o código {codigo} foi alterado para 'Finalizado' com Sucesso!",

                                "Sucesso",

                                MessageBoxButtons.OK,

                                MessageBoxIcon.Information);
                        }
                        else
                        {

                                cmd.CommandText = $"UPDATE `tarefa` SET " +

                                $"situacao = @situacao " +

                                $"WHERE id = @codigo";

                                cmd.Parameters.AddWithValue("@codigo", codigo);

                                cmd.Parameters.AddWithValue("@situacao", pendencia);


                                MessageBox.Show($"O status com o código {codigo} foi alterado 'Pendente' com Sucesso!",

                                    "Sucesso",

                                    MessageBoxButtons.OK,

                                    MessageBoxIcon.Information);
                        }

                        cmd.ExecuteNonQuery();
                    }

                        
                }

                    carregar_atividades();
            }
            catch (MySqlException ex)
            {
                //Trata erros relacionados ao MySQL
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message,
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

                //Garante que a conexão com o banco de dados será fechada, mesmo se ocorrer erro
                if (Conexao != null && Conexao.State == ConnectionState.Open)
                {
                    Conexao.Close();
                    //Teste de fechamento de banco
                    //MessageBox.Show("Conexão fechada com sucesso");
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            excluir_atividades();
        }

        private void excluir_atividades()
        {
            try
            {
                if (lstAtividades.SelectedItems.Count > 0) // Verifica se há uma linha selecionada
                {

                    // Obtendo os dados da atividade selecionada
                    string codigo = lstAtividades.SelectedItems[0].SubItems[0].Text;

                    DialogResult opcaoDigitada = MessageBox.Show("Tem certeza que deseja excluir o registro " + codigo,
                                                             "Tem certeza?",
                                                             MessageBoxButtons.YesNo,
                                                             MessageBoxIcon.Warning);

                    if (opcaoDigitada == DialogResult.Yes)
                    {
                        //Excluir os dados no Banco de Dados

                        Conexao = new MySqlConnection(data_source);
                        Conexao.Open();

                        MySqlCommand cmd = new MySqlCommand();

                        cmd.Connection = Conexao;

                        cmd.Prepare();

                        cmd.CommandText = "DELETE FROM tarefa WHERE id = @codigo";

                        cmd.Parameters.AddWithValue("@codigo", codigo);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Os dados do cliente foram EXCLUÍDOS!",
                                        "Sucesso",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }

                }

                carregar_atividades();
            }
            catch (MySqlException ex)
            {
                //Trata erros relacionados ao MySQL
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message,
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
                //Garante que a conexão com o banco de dados será fechada, mesmo se ocorrer erro
                if (Conexao != null && Conexao.State == ConnectionState.Open)
                {
                    Conexao.Close();
                }
            }
        }


        private void btnTelaCadastrodeAtividades_Click(object sender, EventArgs e)
        {
            frmPerguntadeSeguranca.navegabilidade(new frmCadastrodeAtividades("", "", "", "", "", ""), this);

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmPerguntadeSeguranca.navegabilidade(new frmTeladeLogin(), this);
        }

        private void frmTeladeAtividade_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
