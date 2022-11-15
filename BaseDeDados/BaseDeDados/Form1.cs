using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlServerCe;
using System.IO;
using System.Net.NetworkInformation;

namespace BaseDeDados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            string baseDados = Application.StartupPath + "\\db\\dbSQLServer.sdf";
            string strConection = @"DataSource = " + baseDados + "; Password = '1234'";

            SqlCeEngine db = new SqlCeEngine(strConection);

            if (!File.Exists(baseDados))
            {
                db.CreateDatabase();
            }
            db.Dispose();

            //Criar conexao com o bando
            SqlCeConnection conexao = new SqlCeConnection(strConection);
            try
            {
                conexao.Open(); //Abrir conexao com banco de dados
                labelResultado.Text = "Concetado Sql Server CE";
            }
            catch (Exception ex)
            {
                labelResultado.Text = "Erro ao conectar Sql Server CE \n" + ex.Message;
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btnCriarTabela_Click(object sender, EventArgs e)
        {
            string baseDados = Application.StartupPath + "\\db\\dbSQLServer.sdf";
            string strConection = @"DataSource = " + baseDados + "; Password = '1234'";

            SqlCeConnection conexao = new SqlCeConnection(strConection);
            try
            {
                conexao.Open();

                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = conexao;

                comando.CommandText = "CREATE TABLE pessoas ( id INT NOT NULL PRIMARY KEY, nome NVARCHAR(50), email NVARCHAR(50) )";
                comando.ExecuteNonQuery();

                labelResultado.Text = "Tabela criada com sucesso";
                comando.Dispose();
            }
            catch (Exception ex)
            {
                labelResultado.Text = ex.Message;
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            string baseDados = Application.StartupPath + "\\db\\dbSQLServer.sdf";
            string strConection = @"DataSource = " + baseDados + "; Password = '1234'";

            SqlCeConnection conexao = new SqlCeConnection(strConection);
            try
            {
                conexao.Open();

                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = conexao;

                int id = new Random(DateTime.Now.Millisecond).Next(0,1000);
                string nome = textBox1.Text;
                string email = textBox2.Text;

                comando.CommandText = "INSERT INTO pessoas (id, nome, email) VALUES (" + id + ", '" + nome + "', '" + email + "')";
                comando.ExecuteNonQuery();

                labelResultado.Text = "Dados inseridos com sucesso";
                textBox1.Clear();
                textBox2.Clear();
                comando.Dispose();
            }
            catch (Exception ex)
            {
                labelResultado.Text = ex.Message;
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            labelResultado.Text = "";
            lista.Rows.Clear();

            string baseDados = Application.StartupPath + "\\db\\dbSQLServer.sdf";
            string strConection = @"DataSource = " + baseDados + "; Password = '1234'";

            SqlCeConnection conexao = new SqlCeConnection(strConection);
            try
            {
                string query = "SELECT * FROM pessoas";

                if (textBox1.Text != "")
                {
                    query = "SELECT * FROM pessoas WHERE nome LIKE '" + textBox1.Text + "'";
                }

                DataTable dados = new DataTable();
                SqlCeDataAdapter adptador = new SqlCeDataAdapter(query, conexao);

                conexao.Open();

                adptador.Fill(dados);

                foreach (DataRow l in dados.Rows)
                {
                    lista.Rows.Add(l.ItemArray);
                }
                
            }
            catch (Exception ex)
            {
                lista.Rows.Clear();
                labelResultado.Text = ex.Message;
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string baseDados = Application.StartupPath + "\\db\\dbSQLServer.sdf";
            string strConection = @"DataSource = " + baseDados + "; Password = '1234'";

            SqlCeConnection conexao = new SqlCeConnection(strConection);
            try
            {
                conexao.Open();

                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = conexao;

                int id = (int)lista.SelectedRows[0].Cells[0].Value;

                comando.CommandText = "DELETE FROM pessoas WHERE id = '" + id + "'" ;
                comando.ExecuteNonQuery();

                labelResultado.Text = "Registro excluido com sucesso";
                comando.Dispose();
            }
            catch (Exception ex)
            {
                labelResultado.Text = ex.Message;
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string baseDados = Application.StartupPath + "\\db\\dbSQLServer.sdf";
            string strConection = @"DataSource = " + baseDados + "; Password = '1234'";

            SqlCeConnection conexao = new SqlCeConnection(strConection);
            try
            {
                conexao.Open();

                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = conexao;

                int id = (int)lista.SelectedRows[0].Cells[0].Value;
                string nome = textBox1.Text;
                string email = textBox2.Text;

                string query = "UPDATE pessoas SET nome = '" + nome + "', email = '" + email + "' WHERE id LIKE '" + id + "'";

                comando.CommandText = query;
                comando.ExecuteNonQuery();

                labelResultado.Text = "Registro alterado com sucesso";
                textBox1.Clear();
                textBox2.Clear();
                comando.Dispose();
            }
            catch (Exception ex)
            {
                labelResultado.Text = ex.Message;
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
