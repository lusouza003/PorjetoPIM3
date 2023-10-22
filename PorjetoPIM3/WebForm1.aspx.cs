using System;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace PorjetoPIM3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            // Obtenha o valor dos campos de usuário e senha
            string usuario = txtUsuario.Value;
            string senha = txtSenha.Value;

            // String de conexão com o banco de dados local (ajuste a string de conexão conforme necessário)
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Consulta SQL para verificar as credenciais do usuário
                string query = "SELECT * FROM Usuario WHERE usuario = usuario AND senha = senha";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("usuario", usuario);
                    command.Parameters.AddWithValue("senha", senha);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            // Credenciais válidas, autentique o usuário
                            // Você pode redirecionar para a página de destino após o login
                            Response.Redirect("PaginaDeDestino.aspx");
                        }
                        else
                        {
                            // Credenciais inválidas, exiba uma mensagem de erro
                            lblMensagem.Visible = true;
                            lblMensagem.Text = "Credenciais inválidas. Tente novamente.";
                        }
                    }
                }
            }
        }
    }
}
