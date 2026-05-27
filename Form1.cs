using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;

namespace NanatusuTasks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtEmailLogin.Text?.Trim().ToLowerInvariant();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Email and Password Was Required.");
                return;
            }

            using (MySqlConnection con = Database.GetConnection())
            {
                string sql = "SELECT id_users, password FROM users WHERE email=@user";

                using (var command = new MySqlCommand(sql, con))
                {
                    command.Parameters.AddWithValue("@user", user);

                    using (var reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            MessageBox.Show("Email or Password Incorrect.");
                            return;
                        }

                        int userId = reader.GetInt32("id_users");

                        string encryptedPassword =
                            reader.GetString("password");

                        bool correctPassword =
                            BCrypt.Net.BCrypt.Verify(password, encryptedPassword);

                        if (correctPassword)
                        {
                            MessageBox.Show("Login Realizes With Success.");

                            TaskManager main = new TaskManager(userId);

                            main.Show();

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Email or password Incorrects.");
                        }
                    }
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string user = txtEmailLogin.Text?.Trim().ToLowerInvariant();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Email and Password Was Required.");
                return;
            }

            string hash = BCrypt.Net.BCrypt.HashPassword(password);

            using var con = Database.GetConnection();
            using var cmd = new MySqlCommand(
                "INSERT INTO users (email, password) VALUES (@email, @password);", con);

            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = user;
            cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = hash;

            try
            {
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("!!!SUCCEFFULLY!!!You Register Your Account!");
                    txtEmailLogin.Clear();
                    txtPassword.Clear();
                }
            }
            catch (MySqlException ex) when (ex.Number == 1062)
            {
                MessageBox.Show("Email Already Registered.");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

