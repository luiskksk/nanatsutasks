using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NanatusuTasks
{
    public partial class TaskManager : Form
    {
        private int user;

        public TaskManager(int user)
        {
            InitializeComponent();
            this.user = user;
            
        }

        private void TaskManager_Load(object sender, EventArgs e)
        {
            LoadTasks();
        }

        private void LoadTasks()
        {
            using var conn = Database.GetConnection();

            const string sql =
                "SELECT id_users, id_works, tittle, complete " +
                "FROM works WHERE id_users = @user";

            using var cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.Add("@user", MySqlDbType.Int32).Value = user;

            using var reader = cmd.ExecuteReader();

            var table = new DataTable();
            table.Load(reader);

            gridTasks.DataSource = table;
        }

        private void lblTittle_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string title = txtTittleTask.Text.Trim();

            // se estiver vazio, cancela operação
            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Digite uma tarefa");
                return;
            }

            // abre conexão com banco
            using (var conn = Database.GetConnection())
            {
                // SQL com parâmetros (evita erro e ataque)
                string sql = "INSERT INTO works (id_users, id_works, tittle, complete ) VALUES (@id_users, @id_works, @tittle, @complete)";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id_works", 0);
                    // @user representa o id do usuário
                    cmd.Parameters.AddWithValue("@id_users", user);

                    // @title recebe o texto digitado
                    cmd.Parameters.AddWithValue("@tittle", title);

                    cmd.Parameters.AddWithValue("@complete", false);

                    // executa INSERT no banco
                    cmd.ExecuteNonQuery();
                }
                txtTittleTask.Clear();

                // recarrega lista
                LoadTasks();
            }

           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // verifica se alguma linha foi selecionada
            if (gridTasks.CurrentRow == null)
                return;

            // pega id da linha selecionada
            int id = Convert.ToInt32(
            gridTasks.CurrentRow.Cells["id_works"].Value
             );

            // CurrentRow = linha selecionada
            // Cells["id"] = coluna id da tabela
            // Value = valor dentro da célula

            using (var conn = Database.GetConnection())
            {
                string sql = "UPDATE works SET complete = TRUE WHERE id_works = @id";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    // substitui @id pelo id da tarefa
                    cmd.Parameters.AddWithValue("@id", id);

                    // executa UPDATE
                    cmd.ExecuteNonQuery();
                }
            }

            // atualiza lista
            LoadTasks();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // verifica se linha foi selecionada
            if (gridTasks.CurrentRow == null)
                return;

            // pega id da tarefa selecionada
            int id = Convert.ToInt32(
                gridTasks.CurrentRow.Cells["id_works"].Value
            );

            using (var conn = Database.GetConnection())
            {
                string sql = "DELETE FROM works WHERE id_works = @id";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    // substitui @id pelo valor real
                    cmd.Parameters.AddWithValue("@id", id);

                    // executa DELETE
                    cmd.ExecuteNonQuery();
                }
            }

            // atualiza lista
            LoadTasks();
        }
    }
}
